using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BigBoyPrototype.Controls;
using Exception = System.Exception;

namespace BigBoyPrototype
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
            CLEARLABEL.Select();
        }

        private void SignUp_MouseClick(object sender, MouseEventArgs e)
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

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = null;
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
            lblUNError.Visible = false;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                CLEARLABEL.Select();
                txtEmail.Text = "Email";
            }
            lblEmailError.Visible = false;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                CLEARLABEL.Select();
                txtPassword.isPassword = false;
                txtPassword.Text = "Password";
            }
            else
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMiniMaxChars = new Regex(@".{8,15}");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

                string PW = txtPassword.Text;

                if (!hasLowerChar.IsMatch(PW))
                {
                    lblPWError.Visible = true;
                    lblPWError.Text = "Must have a lowercase character";
                }
                else if (!hasUpperChar.IsMatch(PW))
                {
                    lblPWError.Visible = true;
                    lblPWError.Text = "Must have an uppercase character";
                }
                else if (!hasMiniMaxChars.IsMatch(PW))
                {
                    lblPWError.Visible = true;
                    lblPWError.Text = "Must be between 8 and 15 characters";
                }
                else if (!hasNumber.IsMatch(PW))
                {
                    lblPWError.Visible = true;
                    lblPWError.Text = "Must contain a number";
                }
                else if (!hasSymbols.IsMatch(PW))
                {
                    lblPWError.Visible = true;
                    lblPWError.Text = "Must contain a symbol";
                }
                else
                {
                    lblPWError.Visible = false;
                }
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

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if (dropMonth.selectedValue == "MM" || dropDay.selectedValue == "DD" || dropYear.selectedValue == "YYYY")
            {
                lblBDError.Visible = true;
            }
            else if (lblUNError.Visible == false && lblEmailError.Visible == false && lblPWError.Visible == false)
            {
                CognitoHelper cognitoHelper = new CognitoHelper();

                try
                {
                    string birthday = dropYear.selectedValue + "-" + dropMonth.selectedValue + "-" + dropDay.selectedValue;
                    bool success = await cognitoHelper.SignUpUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, birthday);

                    if (success)
                    {
                        VerificationCode verificationCode = new VerificationCode(txtUsername.Text);
                        Point verificationcodePoint = new Point(281, 162);

                        verificationCode.Location = verificationcodePoint;
                        verificationCode.Show();
                        Program.home.Controls.Add(verificationCode);

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("some unhandled error");
                    }

                }
                catch (Amazon.CognitoIdentityProvider.Model.UsernameExistsException)
                {
                    lblUNError.Visible = true;
                    lblUNError.Text = "Username already exists";
                }
                catch (Amazon.CognitoIdentityProvider.Model.AliasExistsException)
                {
                    lblUNError.Visible = true;
                    lblUNError.Text = "Username already exists";
                }
                catch (Amazon.CognitoIdentityProvider.Model.InvalidParameterException)
                {
                    lblEmailError.Visible = true;
                    lblEmailError.Text = "Invalid email";
                }
                catch (Exception)
                {
                    lblUNError.Visible = true;
                    lblUNError.Text = "Unhandled exception";
                }
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            Point loginPoint = new Point(282, 106);

            logIn.Location = loginPoint;
            logIn.Show();
            Program.home.Controls.Add(logIn);

            this.Dispose();
        }
    }
}
