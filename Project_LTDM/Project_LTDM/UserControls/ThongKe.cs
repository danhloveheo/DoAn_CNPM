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
        public void InitData()
        {
            lsv_tk.Items.Clear();
            Global.Global.ExerciseList = BUS_Exercise.FindAllExercise();
            List<DTO_Exercise> exerciseList = Global.Global.ExerciseList;
            for (int i = 0; i < exerciseList.Count; i++)
            {
                ListViewItem ls = lsv_tk.Items.Add((i + 1).ToString());
                ls.UseItemStyleForSubItems = false;
                ls.SubItems.Add(exerciseList[i].ExerciseType);
                ls.SubItems.Add(exerciseList[i].Title);
                ls.SubItems.Add(exerciseList[i].Time.ToString());
                ls.SubItems.Add(exerciseList[i].Timeleft.ToString());
                ls.SubItems.Add(exerciseList[i].Star.ToString());
                ls.SubItems.Add(exerciseList[i].Position.ToString());
                ls.SubItems.Add(exerciseList[i].FileName);
                if (exerciseList[i].Timeleft == exerciseList[i].Time && exerciseList[i].Star == 0)// chua lam
                {
                    ls.SubItems.Add("New");
                    ls.SubItems[8].ForeColor = Color.Red;
                }
                else if (exerciseList[i].Star == 0 && exerciseList[i].Timeleft > 0 && exerciseList[i].Timeleft < exerciseList[i].Time)// chua hoan thanh
                {
                    ls.SubItems.Add("Inprocess");
                    ls.SubItems[8].ForeColor = Color.LightBlue;
                }
                else if (exerciseList[i].Star > 0)// hoan thanh
                {
                    ls.SubItems.Add("Finished");
                    ls.SubItems[8].ForeColor = Color.Green;
                }
            }
        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemake_Click(object sender, EventArgs e)
        {
           
        }

        private void lsv_tk_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int i in lsv_tk.SelectedIndices)
            {

                int a = 0;
                a = Convert.ToInt32(lsv_tk.Items[i].SubItems[5].Text);
                for (int y = 1; y < 6; y++)
                {
                    PictureBox pcbStar = panel1.Controls.Find("pcbStar" + y, true).FirstOrDefault() as PictureBox;
                    pcbStar.Image = global::Project_LTDM.Properties.Resources.Failed_Star;
                }
                for (int t = 1; t <= a; t++)
                {

                    PictureBox pcbStar = panel1.Controls.Find("pcbStar" + t, true).FirstOrDefault() as PictureBox;

                    pcbStar.Image = global::Project_LTDM.Properties.Resources.OK_Star;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsv_tk.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select items!");
                return;
            }
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
                    Frm_Typing exercise = new Frm_Typing(exerciseTexts, true);
                    Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
                    exercise.ShowDialog(form);
                    InitData();
                }

            }
            else
            {
                MessageBox.Show("Select a item please!");
            }
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            if (lsv_tk.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select items!");
                return;
            }
            string fileNameselect = lsv_tk.SelectedItems[0].SubItems[7].Text;
            //string fileNameselect2 = lsv_tk.SelectedItems[0].SubItems["clFileName"].Text;
            var exerciseTexts = Global.Global.ExerciseList.First(x => x.FileName == fileNameselect);
            if (exerciseTexts != null)
            {
                Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
                Frm_Typing exercise = new Frm_Typing(exerciseTexts, true);
                exercise.ShowDialog(form);
                InitData();
            }
        }

       
     
    }
}
