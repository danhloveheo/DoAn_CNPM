using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_LTDM.UserControls;
using BUS;

namespace Project_LTDM
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            this.khoaHoc1.btnC1Click += new EventHandler(khoaHoc_btnC1Click);
            this.khoaHoc1.btnC2Click += new EventHandler(khoaHoc_btnC2Click);
            this.khoaHoc1.btnC3Click += new EventHandler(khoaHoc_btnC3Click);
            this.khoaHoc1.btnC4Click += new EventHandler(khoaHoc_btnC4Click);
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

       

        private void button7_Click_1(object sender, EventArgs e)
        {
            luyenTap1.BringToFront();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            LuyenText luyenText1 = new LuyenText();
            luyenText1.Dock = DockStyle.Fill;

            this.Controls.Add(luyenText1);
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

        private void khoaHoc_btnC1Click(object sender, EventArgs e)
        {
            ShowLessonList(sender, e);
        }

        private void khoaHoc_btnC2Click(object sender, EventArgs e)
        {
        }

        private void khoaHoc_btnC3Click(object sender, EventArgs e)
        {
            ShowLessonList(sender, e);
        }

        private void khoaHoc_btnC4Click(object sender, EventArgs e)
        {
            ShowLessonList(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowLessonList(object sender, EventArgs e)
        {
            BUS_UserControls.DisposeControls<LessonList>(this); //Xoá các LessonList không còn dùng           

            int courseId = (int)((Control)sender).Tag; //Lấy courseId từ tag của button gọi hàm

            List<Label> labels = BUS_UserControls.SearchLessonsList(courseId);

            LessonList lessonList = new LessonList(courseId, labels);
            lessonList.Dock = DockStyle.Fill;
            //lessonList.btnChangeCourseClick += new EventHandler(BUS_UserControls.ShowCourse);            
            this.Controls.Add(lessonList); //Add LessonList nới tạo vào form

            lessonList.BringToFront();
        }
    }

}
