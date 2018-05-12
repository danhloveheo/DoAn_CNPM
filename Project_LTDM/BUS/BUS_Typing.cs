using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    static public class BUS_Typing
    {
        static public void FindContent(Object o, ref int time, ref string title, ref string Name, ref List<string> text ) //Tìm nội dung bài tập trong
        {
            if (o is DTO_Exercise)
            {
                time = ((DTO_Exercise)o).Time;
                title = ((DTO_Exercise)o).Title;
                Name = ((DTO_Exercise)o).FileName;
                text = ((DTO_Exercise)o).ExerciseText;
            }
        }

        static public bool SaveDataPause(Object o, int timeleft, int position, int star) //Tìm nội dung bài tập trong
        {
            bool result = false;
            DTO_Exercise ob = new DTO_Exercise();
            ob = o as DTO_Exercise;
            ob.Position = position;
            ob.Timeleft = timeleft;
            ob.Star = star;
            return BUS_Exercise.UpdateExercise(ob);
        }
        public static void getAllExercise(ref ListView lsv)
        {
            List<DTO_Exercise> exerciseList = BUS_Exercise.FindAllExercise();
            for (int i = 0; i < exerciseList.Count; i++)
            {
                ListViewItem ls = lsv.Items.Add((i+1).ToString());
                ls.SubItems.Add(exerciseList[i].ExerciseType);
                ls.SubItems.Add(exerciseList[i].Title);
                ls.SubItems.Add(exerciseList[i].Time.ToString());
                ls.SubItems.Add(exerciseList[i].Timeleft.ToString());
                ls.SubItems.Add(exerciseList[i].Star.ToString());
                ls.SubItems.Add(exerciseList[i].Position.ToString());
                ls.SubItems.Add(exerciseList[i].FileName);
            }
        }
        
        public static void StopFocus (Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls != null)
                {
                    StopFocus(c);
                }
                c.TabStop = false;
            }
        }
    }
}
