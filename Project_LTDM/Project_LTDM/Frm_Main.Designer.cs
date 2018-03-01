namespace Project_LTDM
{
    partial class Frm_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TaoBT = new System.Windows.Forms.Button();
            this.btn_ThucTap = new System.Windows.Forms.Button();
            this.Btn_LuyenTap = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TaoBT);
            this.groupBox1.Controls.Add(this.btn_ThucTap);
            this.groupBox1.Controls.Add(this.Btn_LuyenTap);
            this.groupBox1.Controls.Add(this.btn_User);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btn_TaoBT
            // 
            this.btn_TaoBT.Location = new System.Drawing.Point(21, 48);
            this.btn_TaoBT.Name = "btn_TaoBT";
            this.btn_TaoBT.Size = new System.Drawing.Size(75, 23);
            this.btn_TaoBT.TabIndex = 0;
            this.btn_TaoBT.Text = "Tạo Bài Tập";
            this.btn_TaoBT.UseVisualStyleBackColor = true;
            // 
            // btn_ThucTap
            // 
            this.btn_ThucTap.Location = new System.Drawing.Point(21, 106);
            this.btn_ThucTap.Name = "btn_ThucTap";
            this.btn_ThucTap.Size = new System.Drawing.Size(104, 23);
            this.btn_ThucTap.TabIndex = 0;
            this.btn_ThucTap.Text = "Luyen Doan Van";
            this.btn_ThucTap.UseVisualStyleBackColor = true;
            this.btn_ThucTap.Click += new System.EventHandler(this.btn_ThucTap_Click);
            // 
            // Btn_LuyenTap
            // 
            this.Btn_LuyenTap.Location = new System.Drawing.Point(21, 77);
            this.Btn_LuyenTap.Name = "Btn_LuyenTap";
            this.Btn_LuyenTap.Size = new System.Drawing.Size(75, 23);
            this.Btn_LuyenTap.TabIndex = 0;
            this.Btn_LuyenTap.Text = "Luyện Tập";
            this.Btn_LuyenTap.UseVisualStyleBackColor = true;
            this.Btn_LuyenTap.Click += new System.EventHandler(this.Btn_LuyenTap_Click);
            // 
            // btn_User
            // 
            this.btn_User.Location = new System.Drawing.Point(21, 19);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(75, 23);
            this.btn_User.TabIndex = 0;
            this.btn_User.Text = "User";
            this.btn_User.UseVisualStyleBackColor = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 495);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Main";
            this.Text = "Frm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TaoBT;
        private System.Windows.Forms.Button btn_ThucTap;
        private System.Windows.Forms.Button Btn_LuyenTap;
        private System.Windows.Forms.Button btn_User;
    }
}