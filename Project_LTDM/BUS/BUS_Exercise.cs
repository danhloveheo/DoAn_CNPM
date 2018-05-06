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
        static public List<Object> FindAllExercise () //Tìm toàn bộ bài tập trong file Exercise.Xml
        {
            List<Object> objects = new List<Object>();
            List<string> warningTitles = new List<string>();

            objects.AddRange(DAO_Exercise.FindAllExercise(ref warningTitles));

            //Hiển thị thông báo các bài tập bị lỗi
            foreach (string title in warningTitles)
            {
                MessageBox.Show("Exercise \"" + title + "\" has been corrupted or deleted. It will be removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DeleteExercise(title);
            }

            return objects;
        }

        static public List<String> FindContent (Object o) //Tìm nội dung bài tập trong o
        {
            if (o is DTO_Exercise)
            {
                return ((DTO_Exercise)o).ExerciseText;
            }

            return null;
        }

        static public void AddExercise (string title, string[] lines)
        {
            List<string> text = new List<string>();
            foreach (string s in lines)
            {
                text.Add(s);
            }

            DTO_Exercise exercise = new DTO_Exercise("Paragraph", 0, title, text);
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
    }
}
