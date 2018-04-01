using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
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

        //TODO: Chuyển sang dùng Generic
        private void disposeControls(string name) // Dispose dynamic created control 
        {
            List<Control> itemsToRemove = new List<Control>();

            if (name == "LessonList")
            {
                foreach (Control c in this.Controls)
                {
                    if (c is UserControls.LessonList)
                    {
                        itemsToRemove.Add(c);
                    }
                }
            }

            if (name == "LessonSections")
            {
                foreach (Control c in this.Controls)
                {
                    if (c is UserControls.LessonSections)
                    {
                        itemsToRemove.Add(c);
                    }
                }
            }

            foreach (Control c in itemsToRemove)
            {
                c.Dispose();
            }
        }
        private void khoaHoc_btnC1Click(object sender, EventArgs e)
        {
            disposeControls("LessonList"); //Xoá các LessonList không còn dùng

            UserControls.LessonList lessonList = new UserControls.LessonList(); //Tạo LessonList mới
            lessonList.Dock = DockStyle.Fill;

            // TODO: Chuyểm sang lớp BUS
            lessonList.LbCourse.Text = "Touch Typing Course";
            List<DTO_Lesson> lessons = DAO_Lesson.SearchLessons(1);
            int repetition = 1;

            Label lb1;
            Label lb2;

            foreach (DTO_Lesson lesson in lessons)
            {
                Label lbLessonCnt = new Label();
                lbLessonCnt.Text = repetition + ". ";
                lbLessonCnt.Location = new Point(0, repetition * 25);
                lbLessonCnt.AutoSize = true;

                Label lbLesson = new Label();
                lbLesson.Text = lesson.Name;

                LessonTag lessonTag = new LessonTag(); //Tạo biến chứa tag cho các lbLesson
                //Gán giá trị vào biến chứa tag
                lessonTag.courseId = 1;
                lessonTag.lessonNumber = repetition;
                lessonTag.lesson = lesson;

                //Gán biến chứa tag vào thuộc tính Tag
                lbLesson.Tag = lessonTag;
                lbLesson.Location = new Point(15, repetition * 25);
                lbLesson.AutoSize = true;
                lbLesson.Click += new EventHandler(ShowLessonSections);

                lessonList.PnLessons.Controls.AddRange(new Control[] { lbLessonCnt, lbLesson });
                if (repetition == 1)
                {
                    lb1 = lbLesson;
                }

                if (repetition == 2)
                {
                    lb2 = lbLesson;
                }

                repetition++;
            }

            this.Controls.Add(lessonList);
            lessonList.BringToFront(); //Add LessonList nới tạo vào form
        }

        private void khoaHoc_btnC2Click(object sender, EventArgs e)
        {
        }

        private void khoaHoc_btnC3Click(object sender, EventArgs e)
        {
           /* disposeControls("LessonList"); //Xoá các LessonList không còn dùng

            UserControls.LessonList lessonList = new UserControls.LessonList(); //Tạo LessonList mới
            lessonList.Dock = DockStyle.Fill;

            lessonList.LbCourse.Text = "Speed Building Course";
            List<DTO_Lesson> lessons = DAO_Lesson.SearchLessons(2);
            int repetition = 1;
            foreach (DTO_Lesson lesson in lessons)
            {
                Label lbLessonCnt = new Label();
                lbLessonCnt.Text = repetition + ". ";
                lbLessonCnt.Location = new Point(0, repetition * 25);
                lbLessonCnt.AutoSize = true;

                Label lbLesson = new Label();
                lbLesson.Text = lesson.Name;

                LessonTag lessonTag = new LessonTag(); //Tạo biến chứa tag cho các lbLesson
                //Gán giá trị vào biến chứa tag
                lessonTag.courseId = 2;
                lessonTag.lessonNumber = repetition;
                lessonTag.lesson = lesson;

                //Gán biến chứa tag vào thuộc tính Tag
                lbLesson.Tag = lessonTag;
                lbLesson.Location = new Point(15, repetition * 25);
                lbLesson.AutoSize = true;
                lbLesson.Click += new EventHandler(ShowLessonSections);

                lessonList.PnLessons.Controls.AddRange(new Control[] { lbLessonCnt, lbLesson });
                repetition++;
            }

            this.Controls.Add(lessonList);
            lessonList.BringToFront(); //Add LessonList nới tạo vào form*/
        }

        private void khoaHoc_btnC4Click(object sender, EventArgs e)
        {
            /*disposeControls("LessonList"); //Xoá các LessonList không còn dùng

            UserControls.LessonList lessonList = new UserControls.LessonList(); //Tạo LessonList mới
            lessonList.Dock = DockStyle.Fill;

            lessonList.LbCourse.Text = "Number, Special Marks and 10-Key Pad Courses";
            List<DTO_Lesson> lessons = DAO_Lesson.SearchLessons(3);
            int repetition = 1;
            foreach (DTO_Lesson lesson in lessons)
            {
                Label lbLessonCnt = new Label();
                lbLessonCnt.Text = repetition + ". ";
                lbLessonCnt.Location = new Point(0, repetition * 25);
                lbLessonCnt.AutoSize = true;

                Label lbLesson = new Label();
                lbLesson.Text = lesson.Name;

                LessonTag lessonTag = new LessonTag(); //Tạo biến chứa tag cho các lbLesson
                //Gán giá trị vào biến chứa tag
                lessonTag.courseId = 3;
                lessonTag.lessonNumber = repetition;
                lessonTag.lesson = lesson;

                //Gán biến chứa tag vào thuộc tính Tag
                lbLesson.Tag = lessonTag;
                lbLesson.Location = new Point(15, repetition * 25);
                lbLesson.AutoSize = true;
                lbLesson.Click += new EventHandler(ShowLessonSections);

                lessonList.PnLessons.Controls.AddRange(new Control[] { lbLessonCnt, lbLesson });
                repetition++;
            }

            this.Controls.Add(lessonList);
            lessonList.BringToFront(); //Add LessonList nới tạo vào form*/
        }

        private void ShowLessonSections(object sender, EventArgs e)
        {
            disposeControls("LessonSections"); //Xoá các LessonSections không còn dùng

            UserControls.LessonSections lessonSections = new UserControls.LessonSections(); //Tạo LessonSection mới
            lessonSections.Dock = DockStyle.Fill;

           /* Label lb = (Label)sender;
            LessonTag lessonTag = (LessonTag)lb.Tag; //Ép kiểu thuộc tính Tag sang LessonTag
            int courseId = lessonTag.courseId;

            switch (courseId)
            {
                case 1:
                    lessonSections.LbCourse.Text = "Touch Typing Course";
                    break;
                case 2:
                    lessonSections.LbCourse.Text = "Speed Building Course";
                    break;
                case 3:
                    lessonSections.LbCourse.Text = "Number, Special Marks and 10-Key Pad Courses";
                    break;
                default:
                    lessonSections.LbCourse.Text = "";
                    break;
            }

            List<DTO_Lesson> lessons = DAO_Lesson.SearchLessons(courseId);

            //Tạo label chứa số thứ tự các bài học
            int repetition = 1;
            foreach (DTO_Lesson lesson in lessons)
            {
                //Tạo tag cho các label
                LessonTag lessonCntTag = new LessonTag();
                lessonCntTag.courseId = courseId;
                lessonCntTag.lessonNumber = repetition;
                lessonCntTag.lesson = lesson;

                Label lbLessonCnt = new Label();
                lbLessonCnt.Text = repetition.ToString();
                lbLessonCnt.Tag = lessonCntTag;
                lbLessonCnt.Location = new Point((repetition - 1) * 30, 0);
                lbLessonCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lbLessonCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbLessonCnt.AutoSize = true;
                lbLessonCnt.Click += new EventHandler(ShowLessonSections);

                lessonSections.PnLessonList.Controls.Add(lbLessonCnt);
                repetition++;
            }

            //Tạo lbLessonName chứa tên bài học
            Label lbLessonName = new Label();
            lbLessonName.AutoSize = true;
            lbLessonName.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbLessonName.Text = "Lesson " + lessonTag.lessonNumber + " : " + lessonTag.lesson.Name;
            lbLessonName.Anchor = AnchorStyles.None;
        

            List<DTO_LessonSection> sections = lessonTag.lesson.Sections;

            repetition = 1;
            foreach (DTO_LessonSection section in sections)
            {
                Label lbSectionCnt = new Label();
                lbSectionCnt.Text = courseId + ". " + repetition;
                lbSectionCnt.Location = new Point(0, repetition * 25);
                lbSectionCnt.AutoSize = true;

                Label lbSection = new Label();
                lbSection.Text = section.Name;
                lbSection.Location = new Point(25, repetition * 25);
                lbSection.AutoSize = true;

                lessonSections.PnSections.Controls.AddRange(new Control[] { lbSectionCnt, lbSection });
                repetition++;
            }*/
            this.Controls.Add(lessonSections);
            lessonSections.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
