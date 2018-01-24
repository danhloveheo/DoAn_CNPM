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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

     

      
    
      
      

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

       

       

        private void lbRegister_Click(object sender, EventArgs e)
        {
            Frm_Register fRegister = new Frm_Register();
            fRegister.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usernameErr = errorProvider1.GetError(txtUsername);
            string passwordErr = errorProvider2.GetError(txtPassword);

            if (usernameErr != "" || passwordErr != "")
            {
                MessageBox.Show("Please enter valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter all mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BUS_User.Login(txtUsername.Text, txtPassword.Text) == 1)
            {
                MessageBox.Show("Account does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS_User.Login(txtUsername.Text, txtPassword.Text) == 2)
            {
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Username ";
            if (!BUS_Validation.ValidTextFormat(txtUsername.Text, ref errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(txtUsername, errorMsg);
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
