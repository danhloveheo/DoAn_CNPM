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
            txtDummy.TabStop = true;
            txtDummy.Select();
            this.AcceptButton = btnRegister;
        }
        
        private void Frm_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        

        private void lbRegister_Click(object sender, EventArgs e)
        {
            Frm_Login fLogin = new Frm_Login();
            this.Hide();
            fLogin.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameErr = errorProvider1.GetError(txtUsername);
            string passwordErr = errorProvider2.GetError(txtPassword);
            string passwordConfimErr = errorProvider3.GetError(txtPasswordConfirm);
            string emaailErr = errorProvider4.GetError(txtEmail);

            if (usernameErr != "" || passwordErr != "" || passwordConfimErr != "" || emaailErr != "")
            {
                MessageBox.Show("Please enter valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPasswordConfirm.Text == "" || txtEmail.Text == "")
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

        private void txtEmail_Validated_1(object sender, EventArgs e)
        {
            errorProvider4.SetError(txtEmail, "");
        }

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!BUS_Validation.ValidEmailFormat(txtEmail.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider4.SetError(txtEmail, errorMsg);
            }
        }

        private void txtPasswordConfirm_Validated_1(object sender, EventArgs e)
        {
            errorProvider3.SetError(txtPasswordConfirm, "");
        }

        private void txtPasswordConfirm_Validating_1(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!BUS_Validation.ValidConfirmPassword(txtPassword.Text, txtPasswordConfirm.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider3.SetError(txtPasswordConfirm, errorMsg);
            }
        }

        private void txtPassword_Validated_1(object sender, EventArgs e)
        {
            errorProvider2.SetError(txtPassword, "");
        }

        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
        {
            string errorMsg = "Password ";
            if (!BUS_Validation.ValidTextFormat(txtPassword.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider2.SetError(txtPassword, errorMsg);
            }
        }

        private void txtUsername_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsername, "");
        }

        private void txtUsername_Validating_1(object sender, CancelEventArgs e)
        {
            string errorMsg = "Username ";
            if (!BUS_Validation.ValidTextFormat(txtUsername.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(txtUsername, errorMsg);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string usernameErr = errorProvider1.GetError(txtUsername);
            string passwordErr = errorProvider2.GetError(txtPassword);
            string passwordConfimErr = errorProvider3.GetError(txtPasswordConfirm);
            string emaailErr = errorProvider4.GetError(txtEmail);

            if (usernameErr != "" || passwordErr != "" || passwordConfimErr != "" || emaailErr != "")
            {
                MessageBox.Show("Please enter valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPasswordConfirm.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please enter all mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.Text == "User Name" || txtPassword.Text == "Password" || txtPasswordConfirm.Text == "Password" || txtEmail.Text == "Email")
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
                Frm_Login login = new Frm_Login();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            BUS_Placeholder.NormalTxtEnter((TextBox)sender, "User Name");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            BUS_Placeholder.PasswordTxtEnter((TextBox)sender, "Password");
        }

        private void txtPasswordConfirm_Enter(object sender, EventArgs e)
        {
            BUS_Placeholder.PasswordTxtEnter((TextBox)sender, "Re-Password");
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            BUS_Placeholder.NormalTxtEnter((TextBox)sender, "Email");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            BUS_Placeholder.NormalTxtLeave((TextBox)sender, "User Name");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            BUS_Placeholder.PasswordTxtLeave((TextBox)sender, "Password");
        }

        private void txtPasswordConfirm_Leave(object sender, EventArgs e)
        {
            BUS_Placeholder.PasswordTxtLeave((TextBox)sender, "Re-Password");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            BUS_Placeholder.NormalTxtLeave((TextBox)sender, "Email");
        }

        private void txtDummy_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).TabStop = false;
        }
    }
}
