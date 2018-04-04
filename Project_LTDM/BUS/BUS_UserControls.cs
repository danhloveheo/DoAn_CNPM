using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using Controls;

namespace BUS
{
    public class BUS_UserControls
    {
        static public void DisposeControls<T>(Form form) //Xoá các control không còn dùng
        {
            List<Control> itemsToRemove = new List<Control>();

            foreach (Control c in form.Controls)
            {
                if (c is T)
                {
                    itemsToRemove.Add(c);
                }
            }

            foreach (Control c in itemsToRemove)
            {
                c.Dispose();
            }
        }

        static public void ShowLessonList(Form form, object sender)
        {
            DisposeControls<Controls.LessonList>(form); //Xoá các LessonList không còn dùng

            Controls.LessonList lessonList = new Controls.LessonList(); //Tạo LessonList mới
            lessonList.Dock = DockStyle.Fill;

            int courseId = (int)((Control)sender).Tag; //Lấy courseId từ tag của button gọi hàm
            string courseName = "";
            switch (courseId)
            {
                case 1:
                    courseName = "Touch Typing Course";
                    break;
                case 2:
                    courseName = "Speed Building Course";
                    break;
                case 3:
                    courseName = "Number, Special Marks and 10-Key Pad Courses";
                    break;
            }
            lessonList.LbCourse.Text = courseName;

            List<DTO_Lesson> lessons = DAO_Lesson.SearchLessons(courseId); // Tạo list chứa các lesson dựa vào courseId
            int repetition = 1;

            foreach (DTO_Lesson lesson in lessons)
            {
                Label lbLessonCnt = new Label();
                lbLessonCnt.Text = repetition + ". ";
                lbLessonCnt.Location = new Point(20, (repetition * 40) - 15);
                lbLessonCnt.AutoSize = true;
                lbLessonCnt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                Label lbLesson = new Label();
                lbLesson.Text = lesson.Name;

                LessonTag lessonTag = new LessonTag(); //Tạo biến chứa tag cho các lbLesson
                //Gán giá trị vào biến chứa tag
                lessonTag.courseId = courseId;
                lessonTag.lessonNumber = repetition;
                lessonTag.lesson = lesson;

                //Gán biến chứa tag vào thuộc tính Tag
                lbLesson.Tag = lessonTag;
                lbLesson.Location = new Point(50, (repetition * 40) - 15);
                lbLesson.AutoSize = true;
                lbLesson.Cursor = System.Windows.Forms.Cursors.Hand;
                lbLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbLesson.ForeColor = Color.Black;
                //lbLesson.ForeColor = System.Drawing.Color.Blue;
                lbLesson.MouseEnter += new EventHandler(ChangeColor);
                lbLesson.MouseLeave += new EventHandler(ChangeColor);
                lbLesson.Click += new EventHandler(ShowLessonSections);

                lessonList.PnLessons.Controls.AddRange(new Control[] { lbLessonCnt, lbLesson });
                repetition++;
            }

            form.Controls.Add(lessonList);
            lessonList.btnChangeCourseClick += new EventHandler(ShowCourse);
            lessonList.BringToFront(); //Add LessonList nới tạo vào form
        }

        static public void ShowLessonSections(object sender, EventArgs e)
        {
            Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
            DisposeControls<LessonSections>(form); //Xoá các LessonSections không còn dùng

            LessonSections lessonSections = new LessonSections(); //Tạo LessonSection mới
            lessonSections.Dock = DockStyle.Fill;

            Label lb = (Label)sender;
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
                lbLessonCnt.Cursor = System.Windows.Forms.Cursors.Hand;
                lbLessonCnt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
                lbLessonCnt.Location = new System.Drawing.Point((repetition - 1)*65 +25, 6);
                lbLessonCnt.Size = new System.Drawing.Size(33, 23);
                lbLessonCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lbLessonCnt.Click += new EventHandler(ShowLessonSections);

                lessonSections.PnLessonList.Controls.Add(lbLessonCnt);
                repetition++;
            }

            //Tạo lbLessonName chứa tên bài học
            Label lbLessonName = new Label();
            lbLessonName.AutoSize = true;
            lbLessonName.Text = "Lesson " + lessonTag.lessonNumber + " : " + lessonTag.lesson.Name;
            lbLessonName.Anchor = AnchorStyles.None;
            lbLessonName.Font = new System.Drawing.Font("Vinhan", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lessonSections.TpnLessonName.Controls.Add(lbLessonName);

            List<DTO_LessonSection> sections = lessonTag.lesson.Sections;

            repetition = 1;
            foreach (DTO_LessonSection section in sections)
            {
                Label lbSectionCnt = new Label();
                lbSectionCnt.Text = courseId + ". " + repetition;
                lbSectionCnt.Location = new Point(40, (repetition - 1) * 60 + 10);
                lbSectionCnt.AutoSize = true;
                lbSectionCnt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
                lbSectionCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

                Label lbSection = new Label();
                lbSection.Text = section.Name;
                lbSection.Location = new Point(100, (repetition - 1) * 60 +10);
                lbSection.AutoSize = true;
                lbSection.Cursor = System.Windows.Forms.Cursors.Hand;
                lbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbSection.ForeColor = System.Drawing.Color.Black;
                lbSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lbSection.MouseEnter += new EventHandler(ChangeColor);
                lbSection.MouseLeave += new EventHandler(ChangeColor);

                lessonSections.PnSections.Controls.AddRange(new Control[] { lbSectionCnt, lbSection });
                repetition++;
            }
            form.Controls.Add(lessonSections);
            lessonSections.btnChangeCourseClick += new EventHandler(ShowCourse);
            lessonSections.BringToFront();
        }

        public static void ShowCourse (object sender, EventArgs e)
        {
            Form form = (Form)(((Control)sender).TopLevelControl); //Tìm form ngoài cùng của sender
            foreach (Control c in form.Controls)
            {
                if (c is KhoaHoc)
                {
                    c.BringToFront();
                }
            }
        }

        static void ChangeColor(object sender, EventArgs e)
        {         
            Label lb = (Label)sender;
            if (lb.ForeColor == Color.Black)
            {
                lb.ForeColor = Color.Blue;
            }
            else
            {
                lb.ForeColor = Color.Black;
            }
        }
    }
}
