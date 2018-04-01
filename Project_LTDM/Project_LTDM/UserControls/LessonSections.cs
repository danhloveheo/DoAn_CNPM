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
    public partial class LessonSections : UserControl
    {
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
    }
}
