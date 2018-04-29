using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using DTO;

namespace DAO
{
    public class DAO_Exercise
    {
        #region Section
        static public DTO_Exercise CreateExercise(DTO_LessonSection section)
        {
            DTO_Exercise exercise = new DTO_Exercise();

            exercise.Name = section.Name;

            if (section.Type == "Key")
            {
                exercise.ExerciseType = "Key";
            }
            else
            {
                exercise.ExerciseType = "Text";
            }

            exercise.ExerciseText = DAO_LessonSection.ReadExerciseDetailFromSection(section);

            return exercise;
        }
        #endregion

        #region Exercise
        private static string exerciseXmlFilePath = Path.Combine(Environment.CurrentDirectory, "Database", "Exercises", "Exercises.xml");


        static public List<DTO_Exercise> FindAllExercise() //Tìm tất cả bài tập trong file Exercise.xml
        { 
            XmlDocument xd = new XmlDocument();
            FileStream rfile = new FileStream(exerciseXmlFilePath, FileMode.Open);
            xd.Load(rfile);

            List<DTO_Exercise> exercises = new List<DTO_Exercise>();
            XmlNodeList exerciseNodeList = xd.GetElementsByTagName("Exercise"); // Tìm danh sách các bài tập

            string name;
            int time;
            List<string> text;

            foreach (XmlElement exerciseNode in exerciseNodeList)
            {
                name = exerciseNode.GetElementsByTagName("Title")[0].InnerText;

                //TODO: Thêm thuộc tính time vào file Exercise.xml
                time = 0;
                text = ReadTextFromTxt(exerciseNode.GetElementsByTagName("FileName")[0].InnerText);

                DTO_Exercise exercise = new DTO_Exercise("Paragraph", time, name, text);
                exercises.Add(exercise);
            }

            rfile.Close();
            return exercises;
        }

        static private List<string> ReadTextFromTxt(string fileName)
        {
            List<string> text = new List<string>();
            string line = "";

            StreamReader reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, "Database", "Exercises", fileName));

            while (reader.Peek() >= 0) //Read to End-of-file
            {
                line = reader.ReadLine();

                if (line != "")
                {
                    text.Add(line);
                }
            }

            reader.Close();
            return text;
        }

        static private void CreateTxt (string fileName, string[] lines)
        {
            StreamWriter writer = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "Database", "Exercises", fileName));

            foreach (string line in lines)
            {
                string trim = line.Trim();
                if (!string.IsNullOrEmpty(trim))
                {
                    writer.WriteLine(trim + " ");
                }
            }

            writer.Close();
        }

        static public void AddExercise (DTO_Exercise exercise)
        {
            XmlDocument xd = new XmlDocument();
            FileStream lfile = new FileStream(exerciseXmlFilePath, FileMode.Open);
            xd.Load(lfile);

            XmlElement exerciseNode = xd.CreateElement("Exercise");

            XmlElement titleNode = xd.CreateElement("Title");
            XmlText titleText = xd.CreateTextNode(exercise.Name);

            XmlElement fileNameNode = xd.CreateElement("FileName");
            string fileName = Guid.NewGuid().ToString() + ".txt";
            XmlText fileNameText = xd.CreateTextNode(fileName);

            titleNode.AppendChild(titleText);
            fileNameNode.AppendChild(fileNameText);

            exerciseNode.AppendChild(titleNode);
            exerciseNode.AppendChild(fileNameNode);

            xd.DocumentElement.AppendChild(exerciseNode);

            lfile.Close();
            xd.Save(exerciseXmlFilePath);

            CreateTxt(fileName, exercise.ExerciseText.ToArray());
        }

        static public bool IsExist (string title)
        {
            XmlDocument xd = new XmlDocument();
            FileStream rfile = new FileStream(exerciseXmlFilePath, FileMode.Open);
            xd.Load(rfile);

            DTO_Exercise user = new DTO_Exercise();
            XmlNodeList list = xd.GetElementsByTagName("Exercise");
            foreach (XmlElement e in list)
            {
                XmlElement titleNode = (XmlElement)e.GetElementsByTagName("Title")[0];

                if (titleNode.InnerText == title)
                {
                    rfile.Close();
                    return true;
                }
            }

            rfile.Close();
            return false;
        }

        #endregion
    }
}
