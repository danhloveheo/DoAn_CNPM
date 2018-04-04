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
    public partial class LessonSections : UserControl
    {
        public event EventHandler btnChangeCourseClick;

        public LessonSections()
        {
            InitializeComponent();
        }

        public Label LbCourse
        {
            get
            {
                return lbCourse;
            }

            set
            {
                this.lbCourse = value;
            }
        }

        public Panel PnLessonList
        {
            get
            {
                return pnLessonList;
            }

            set
            {
                pnLessonList = value;
            }
        }

        public TableLayoutPanel TpnLessonName
        {
            get
            {
                return tpnLessonName;
            }

            set
            {
                tpnLessonName = value;
            }
        }

        public Panel PnSections
        {
            get
            {
                return pnSections;
            }

            set
            {
                this.pnSections = value;
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
