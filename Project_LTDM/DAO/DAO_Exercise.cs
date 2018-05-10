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

            exercise.Title = section.Name;
            exercise.Time = section.Time;
            exercise.ExerciseType = section.Type;

            /*if (section.Type == "Key")
            {
                exercise.ExerciseType = "Key";
            }
            else if 
            {
                exercise.ExerciseType = "Text";
            }*/

            exercise.ExerciseText = DAO_LessonSection.ReadExerciseDetailFromSection(section);

            return exercise;
        }
        #endregion

        #region Exercise
        private static string exerciseXmlFilePath = Path.Combine(Environment.CurrentDirectory, "Database", "Exercises", "Exercises.xml");


        static public List<DTO_Exercise> FindAllExercise(ref List<string> warningTitles) //Tìm tất cả bài tập trong file Exercise.xml
        { 
            XmlDocument xd = new XmlDocument();
            FileStream rfile = new FileStream(exerciseXmlFilePath, FileMode.Open);
            xd.Load(rfile);

            List<DTO_Exercise> exercises = new List<DTO_Exercise>();
            XmlNodeList exerciseNodeList = xd.GetElementsByTagName("Exercise"); // Tìm danh sách các bài tập

            string title;
            int time;
            List<string> text;

            foreach (XmlElement exerciseNode in exerciseNodeList)
            {
                title = exerciseNode.GetElementsByTagName("Title")[0].InnerText;
                time = int.Parse(exerciseNode.GetElementsByTagName("Time")[0].InnerText);

                string fileName = exerciseNode.GetElementsByTagName("FileName")[0].InnerText;
                if (FileTxtExist(fileName)) //Nếu file chứa nội dung có tồn tại thì thêm vào danh sách, còn nếu không thì thêm thông tin title của bài tập vào danh sách warningTitles
                {
                    text = ReadTextFromTxt(fileName);
                    DTO_Exercise exercise = new DTO_Exercise("Paragraph", time, title, text);
                    exercises.Add(exercise);
                }
                else
                {
                    warningTitles.Add(title);
                }
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

        static private void CreateTxtFile (string fileName, string[] lines) //Tạo file txt chứa nội dung bài tập
        {
            StreamWriter writer = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "Database", "Exercises", fileName));

            foreach (string line in lines)
            {
                string trim = line.Trim();
                if (!string.IsNullOrEmpty(trim))
                {
                    writer.WriteLine(trim);
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
            XmlText titleText = xd.CreateTextNode(exercise.Title);

            XmlElement timeNode = xd.CreateElement("Time");
            XmlText timeText = xd.CreateTextNode(exercise.Time.ToString());

            XmlElement fileNameNode = xd.CreateElement("FileName");
            string fileName = Guid.NewGuid().ToString() + ".txt";
            XmlText fileNameText = xd.CreateTextNode(fileName);

            titleNode.AppendChild(titleText);
            fileNameNode.AppendChild(fileNameText);
            timeNode.AppendChild(timeText);

            exerciseNode.AppendChild(titleNode);
            exerciseNode.AppendChild(timeNode);
            exerciseNode.AppendChild(fileNameNode);

            xd.DocumentElement.AppendChild(exerciseNode);

            lfile.Close();
            xd.Save(exerciseXmlFilePath);

            //Tạo file chứa nội dung bài tập
            CreateTxtFile(fileName, exercise.ExerciseText.ToArray());
        }

        static public void DeleteExercise (string title)
        {
            XmlDocument xd = new XmlDocument();
            FileStream lfile = new FileStream(exerciseXmlFilePath, FileMode.Open);
            xd.Load(lfile);

            XmlNodeList list = xd.GetElementsByTagName("Exercise");
            foreach (XmlElement e in list)
            {
                XmlElement titleNode = (XmlElement)e.GetElementsByTagName("Title")[0];

                if (titleNode.InnerText == title)
                {
                    //Xoá file bài tập
                    XmlElement fileNameNode = (XmlElement)e.GetElementsByTagName("FileName")[0];

                    if (FileTxtExist(fileNameNode.InnerText))  //Kiểm tra xem file chứa nội dung bài tập có tồn tại hay không
                    {
                        File.Delete((Path.Combine(Environment.CurrentDirectory, "Database", "Exercises", fileNameNode.InnerText)));

                    }

                    xd.DocumentElement.RemoveChild(e); //Xoá dữ liệu trong file Exercise.xml

                    lfile.Close();
                    xd.Save(exerciseXmlFilePath);
                    return;
                }                
            }

            lfile.Close();
        }

        static public bool FileTxtExist (string fileName) //Kiểm tra xem file chứa nội dung bài tập có tồn tại hay không
        {
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "Database", "Exercises", fileName)))
            {
                return true;
            }

            return false;
        }

        static public bool IsExist (string title)
        {
            XmlDocument xd = new XmlDocument();
            FileStream rfile = new FileStream(exerciseXmlFilePath, FileMode.Open);
            xd.Load(rfile);

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
