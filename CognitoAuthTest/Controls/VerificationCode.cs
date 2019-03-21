using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBoyPrototype.Controls
{
    public partial class VerificationCode : UserControl
    {
        string username = null;

        public VerificationCode()
        {
            InitializeComponent();
            CLEARLABEL.Select();
        }

        public VerificationCode(string un)
        {
            InitializeComponent();
            CLEARLABEL.Select();
            username = un;
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            CLEARLABEL.Select();
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == "Code")
            {
                txtCode.Text = null;
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                CLEARLABEL.Select();
                txtCode.Text = "Code";
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            CognitoHelper cognitoHelper = new CognitoHelper();

            try
            {
                bool success = await cognitoHelper.VerifyAccessCode(username, txtCode.Text);
                if (success)
                {
                    LogIn logIn = new LogIn();
                    Point loginPoint = new Point(282, 106);

                    logIn.Location = loginPoint;
                    logIn.Show();
                    Program.home.Controls.Add(logIn);

                    this.Dispose();
                }
                else
                {
                    lblCodeError.Visible = true;
                }
            }
            catch (Exception)
            {
                lblCodeError.Visible = true;
            }
        }
    }
}
