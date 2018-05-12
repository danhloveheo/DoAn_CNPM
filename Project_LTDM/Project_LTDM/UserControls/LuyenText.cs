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
    public partial class LuyenText : UserControl
    {
        public LuyenText()
        {
            InitializeComponent();

            //Tạo danh sách bài tập
            //Global.Global.ExerciseList = BUS_Exercise.FindAllExercise();
            foreach (Object o in Global.Global.ExerciseList)
            {
                lbxExerciseList.Items.Add(o);
            }

            lbxExerciseList.Sorted = true;
            lbxExerciseList.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
            int time = 0;
            //Frm_Typing exercise = new Frm_Typing(BUS_Exercise.FindContent(lbxExerciseList.SelectedItem, ref time), time);
            DTO_Exercise ob = lbxExerciseList.SelectedItem as DTO_Exercise;
            Frm_Typing exercise = new Frm_Typing(lbxExerciseList.SelectedItem as DTO_Exercise);
            exercise.ShowDialog(form);
        }

        private void lbAdd_Click(object sender, EventArgs e)
        {
            Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
            Frm_SaveExercise saveExercise = new Frm_SaveExercise();
            saveExercise.ShowDialog(form);

            //Refresh ListBox
            lbxExerciseList.Items.Clear();
            lbxExerciseList.Sorted = false;

            List<DTO_Exercise> exerciseList = BUS_Exercise.FindAllExercise();
            foreach (DTO_Exercise o in exerciseList)
            {
                lbxExerciseList.Items.Add(o);
            }

            lbxExerciseList.SelectedIndex = exerciseList.Count - 1;
            lbxExerciseList.Sorted = true;
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            string title = lbxExerciseList.SelectedItem.ToString();
            DialogResult dr = MessageBox.Show("Are you sure you want to delete \"" + title +"\" exercise?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                BUS_Exercise.DeleteExercise(title);

                //Refresh ListBox
                lbxExerciseList.Items.Clear();

                //List<DTO_Exercise> exerciseList = BUS_Exercise.FindAllExercise();
                Global.Global.ExerciseList = BUS_Exercise.FindAllExercise();
                foreach (DTO_Exercise o in Global.Global.ExerciseList)
                {
                    lbxExerciseList.Items.Add(o);
                }

                lbxExerciseList.Sorted = true;
                lbxExerciseList.SelectedIndex = 0;
            }
        }

        private void LuyenText_Load(object sender, EventArgs e)
        {

        }
    }
}
