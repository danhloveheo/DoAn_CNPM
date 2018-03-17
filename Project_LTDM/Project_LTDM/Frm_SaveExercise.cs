using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Project_LTDM
{
    public partial class Frm_SaveExercise : Form
    {
        public Frm_SaveExercise()
        {
            InitializeComponent();
        }

        private void Frm_SaveExercise_Load(object sender, EventArgs e)
        {
            rbtnFP.Checked = true;
            rbtnThumb.Checked = true;
        }
        
        private void rbtnFP_CheckedChanged(object sender, EventArgs e)
        {
            CheckType();
        }

        private void rbtnTP_CheckedChanged(object sender, EventArgs e)
        {
            CheckType();
        }

        public void CheckType() //Kiểm tra kiểu bài tập, nếu là bài tập viết đoạn văn thì hide Finger GroupBox
        {
            if (rbtnFP.Checked == true)
            {
                gbxFinger.Show();
            }
            else
            {
                gbxFinger.Hide();
            }
        }

        private void Frm_SaveExercise_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string errMsg = "Name";
            if (!BUS_Validation.ValidName(txtName.Text, ref errMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(txtName, errMsg);
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, "");
        }

        private void txtTime_Validating(object sender, CancelEventArgs e)
        {
            string errMsg = "Time";
            if (!BUS_Validation.ValidTime(txtTime.Text, ref errMsg))
            {
                e.Cancel = true;
                this.errorProvider2.SetError(txtTime, errMsg);
            }
        }

        private void txtTime_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(txtTime, "");
        }

        private void rtxtText_Validating(object sender, CancelEventArgs e)
        {
            string errMsg = "Text";
            if (!BUS_Validation.ValidText(rtxtText.Text, ref errMsg))
            {
                e.Cancel = true;
                this.errorProvider3.SetError(rtxtText, errMsg);
            }
        }

        private void rtxtText_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(rtxtText, "");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string nameErr = errorProvider1.GetError(txtName);
            string timeErr = errorProvider2.GetError(txtTime);
            string textErr = errorProvider3.GetError(rtxtText);

            if (nameErr != "" || timeErr != "" || textErr != "")
            {
                MessageBox.Show("Please enter valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtName.Text == "" || txtTime.Text == "" || rtxtText.Text == "")
            {
                MessageBox.Show("Please enter all mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*if (BUS_User.Register(txtUsername.Text, txtPassword.Text, txtEmail.Text) == 1)
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Insert user in database success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

            int finger = 0;
            foreach (Control control in gbxFinger.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        finger = int.Parse(radio.Tag.ToString());
                    }
                }
            }

            if (rbtnFP.Checked)
            {
                BUS_Exercise.SaveExercise(1, finger, txtName.Text, txtTime.Text, rtxtText.Lines);
                MessageBox.Show("Insert Finger Practice Exercise in database success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BUS_Exercise.SaveExercise(2, finger, txtName.Text, txtTime.Text, rtxtText.Lines);
                MessageBox.Show("Insert Text Practice in database success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
            }
            rtxtText.Clear();
            txtName.Focus();
        }
    }
}
