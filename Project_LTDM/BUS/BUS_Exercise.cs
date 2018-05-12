using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_Exercise
    {
        static public List<DTO_Exercise> FindAllExercise () //Tìm toàn bộ bài tập trong file Exercise.Xml
        {
            List<DTO_Exercise> objects = new List<DTO_Exercise>();
            List<string> warningTitles = new List<string>();

            objects = DAO_Exercise.FindAllExercise(ref warningTitles);

            //Hiển thị thông báo các bài tập bị lỗi
            foreach (string title in warningTitles)
            {
                MessageBox.Show("Exercise \"" + title + "\" has been corrupted or deleted. It will be removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DeleteExercise(title);
            }

            return objects;
        }
        static public bool UpdateExercise(DTO_Exercise ob)
        {
            return DAO_Exercise.UpdateExercise(ob);
        }

        static public List<String> FindContent (Object o, ref int time) //Tìm nội dung bài tập trong
        {
            if (o is DTO_Exercise)
            {
                time = ((DTO_Exercise)o).Time;
                return ((DTO_Exercise)o).ExerciseText;
            }

            return null;
        }
        static public Object FindContent(Object o) //Tìm nội dung bài tập trong
        {
            //if (o is DTO_Exercise)
            //{
            //    time = ((DTO_Exercise)o).Time;
            //    return ((DTO_Exercise)o).ExerciseText;
            //}

            return null;
        }

        static public void AddExercise (string title, int time, string[] lines)
        {
            List<string> text = new List<string>();
            foreach (string s in lines)
            {
                text.Add(s);
            }
            DTO_Exercise exercise = new DTO_Exercise("Paragraph", time, title, text, getFileName(), time, 0, 0);
            DAO_Exercise.AddExercise(exercise);
        }

        static public void DeleteExercise (string title)
        {
            DAO_Exercise.DeleteExercise(title);
        }

        static public bool IsExist (string title)
        {
            return DAO_Exercise.IsExist(title);
        }

        static public bool FileTxtExist (string fileName)
        {
            return DAO_Exercise.FileTxtExist(fileName);
        }

        public static string getFileName()
        {
            return Guid.NewGuid().ToString() + ".txt";
        }
    }
}
