using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class LessonList : UserControl
    {
        public event EventHandler btnChangeCourseClick;

        public LessonList()
        {
            InitializeComponent();
        }

        public Panel PnLessons
        {
            get
            {
                return pnLessons;
            }

            set
            {
                pnLessons = value;
            }
        }

        public Label LbCourse
        {
            get
            {
                return lbCourse;
            }

            set
            {
                lbCourse = value;
            }
        }

        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnChangeCourseClick != null) //Null check makes sure the main page is attached to the event
            {
                this.btnChangeCourseClick(this, e);
            }
        }
    }
}
