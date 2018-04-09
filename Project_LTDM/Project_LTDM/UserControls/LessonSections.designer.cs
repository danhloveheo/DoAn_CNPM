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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonSections));
            this.lbCourse = new System.Windows.Forms.Label();
            this.btnChangeCourse = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnSections = new System.Windows.Forms.Panel();
            this.pnLessonList = new System.Windows.Forms.Panel();
            this.tpnLessonName = new System.Windows.Forms.TableLayoutPanel();
            this.lbLessonName = new System.Windows.Forms.Label();
            this.tpnLessonName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourse.Location = new System.Drawing.Point(33, 12);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(423, 47);
            this.lbCourse.TabIndex = 112;
            this.lbCourse.Text = "Touch Typing Course";
            // 
            // btnChangeCourse
            // 
            this.btnChangeCourse.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeCourse.ForeColor = System.Drawing.Color.Black;
            this.btnChangeCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeCourse.Image")));
            this.btnChangeCourse.Location = new System.Drawing.Point(962, 599);
            this.btnChangeCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCourse.Name = "btnChangeCourse";
            this.btnChangeCourse.Size = new System.Drawing.Size(248, 48);
            this.btnChangeCourse.TabIndex = 111;
            this.btnChangeCourse.Text = "    Change Course";
            this.btnChangeCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeCourse.UseVisualStyleBackColor = false;
            this.btnChangeCourse.Click += new System.EventHandler(this.btnChangeCourse_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.Location = new System.Drawing.Point(0, 75);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1232, 1);
            this.panel8.TabIndex = 110;
            // 
            // pnSections
            // 
            this.pnSections.Location = new System.Drawing.Point(295, 223);
            this.pnSections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSections.Name = "pnSections";
            this.pnSections.Size = new System.Drawing.Size(612, 424);
            this.pnSections.TabIndex = 109;
            // 
            // pnLessonList
            // 
            this.pnLessonList.Location = new System.Drawing.Point(13, 92);
            this.pnLessonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLessonList.Name = "pnLessonList";
            this.pnLessonList.Size = new System.Drawing.Size(1197, 43);
            this.pnLessonList.TabIndex = 108;
            // 
            // tpnLessonName
            // 
            this.tpnLessonName.ColumnCount = 1;
            this.tpnLessonName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.Controls.Add(this.lbLessonName, 0, 0);
            this.tpnLessonName.Location = new System.Drawing.Point(13, 154);
            this.tpnLessonName.Name = "tpnLessonName";
            this.tpnLessonName.RowCount = 1;
            this.tpnLessonName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnLessonName.Size = new System.Drawing.Size(1197, 52);
            this.tpnLessonName.TabIndex = 113;
            // 
            // lbLessonName
            // 
            this.lbLessonName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLessonName.AutoSize = true;
            this.lbLessonName.Font = new System.Drawing.Font("Vinhan", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLessonName.Location = new System.Drawing.Point(540, 5);
            this.lbLessonName.Name = "lbLessonName";
            this.lbLessonName.Size = new System.Drawing.Size(117, 42);
            this.lbLessonName.TabIndex = 0;
            this.lbLessonName.Text = "Lesson ";
            // 
            // LessonSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnLessonName);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.btnChangeCourse);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnSections);
            this.Controls.Add(this.pnLessonList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LessonSections";
            this.Size = new System.Drawing.Size(1232, 668);
            this.tpnLessonName.ResumeLayout(false);
            this.tpnLessonName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Button btnChangeCourse;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnSections;
        private System.Windows.Forms.Panel pnLessonList;
        private System.Windows.Forms.TableLayoutPanel tpnLessonName;
        private System.Windows.Forms.Label lbLessonName;
    }
}
