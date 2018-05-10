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
    public partial class LessonSections : UserControl   {
        public LessonSections()
        {
            InitializeComponent();
        }

        public LessonSections(LessonTag tag, List<Label> labels, List<Label> buttons)
        {
            InitializeComponent();

            switch (tag.courseId)
            {
                case 1:
                    this.lbCourse.Text = "Touch Typing Course";
                    break;
                case 2:
                    this.lbCourse.Text = "Most Common Words Course";
                    break;
                case 3:
                    this.lbCourse.Text = "Speed Building Course";
                    break;
                case 4:
                    this.lbCourse.Text = "Number, Special Marks and 10-Key Pad Courses";
                    break;
                default:
                    this.lbCourse.Text = "";
                    break;
            }

            foreach (Label lb in buttons)
            {
                lb.Click += new EventHandler(ShowLessonSections);
            }
            this.pnLessonList.Controls.AddRange(buttons.ToArray());

            this.lbLessonName.Text += tag.lessonNumber + " : " + BUS_UserControls.ReadNameFromTag(tag);

            foreach (Label lb in labels)
            {
                if (lb.Tag != null)
                {
                    lb.Click += new EventHandler(ShowTypingForm);
                }

                this.pnSections.Controls.Add(lb);
            }

            this.Dock = DockStyle.Fill;
        }

        public static void ShowLessonSections (object sender, EventArgs e)
        {
            Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
            BUS_UserControls.DisposeControls<LessonSections>(form); //Xoá các LessonSections không còn dùng

            LessonTag lessonTag = (LessonTag)(((Label)sender).Tag); //Ép kiểu thuộc tính Tag sang LessonTag


            List<Label> buttons = new List<Label>();
            List<Label> labels = BUS_UserControls.SearchLessonSections(lessonTag, sender, ref buttons);

            LessonSections lessonSections = new LessonSections(lessonTag, labels, buttons); //Tạo LessonSection mới

            form.Controls.Add(lessonSections);
            lessonSections.BringToFront();
        }

        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            KhoaHoc.ReturnToCourse(sender, e);
        }

        public static void ShowTypingForm (object sender, EventArgs e)
        {
            string exerciseType = "";
            int time = 0;
            List<string> exerciseText = BUS_UserControls.SearchTypingInfo(sender, ref exerciseType, ref time);

            Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender

            if (exerciseType == "Key")
            {
                Frm_FingerExercise exercise = new Frm_FingerExercise(exerciseText, time);
                exercise.ShowDialog(form);

            }
            else
            {
                Frm_Typing exercise = new Frm_Typing(exerciseText, exerciseType, time);
                exercise.ShowDialog(form);
            }
        }
    }
}
