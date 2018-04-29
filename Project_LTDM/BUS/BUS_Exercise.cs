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
            objects.AddRange(DAO_Exercise.FindAllExercise());

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

        static public void AddExercise (string tittle, string[] lines)
        {
            List<string> text = new List<string>();
            foreach (string s in lines)
            {
                text.Add(s);
            }

            DTO_Exercise exercise = new DTO_Exercise("Paragraph", 0, tittle, text);
            DAO_Exercise.AddExercise(exercise);
        }

        static public bool IsExist (string title)
        {
            return DAO_Exercise.IsExist(title);
        }
    }
}
