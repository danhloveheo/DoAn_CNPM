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
            /*Frm_LuyenTap frm = new Frm_LuyenTap();
            frm.ShowDialog();*/

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Typing frm = new Frm_Typing();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            khoaHoc1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            taoBaiTap1.BringToFront();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            luyenTap1.BringToFront();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            luyenText1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thongKe1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            information1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
