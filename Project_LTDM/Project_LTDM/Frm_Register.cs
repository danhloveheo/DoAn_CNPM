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
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Username ";
            if(!BUS_Validation.ValidTextFormat(txtUsername.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(txtUsername, errorMsg);
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Password ";
            if (!BUS_Validation.ValidTextFormat(txtPassword.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider2.SetError(txtPassword, errorMsg);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(txtPassword, "");
        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg ="";
            if (!BUS_Validation.ValidConfirmPassword(txtPassword.Text, txtPasswordConfirm.Text,ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider3.SetError(txtPasswordConfirm, errorMsg);
            }
        }

        private void txtPasswordConfirm_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(txtPasswordConfirm, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!BUS_Validation.ValidEmailFormat(txtEmail.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider4.SetError(txtEmail, errorMsg);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(txtEmail, "");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string usernameErr = errorProvider1.GetError(txtUsername);
            string passwordErr = errorProvider2.GetError(txtPassword);
            string passwordConfimErr = errorProvider3.GetError(txtPasswordConfirm);
            string emaailErr = errorProvider4.GetError(txtEmail);

            if (usernameErr != "" || passwordErr != "" || passwordConfimErr != "" || emaailErr !="")
            {
                MessageBox.Show("Please enter valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPasswordConfirm.Text == "" || txtEmail.Text =="")
            {
                MessageBox.Show("Please enter all mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BUS_User.Register(txtUsername.Text, txtPassword.Text, txtEmail.Text) == 1)
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Insert user in database success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm_Login fLogin = new Frm_Login();
            fLogin.Show();
            this.Hide();
        }
    }
}
