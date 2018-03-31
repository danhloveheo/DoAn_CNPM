namespace Project_LTDM.UserControls
{
    partial class LessonSections
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
            this.lbSeparator = new System.Windows.Forms.Label();
            this.pnLessonList = new System.Windows.Forms.Panel();
            this.pnSections = new System.Windows.Forms.Panel();
            this.tpnLessonName = new System.Windows.Forms.TableLayoutPanel();
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
            // lbSeparator
            // 
            this.lbSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSeparator.Location = new System.Drawing.Point(17, 67);
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(1197, 2);
            this.lbSeparator.TabIndex = 1;
            // 
            // pnLessonList
            // 
            this.pnLessonList.Location = new System.Drawing.Point(17, 89);
            this.pnLessonList.Name = "pnLessonList";
            this.pnLessonList.Size = new System.Drawing.Size(1197, 43);
            this.pnLessonList.TabIndex = 2;
            // 
            // pnSections
            // 
            this.pnSections.Location = new System.Drawing.Point(296, 219);
            this.pnSections.Name = "pnSections";
            this.pnSections.Size = new System.Drawing.Size(669, 384);
            this.pnSections.TabIndex = 4;
            // 
            // tpnLessonName
            // 
            this.tpnLessonName.CausesValidation = false;
            this.tpnLessonName.ColumnCount = 1;
            this.tpnLessonName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.Location = new System.Drawing.Point(17, 157);
            this.tpnLessonName.Name = "tpnLessonName";
            this.tpnLessonName.RowCount = 1;
            this.tpnLessonName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.Size = new System.Drawing.Size(1197, 46);
            this.tpnLessonName.TabIndex = 0;
            // 
            // LessonSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnLessonName);
            this.Controls.Add(this.pnSections);
            this.Controls.Add(this.pnLessonList);
            this.Controls.Add(this.lbSeparator);
            this.Controls.Add(this.lbCourse);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LessonSections";
            this.Size = new System.Drawing.Size(1232, 668);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbSeparator;
        private System.Windows.Forms.Panel pnLessonList;
        private System.Windows.Forms.Panel pnSections;
        private System.Windows.Forms.TableLayoutPanel tpnLessonName;
    }
}
