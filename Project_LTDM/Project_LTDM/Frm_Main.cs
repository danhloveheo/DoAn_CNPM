using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTDM
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

    

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_LuyenTap frm = new Frm_LuyenTap();
            frm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Typing frm = new Frm_Typing();
            frm.ShowDialog();
        }
    }
}
