using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTDM.UserControls
{
    public partial class LessonList : UserControl
    {
        public LessonList()
        {
            InitializeComponent();
        }

        public LessonList(int courseId, List<Label> labels)
        {
            InitializeComponent();

            switch (courseId)
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

            foreach (Label lb in labels)
            {
                if (lb.Tag != null)
                {
                    lb.Click += new EventHandler(LessonSections.ShowLessonSections);
                }

                this.pnLessons.Controls.Add(lb);
            }
        }

        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            KhoaHoc.ReturnToCourse(sender, e);
        }
    }
}
