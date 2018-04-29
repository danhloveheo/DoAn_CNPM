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

namespace Project_LTDM.UserControls
{
    public partial class LuyenText : UserControl
    {
        public LuyenText()
        {
            InitializeComponent();

            //Tạo danh sách bài tập
            List<Object> exerciseList = BUS_Exercise.FindAllExercise();
            foreach (Object o in exerciseList)
            {
                lbxExerciseList.Items.Add(o);
            }

            lbxExerciseList.Sorted = true; 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
            Frm_Typing exercise = new Frm_Typing(BUS_Exercise.FindContent(lbxExerciseList.SelectedItem));
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

            List<Object> exerciseList = BUS_Exercise.FindAllExercise();
            foreach (Object o in exerciseList)
            {
                lbxExerciseList.Items.Add(o);
            }

            lbxExerciseList.SelectedIndex = exerciseList.Count - 1;
            lbxExerciseList.Sorted = true;
        }
    }
}
