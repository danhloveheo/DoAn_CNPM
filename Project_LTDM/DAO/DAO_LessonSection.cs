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
    public class DAO_LessonSection
    {
        private static string courseXmlFilePath = Path.Combine(Environment.CurrentDirectory, "Database", "Lessons", "Course.xml");

        //Tìm danh sách các bài luyện tập của 1 bài học dựa vào course id và tên bài học
        public static List<DTO_LessonSection> SearchSections (XmlDocument xd, int courseId, string lessonName)
        {
            List<DTO_LessonSection> sections = new List<DTO_LessonSection>();

            //TODO: Chuyển sang dùng id
            XmlNodeList coursesNodeList = xd.GetElementsByTagName("Course");  // Tìm danh sách các khoá học
            foreach (XmlElement courseNode in coursesNodeList)
            {
                if (courseNode.GetAttribute("Id") == courseId.ToString()) // Tìm khoá học có id trùng với courseId 
                {
                    XmlNodeList lessonsNodeList = courseNode.GetElementsByTagName("Lesson"); // Tìm danh sách các bài học trong khoá học
                    foreach (XmlElement lessonNode in lessonsNodeList)
                    {
                        if (lessonNode.GetAttribute("Name") == lessonName) // Tìm bài học có tên là lessonName
                        {
                            XmlNodeList sectionsNodeList = lessonNode.GetElementsByTagName("Section"); // Tìm danh sách các bài luyện tập của bài học
                            foreach (XmlElement sectionNode in sectionsNodeList) //Thêm các bài luyện tập vào List sections
                            {
                                DTO_LessonSection section = new DTO_LessonSection();

                                section.Name = sectionNode.GetAttribute("Name");
                                section.Type = sectionNode.GetElementsByTagName("Type")[0].InnerText;
                                section.Detail = sectionNode.GetElementsByTagName("Detail")[0].InnerText;
                                sections.Add(section);
                            }
                        }
                    }
                }
            }

            return sections;
        }

        public static List<string> ReadExerciseDetailFromSection (DTO_LessonSection section) //Đọc nội dung file text trong detail
        {
            string exerciseFilePath = Path.Combine(Environment.CurrentDirectory, "Database", "Lessons", section.Detail);

            List<string> detail = new List<string>();
            string line = "";

            StreamReader reader = new StreamReader(exerciseFilePath);

            while (reader.Peek() >= 0) //Read to End-of-file
            {
                line = reader.ReadLine();

                if (line != "")
                {
                    detail.Add(line);
                }
            }

            reader.Close();
            return detail;
    }
    } 
}
