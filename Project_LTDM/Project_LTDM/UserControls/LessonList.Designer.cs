namespace Project_LTDM.UserControls
{
    partial class LessonList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLessons = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourse.Location = new System.Drawing.Point(19, 22);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(138, 47);
            this.lbCourse.TabIndex = 0;
            this.lbCourse.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lessons";
            // 
            // pnLessons
            // 
            this.pnLessons.Location = new System.Drawing.Point(109, 132);
            this.pnLessons.Name = "pnLessons";
            this.pnLessons.Size = new System.Drawing.Size(410, 399);
            this.pnLessons.TabIndex = 2;
            // 
            // LessonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnLessons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCourse);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LessonList";
            this.Size = new System.Drawing.Size(1232, 668);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLessons;
    }
}
