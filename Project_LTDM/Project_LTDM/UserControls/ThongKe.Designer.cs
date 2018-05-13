namespace Project_LTDM.UserControls
{
    partial class ThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnRemake = new System.Windows.Forms.Button();
            this.lsv_tk = new System.Windows.Forms.ListView();
            this.clOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTypeEx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTimeleft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "  Statistics";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(534, 324);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(109, 23);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue Exercise";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnRemake
            // 
            this.btnRemake.Location = new System.Drawing.Point(655, 324);
            this.btnRemake.Name = "btnRemake";
            this.btnRemake.Size = new System.Drawing.Size(131, 23);
            this.btnRemake.TabIndex = 6;
            this.btnRemake.Text = "Remake Exercise";
            this.btnRemake.UseVisualStyleBackColor = true;
            this.btnRemake.Click += new System.EventHandler(this.btnRemake_Click);
            // 
            // lsv_tk
            // 
            this.lsv_tk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clOrder,
            this.clTypeEx,
            this.clTitle,
            this.clTime,
            this.clTimeleft,
            this.clStar,
            this.clPosition,
            this.clFileName,
            this.clProcess});
            this.lsv_tk.FullRowSelect = true;
            this.lsv_tk.Location = new System.Drawing.Point(22, 105);
            this.lsv_tk.Name = "lsv_tk";
            this.lsv_tk.Size = new System.Drawing.Size(776, 200);
            this.lsv_tk.TabIndex = 7;
            this.lsv_tk.UseCompatibleStateImageBehavior = false;
            this.lsv_tk.View = System.Windows.Forms.View.Details;
            // 
            // clOrder
            // 
            this.clOrder.Text = "Order";
            this.clOrder.Width = 80;
            // 
            // clTypeEx
            // 
            this.clTypeEx.Text = "Loại Bài Tập";
            this.clTypeEx.Width = 80;
            // 
            // clTitle
            // 
            this.clTitle.Text = "Title";
            this.clTitle.Width = 150;
            // 
            // clTime
            // 
            this.clTime.Text = "Time";
            // 
            // clTimeleft
            // 
            this.clTimeleft.Text = "TimeLeft";
            // 
            // clStar
            // 
            this.clStar.Text = "Star";
            // 
            // clPosition
            // 
            this.clPosition.Text = "position key";
            // 
            // clFileName
            // 
            this.clFileName.Text = "FileName";
            this.clFileName.Width = 0;
            // 
            // clProcess
            // 
            this.clProcess.Text = "Process";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsv_tk);
            this.Controls.Add(this.btnRemake);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(924, 543);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnRemake;
        private System.Windows.Forms.ListView lsv_tk;
        private System.Windows.Forms.ColumnHeader clOrder;
        private System.Windows.Forms.ColumnHeader clTypeEx;
        private System.Windows.Forms.ColumnHeader clTitle;
        private System.Windows.Forms.ColumnHeader clTime;
        private System.Windows.Forms.ColumnHeader clTimeleft;
        private System.Windows.Forms.ColumnHeader clStar;
        private System.Windows.Forms.ColumnHeader clPosition;
        private System.Windows.Forms.ColumnHeader clFileName;
        private System.Windows.Forms.ColumnHeader clProcess;
    }
}
