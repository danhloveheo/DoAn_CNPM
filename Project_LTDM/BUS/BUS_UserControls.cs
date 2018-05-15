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

        static public List<Label> SearchLessonsList(int courseId)
        {
            List<DTO_Lesson> lessons = DAO_Lesson.SearchLessons(courseId); // Tạo list chứa các lesson dựa vào courseId
            List<Label> labels = new List<Label>();
            int repetition = 1;

            foreach (DTO_Lesson lesson in lessons)
            {
                Label lbLessonCnt = new Label();
                lbLessonCnt.Text = repetition + ". ";
                lbLessonCnt.Location = new Point(20, (repetition * 35) - 20);
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
                lbLesson.Location = new Point(60, (repetition * 35) - 20);
                lbLesson.AutoSize = true;
                lbLesson.Cursor = System.Windows.Forms.Cursors.Hand;
                lbLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbLesson.ForeColor = Color.Black;
                lbLesson.MouseEnter += new EventHandler(ChangeColor);
                lbLesson.MouseLeave += new EventHandler(ChangeColor);

                labels.AddRange(new List<Label> { lbLessonCnt, lbLesson });
                repetition++;
            }

            return labels;
        }

        static public List<Label> SearchLessonSections(LessonTag tag, object sender, ref List<Label> buttons)
        {
            List<DTO_Lesson> lessons = DAO_Lesson.SearchLessons(tag.courseId);

            //Tạo label chứa số thứ tự các bài học
            int repetition = 1;
            foreach (DTO_Lesson lesson in lessons)
            {
                //Tạo tag cho các label
                LessonTag lessonCntTag = new LessonTag();
                lessonCntTag.courseId = tag.courseId;
                lessonCntTag.lessonNumber = repetition;
                lessonCntTag.lesson = lesson;

                //Tạo các nút bấm để di chuyển giữa các bài học
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

                buttons.Add(lbLessonCnt);
                repetition++;
            }

            List<DTO_LessonSection> sections = tag.lesson.Sections;
            List<Label> labels = new List<Label>();

            repetition = 1;
            foreach (DTO_LessonSection section in sections)
            {
                Label lbSectionCnt = new Label();
                lbSectionCnt.Text = tag.lessonNumber + ". " + repetition;
                lbSectionCnt.Location = new Point(20, (repetition - 1) * 60 + 10);
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
                lbSection.Tag = DAO_Exercise.CreateExercise(section);
                lbSection.MouseEnter += new EventHandler(ChangeColor);
                lbSection.MouseLeave += new EventHandler(ChangeColor);

                labels.AddRange(new List<Label> { lbSectionCnt, lbSection });
                repetition++;
            }

            return labels;
        }

        public static string ReadNameFromTag (LessonTag tag)
        {
            return tag.lesson.Name;
        }

        public static DTO_Exercise SearchTypingInfo(object sender)
        {
            DTO_Exercise exercise = (DTO_Exercise)(((Control)sender).Tag); //Lấy đối tượng DTO_Exercise đc lưu trong tag của label đã nhấn vào
            return exercise;
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
