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
    }
}
