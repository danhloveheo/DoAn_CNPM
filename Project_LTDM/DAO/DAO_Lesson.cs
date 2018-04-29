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
    public class DAO_Lesson
    {
        private static string courseXmlFilePath = Path.Combine(Environment.CurrentDirectory, "Database", "Lessons", "Course.xml");

        //Tìm danh sách các bài học của 1 khoá học dựa vào courseId
        public static List<DTO_Lesson> SearchLessons (int courseId)
        {
            XmlDocument xd = new XmlDocument();
            FileStream rfile = new FileStream(courseXmlFilePath, FileMode.Open);
            xd.Load(rfile);

            List<DTO_Lesson> lessons = new List<DTO_Lesson>();
            XmlNodeList coursesNodeList = xd.GetElementsByTagName("Course"); // Tìm danh sách các khoá học
            foreach (XmlElement courseNode in coursesNodeList )
            {
                if (courseNode.GetAttribute("Id") == courseId.ToString()) //Tìm khoá học có courseId
                {
                    XmlNodeList lessonsNodeList = courseNode.GetElementsByTagName("Lesson"); //Tìm danh sách các bài học trong khoá học
                    foreach (XmlElement lessonNode in lessonsNodeList) //Thêm các bài học vào List lessons
                    {
                        DTO_Lesson lesson = new DTO_Lesson();
                        lesson.CourseId = courseId;
                        lesson.Name = lessonNode.GetAttribute("Name");
                        lesson.Sections = DAO_LessonSection.SearchSections(xd, courseId, lesson.Name);
                        lessons.Add(lesson);
                    }
                }
            }

            rfile.Close();
            return lessons;
        }
    }
}
