using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Project_LTDM.UserControls
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            InitData();
        }
        void InitData()
        {
            lsv_tk.Items.Clear();
            List<DTO_Exercise> exerciseList = Global.Global.ExerciseList;
            for (int i = 0; i < exerciseList.Count; i++)
            {
                ListViewItem ls = lsv_tk.Items.Add((i + 1).ToString());
                ls.SubItems.Add(exerciseList[i].ExerciseType);
                ls.SubItems.Add(exerciseList[i].Title);
                ls.SubItems.Add(exerciseList[i].Time.ToString());
                ls.SubItems.Add(exerciseList[i].Timeleft.ToString());
                ls.SubItems.Add(exerciseList[i].Star.ToString());
                ls.SubItems.Add(exerciseList[i].Position.ToString());
                ls.SubItems.Add(exerciseList[i].FileName);
                if (exerciseList[i].Timeleft == exerciseList[i].Time)// chua lam
                {
                    ls.SubItems.Add("TODO"); 
                }
                else if (exerciseList[i].Star == 0 && exerciseList[i].Timeleft > 0 && exerciseList[i].Timeleft < exerciseList[i].Time)// chua hoan thanh
                {
                    ls.SubItems.Add("Inprocess");
                }
                else if (exerciseList[i].Star > 0)// hoan thanh
                {
                    ls.SubItems.Add("Finished");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Global.Global.ExerciseList = BUS_Exercise.FindAllExercise();
            InitData();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (lsv_tk.SelectedItems.Count == 0)
                return;
            string fileNameselect = lsv_tk.SelectedItems[0].SubItems[7].Text;
            //string fileNameselect2 = lsv_tk.SelectedItems[0].SubItems["clFileName"].Text;
            var exerciseTexts = Global.Global.ExerciseList.First(x => x.FileName == fileNameselect);
            if (exerciseTexts != null)
            {
                Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
                Frm_Typing exercise = new Frm_Typing(exerciseTexts);
                exercise.ShowDialog(form);
            }
        }

        private void btnRemake_Click(object sender, EventArgs e)
        {
            string fileNameselect = lsv_tk.SelectedItems[0].SubItems[7].Text;
            //string fileNameselect2 = lsv_tk.SelectedItems[0].SubItems["clFileName"].Text;
            var exerciseTexts = Global.Global.ExerciseList.First(x => x.FileName == fileNameselect);
            if (exerciseTexts != null)
            {
                DialogResult result = MessageBox.Show("You was finshed this Exercise. Do You Want to Remake?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    exerciseTexts.Timeleft = exerciseTexts.Time;
                    exerciseTexts.Star = 0;
                    exerciseTexts.Position = 0;
                    Frm_Typing exercise = new Frm_Typing(exerciseTexts);
                    Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
                    exercise.ShowDialog(form);
                }

            }
            else
            {
                MessageBox.Show("Select a item please!");
            }
        }

        private void lsv_tk_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
