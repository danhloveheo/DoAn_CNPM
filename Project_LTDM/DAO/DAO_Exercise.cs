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
        private static string exerciseXmlFilePath = Path.Combine(Environment.CurrentDirectory, "Exercise.xml");

        private static void CreateXML()
        {
            if(File.Exists(exerciseXmlFilePath))
            {
                return;
            }
            else
            {
                XmlTextWriter xtw = new XmlTextWriter(exerciseXmlFilePath, Encoding.UTF8);
                xtw.WriteStartDocument();
                xtw.WriteStartElement("ExerciseDetail");
                xtw.WriteEndElement();
                xtw.Close();
            }
        }

        public static void InsertExercise(DTO_Exercise exercise) //Type 1 là FP, 2 là TP
        {
            CreateXML();
            XmlDocument xd = new XmlDocument();
            FileStream lfile = new FileStream(exerciseXmlFilePath, FileMode.Open);
            xd.Load(lfile);

            XmlElement exNode;
            switch (exercise.ExerciseType)
            {
                case 1:
                    string finger;
                    switch (exercise.Finger)
                    {
                        case 1: finger = "Thumb"; break;
                        case 2: finger = "Index"; break;
                        case 3: finger = "Middle"; break;
                        case 4: finger = "Ring"; break;
                        case 5: finger = "Pinky"; break;
                        default: finger = ""; break;
                    }
                    exNode = xd.CreateElement("FingerExercise");
                    exNode.SetAttribute("Type", finger);
                    break;
                case 2:
                    exNode = xd.CreateElement("TextExercise");
                    break;
                default:
                    exNode = xd.CreateElement("Invalid");
                    break;
            }

            XmlElement nameNode = xd.CreateElement("Name");
            XmlText nameText = xd.CreateTextNode(exercise.Name);
            XmlElement timeNode = xd.CreateElement("Time");
            XmlText timeText = xd.CreateTextNode(exercise.Time.ToString());

            StringBuilder text = new StringBuilder();
            switch (exercise.ExerciseType)
            {  
                case 1:
                    foreach (string line in exercise.Lines)
                    {
                        foreach (char ch in line)
                        {
                            text.Append(ch);
                            text.Append(",");
                        }
                    }
                    text.Length--;
                    break;
                case 2:
                    foreach (string line in exercise.Lines)
                    {
                        text.Append(line);
                        //text.Append(Environment.NewLine);
                    }
                    //text.Length--;
                    break;
            }

            XmlElement textNode = xd.CreateElement("Text");
            XmlText textText = xd.CreateTextNode(text.ToString());

            nameNode.AppendChild(nameText);
            timeNode.AppendChild(timeText);
            textNode.AppendChild(textText);

            exNode.AppendChild(nameNode);
            exNode.AppendChild(timeNode);
            exNode.AppendChild(textNode);

            //Thêm node vào cuối danh sách các node cùng loại bài tập
            XmlNodeList list = xd.GetElementsByTagName(exercise.ExerciseType == 1 ? "FingerExercise" : "TextExercise");
            xd.DocumentElement.InsertAfter(exNode, list[list.Count - 1]);

            lfile.Close();
            xd.Save(exerciseXmlFilePath);
        }
    }
}
