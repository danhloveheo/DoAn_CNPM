namespace Project_LTDM
{
    partial class Frm_SaveExercise
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rbtnTP = new System.Windows.Forms.RadioButton();
            this.rbtnFP = new System.Windows.Forms.RadioButton();
            this.gbxFinger = new System.Windows.Forms.GroupBox();
            this.rbtnPinky = new System.Windows.Forms.RadioButton();
            this.rbtnRing = new System.Windows.Forms.RadioButton();
            this.rbtnMiddle = new System.Windows.Forms.RadioButton();
            this.rbtnIndex = new System.Windows.Forms.RadioButton();
            this.rbtnThumb = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rtxtText = new System.Windows.Forms.RichTextBox();
            this.gbxType.SuspendLayout();
            this.gbxFinger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(66, 52);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(185, 22);
            this.txtTime.TabIndex = 3;
            this.txtTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtTime_Validating);
            this.txtTime.Validated += new System.EventHandler(this.txtTime_Validated);
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(309, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 17);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text";
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbtnTP);
            this.gbxType.Controls.Add(this.rbtnFP);
            this.gbxType.Location = new System.Drawing.Point(16, 96);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(142, 91);
            this.gbxType.TabIndex = 6;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Type";
            // 
            // rbtnTP
            // 
            this.rbtnTP.AutoSize = true;
            this.rbtnTP.Location = new System.Drawing.Point(6, 60);
            this.rbtnTP.Name = "rbtnTP";
            this.rbtnTP.Size = new System.Drawing.Size(111, 21);
            this.rbtnTP.TabIndex = 1;
            this.rbtnTP.TabStop = true;
            this.rbtnTP.Tag = "2";
            this.rbtnTP.Text = "Text Practice";
            this.rbtnTP.UseVisualStyleBackColor = true;
            this.rbtnTP.CheckedChanged += new System.EventHandler(this.rbtnTP_CheckedChanged);
            // 
            // rbtnFP
            // 
            this.rbtnFP.AutoSize = true;
            this.rbtnFP.Location = new System.Drawing.Point(7, 33);
            this.rbtnFP.Name = "rbtnFP";
            this.rbtnFP.Size = new System.Drawing.Size(124, 21);
            this.rbtnFP.TabIndex = 0;
            this.rbtnFP.TabStop = true;
            this.rbtnFP.Tag = "1";
            this.rbtnFP.Text = "Finger Practice";
            this.rbtnFP.UseVisualStyleBackColor = true;
            this.rbtnFP.CheckedChanged += new System.EventHandler(this.rbtnFP_CheckedChanged);
            // 
            // gbxFinger
            // 
            this.gbxFinger.Controls.Add(this.rbtnPinky);
            this.gbxFinger.Controls.Add(this.rbtnRing);
            this.gbxFinger.Controls.Add(this.rbtnMiddle);
            this.gbxFinger.Controls.Add(this.rbtnIndex);
            this.gbxFinger.Controls.Add(this.rbtnThumb);
            this.gbxFinger.Location = new System.Drawing.Point(174, 96);
            this.gbxFinger.Name = "gbxFinger";
            this.gbxFinger.Size = new System.Drawing.Size(151, 181);
            this.gbxFinger.TabIndex = 7;
            this.gbxFinger.TabStop = false;
            this.gbxFinger.Text = "Finger";
            // 
            // rbtnPinky
            // 
            this.rbtnPinky.AutoSize = true;
            this.rbtnPinky.Location = new System.Drawing.Point(7, 144);
            this.rbtnPinky.Name = "rbtnPinky";
            this.rbtnPinky.Size = new System.Drawing.Size(63, 21);
            this.rbtnPinky.TabIndex = 4;
            this.rbtnPinky.TabStop = true;
            this.rbtnPinky.Tag = "5";
            this.rbtnPinky.Text = "Pinky";
            this.rbtnPinky.UseVisualStyleBackColor = true;
            // 
            // rbtnRing
            // 
            this.rbtnRing.AutoSize = true;
            this.rbtnRing.Location = new System.Drawing.Point(7, 116);
            this.rbtnRing.Name = "rbtnRing";
            this.rbtnRing.Size = new System.Drawing.Size(102, 21);
            this.rbtnRing.TabIndex = 3;
            this.rbtnRing.TabStop = true;
            this.rbtnRing.Tag = "4";
            this.rbtnRing.Text = "Ring Finger";
            this.rbtnRing.UseVisualStyleBackColor = true;
            // 
            // rbtnMiddle
            // 
            this.rbtnMiddle.AutoSize = true;
            this.rbtnMiddle.Location = new System.Drawing.Point(7, 88);
            this.rbtnMiddle.Name = "rbtnMiddle";
            this.rbtnMiddle.Size = new System.Drawing.Size(114, 21);
            this.rbtnMiddle.TabIndex = 2;
            this.rbtnMiddle.TabStop = true;
            this.rbtnMiddle.Tag = "3";
            this.rbtnMiddle.Text = "Middle Finger";
            this.rbtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rbtnIndex
            // 
            this.rbtnIndex.AutoSize = true;
            this.rbtnIndex.Location = new System.Drawing.Point(7, 60);
            this.rbtnIndex.Name = "rbtnIndex";
            this.rbtnIndex.Size = new System.Drawing.Size(106, 21);
            this.rbtnIndex.TabIndex = 1;
            this.rbtnIndex.TabStop = true;
            this.rbtnIndex.Tag = "2";
            this.rbtnIndex.Text = "Index Finger";
            this.rbtnIndex.UseVisualStyleBackColor = true;
            // 
            // rbtnThumb
            // 
            this.rbtnThumb.AutoSize = true;
            this.rbtnThumb.Location = new System.Drawing.Point(6, 33);
            this.rbtnThumb.Name = "rbtnThumb";
            this.rbtnThumb.Size = new System.Drawing.Size(73, 21);
            this.rbtnThumb.TabIndex = 0;
            this.rbtnThumb.TabStop = true;
            this.rbtnThumb.Tag = "1";
            this.rbtnThumb.Text = "Thumb";
            this.rbtnThumb.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(531, 351);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(640, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // rtxtText
            // 
            this.rtxtText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtText.Location = new System.Drawing.Point(350, 16);
            this.rtxtText.Name = "rtxtText";
            this.rtxtText.Size = new System.Drawing.Size(349, 320);
            this.rtxtText.TabIndex = 5;
            this.rtxtText.Text = "";
            this.rtxtText.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtText_Validating);
            this.rtxtText.Validated += new System.EventHandler(this.rtxtText_Validated);
            // 
            // Frm_SaveExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(728, 386);
            this.Controls.Add(this.rtxtText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxFinger);
            this.Controls.Add(this.gbxType);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Frm_SaveExercise";
            this.Text = "Save Exercise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_SaveExercise_FormClosing);
            this.Load += new System.EventHandler(this.Frm_SaveExercise_Load);
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.gbxFinger.ResumeLayout(false);
            this.gbxFinger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rbtnTP;
        private System.Windows.Forms.RadioButton rbtnFP;
        private System.Windows.Forms.GroupBox gbxFinger;
        private System.Windows.Forms.RadioButton rbtnPinky;
        private System.Windows.Forms.RadioButton rbtnRing;
        private System.Windows.Forms.RadioButton rbtnMiddle;
        private System.Windows.Forms.RadioButton rbtnIndex;
        private System.Windows.Forms.RadioButton rbtnThumb;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.RichTextBox rtxtText;
    }
}