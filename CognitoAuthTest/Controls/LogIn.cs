using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BigBoyPrototype.Controls;

namespace BigBoyPrototype
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
            CLEARLABEL.Select();
        }

        private void LogIn_MouseClick(object sender, MouseEventArgs e)
        {
            CLEARLABEL.Select();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            CLEARLABEL.Select();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = null;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = null;
                txtPassword.isPassword = true;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                CLEARLABEL.Select();
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                CLEARLABEL.Select();
                txtPassword.isPassword = false;
                txtPassword.Text = "Password";
            }
        }

        private void picViewPW_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                txtPassword.isPassword = false;
            }
        }

        private void picViewPW_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                txtPassword.isPassword = true;
            }
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            CognitoHelper cognitoHelper = new CognitoHelper();

            try 
            {
                var cognitoUser = await cognitoHelper.ValidateUser(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Validated!");
            }
            catch(Amazon.CognitoIdentityProvider.Model.UserNotFoundException)
            {
                errorUI("User not found");
            }
            catch(Amazon.CognitoIdentityProvider.Model.InvalidPasswordException)
            {
                errorUI("Invalid password");
            }
            catch(Exception)
            {
                errorUI("Unexpected error");
            }
        }

        private void errorUI(string error)
        {
            lblIncorrect.Visible = true;
            lblIncorrect.Text = error;

            Point buttonPoint = new Point(20, 279);
            Point noaccPoint = new Point(83, 327);
            Point signupPoint = new Point(209, 327);
            btnLogIn.Location = buttonPoint;
            lblNoAccount.Location = noaccPoint;
            lblSignUp.Location = signupPoint;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            Point signupPoint = new Point(282, 40);

            signUp.Location = signupPoint;
            signUp.Show();
            Program.home.Controls.Add(signUp);

            this.Dispose();
        }
    }
}
