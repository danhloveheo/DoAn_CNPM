namespace Project_LTDM
{
    partial class Frm_Rating
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rating));
            this.lbComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbStar5 = new System.Windows.Forms.PictureBox();
            this.pcbStar4 = new System.Windows.Forms.PictureBox();
            this.pcbStar3 = new System.Windows.Forms.PictureBox();
            this.pcbStar2 = new System.Windows.Forms.PictureBox();
            this.pcbStar1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnChangeCourse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Font = new System.Drawing.Font("Vinhan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComment.Location = new System.Drawing.Point(191, 27);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(117, 33);
            this.lbComment.TabIndex = 0;
            this.lbComment.Text = "Congrat!!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcbStar5);
            this.panel1.Controls.Add(this.pcbStar4);
            this.panel1.Controls.Add(this.pcbStar3);
            this.panel1.Controls.Add(this.pcbStar2);
            this.panel1.Controls.Add(this.pcbStar1);
            this.panel1.Location = new System.Drawing.Point(7, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 100);
            this.panel1.TabIndex = 1;
            // 
            // pcbStar5
            // 
            this.pcbStar5.Image = global::Project_LTDM.Properties.Resources.Failed_Star;
            this.pcbStar5.Location = new System.Drawing.Point(507, 2);
            this.pcbStar5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbStar5.Name = "pcbStar5";
            this.pcbStar5.Size = new System.Drawing.Size(88, 94);
            this.pcbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar5.TabIndex = 4;
            this.pcbStar5.TabStop = false;
            // 
            // pcbStar4
            // 
            this.pcbStar4.Image = global::Project_LTDM.Properties.Resources.Failed_Star;
            this.pcbStar4.Location = new System.Drawing.Point(384, 2);
            this.pcbStar4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbStar4.Name = "pcbStar4";
            this.pcbStar4.Size = new System.Drawing.Size(88, 94);
            this.pcbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar4.TabIndex = 3;
            this.pcbStar4.TabStop = false;
            // 
            // pcbStar3
            // 
            this.pcbStar3.Image = global::Project_LTDM.Properties.Resources.Failed_Star;
            this.pcbStar3.Location = new System.Drawing.Point(261, 2);
            this.pcbStar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbStar3.Name = "pcbStar3";
            this.pcbStar3.Size = new System.Drawing.Size(88, 94);
            this.pcbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar3.TabIndex = 2;
            this.pcbStar3.TabStop = false;
            // 
            // pcbStar2
            // 
            this.pcbStar2.Image = global::Project_LTDM.Properties.Resources.Failed_Star;
            this.pcbStar2.Location = new System.Drawing.Point(139, 2);
            this.pcbStar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbStar2.Name = "pcbStar2";
            this.pcbStar2.Size = new System.Drawing.Size(88, 94);
            this.pcbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar2.TabIndex = 1;
            this.pcbStar2.TabStop = false;
            // 
            // pcbStar1
            // 
            this.pcbStar1.Image = global::Project_LTDM.Properties.Resources.Failed_Star;
            this.pcbStar1.Location = new System.Drawing.Point(16, 2);
            this.pcbStar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbStar1.Name = "pcbStar1";
            this.pcbStar1.Size = new System.Drawing.Size(88, 94);
            this.pcbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar1.TabIndex = 0;
            this.pcbStar1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnChangeCourse
            // 
            this.btnChangeCourse.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeCourse.ForeColor = System.Drawing.Color.Black;
            this.btnChangeCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeCourse.Image")));
            this.btnChangeCourse.Location = new System.Drawing.Point(240, 199);
            this.btnChangeCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeCourse.Name = "btnChangeCourse";
            this.btnChangeCourse.Size = new System.Drawing.Size(167, 55);
            this.btnChangeCourse.TabIndex = 112;
            this.btnChangeCourse.TabStop = false;
            this.btnChangeCourse.Text = "        OK";
            this.btnChangeCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeCourse.UseVisualStyleBackColor = false;
            this.btnChangeCourse.Click += new System.EventHandler(this.btnChangeCourse_Click);
            // 
            // Frm_Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 266);
            this.Controls.Add(this.btnChangeCourse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbStar5;
        private System.Windows.Forms.PictureBox pcbStar4;
        private System.Windows.Forms.PictureBox pcbStar3;
        private System.Windows.Forms.PictureBox pcbStar2;
        private System.Windows.Forms.PictureBox pcbStar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnChangeCourse;
    }
}