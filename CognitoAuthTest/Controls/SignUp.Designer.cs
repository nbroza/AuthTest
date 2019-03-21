namespace BigBoyPrototype
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dropDay = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dropMonth = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropYear = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblM1 = new System.Windows.Forms.Label();
            this.lblTOS = new System.Windows.Forms.Label();
            this.lblAnd = new System.Windows.Forms.Label();
            this.lblPrivacy = new System.Windows.Forms.Label();
            this.lblUNError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPWError = new System.Windows.Forms.Label();
            this.picViewPW = new System.Windows.Forms.PictureBox();
            this.CLEARLABEL = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblBDError = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(375, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.BorderColorFocused = System.Drawing.Color.Black;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Black;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(20, 190);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 45);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderColorFocused = System.Drawing.Color.Black;
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Black;
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtUsername.BorderThickness = 3;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(20, 125);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(331, 45);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderColorFocused = System.Drawing.Color.Black;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Black;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.isPassword = false;
            this.txtPassword.Location = new System.Drawing.Point(20, 257);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(331, 45);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // dropDay
            // 
            this.dropDay.BackColor = System.Drawing.Color.Transparent;
            this.dropDay.BorderRadius = 0;
            this.dropDay.DisabledColor = System.Drawing.Color.Gray;
            this.dropDay.ForeColor = System.Drawing.Color.Black;
            this.dropDay.Items = new string[] {
        "DD",
        "01",
        "02",
        "03",
        "04",
        "05",
        "06",
        "07",
        "08",
        "09",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30",
        "31"};
            this.dropDay.Location = new System.Drawing.Point(134, 345);
            this.dropDay.Margin = new System.Windows.Forms.Padding(4);
            this.dropDay.Name = "dropDay";
            this.dropDay.NomalColor = System.Drawing.Color.White;
            this.dropDay.onHoverColor = System.Drawing.Color.White;
            this.dropDay.selectedIndex = 0;
            this.dropDay.Size = new System.Drawing.Size(100, 36);
            this.dropDay.TabIndex = 4;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(17, 324);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(72, 17);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "BIRTHDAY";
            // 
            // dropMonth
            // 
            this.dropMonth.BackColor = System.Drawing.Color.Transparent;
            this.dropMonth.BorderRadius = 0;
            this.dropMonth.DisabledColor = System.Drawing.Color.Gray;
            this.dropMonth.ForeColor = System.Drawing.Color.Black;
            this.dropMonth.Items = new string[] {
        "MM",
        "01",
        "02",
        "03",
        "04",
        "05",
        "06",
        "07",
        "08",
        "09",
        "10",
        "11",
        "12"};
            this.dropMonth.Location = new System.Drawing.Point(20, 345);
            this.dropMonth.Margin = new System.Windows.Forms.Padding(4);
            this.dropMonth.Name = "dropMonth";
            this.dropMonth.NomalColor = System.Drawing.Color.White;
            this.dropMonth.onHoverColor = System.Drawing.Color.White;
            this.dropMonth.selectedIndex = 0;
            this.dropMonth.Size = new System.Drawing.Size(100, 36);
            this.dropMonth.TabIndex = 3;
            // 
            // dropYear
            // 
            this.dropYear.BackColor = System.Drawing.Color.Transparent;
            this.dropYear.BorderRadius = 0;
            this.dropYear.DisabledColor = System.Drawing.Color.Gray;
            this.dropYear.ForeColor = System.Drawing.Color.Black;
            this.dropYear.Items = new string[] {
        "YYYY",
        "2018",
        "2017",
        "2016",
        "2015",
        "2014",
        "2013",
        "2012",
        "2011",
        "2010",
        "2009",
        "2008",
        "2007",
        "2006",
        "2005",
        "2004",
        "2003",
        "2002",
        "2001",
        "2000",
        "1999",
        "1998",
        "1997",
        "1996",
        "1995",
        "1994",
        "1993",
        "1992",
        "1991",
        "1990",
        "1989",
        "1988",
        "1987",
        "1986",
        "1985",
        "1984",
        "1983",
        "1982",
        "1981",
        "1980",
        "1979",
        "1978",
        "1977",
        "1976",
        "1975",
        "1974",
        "1973",
        "1972",
        "1971",
        "1970",
        "1969",
        "1968",
        "1967",
        "1966",
        "1965",
        "1964",
        "1963",
        "1962",
        "1961",
        "1960",
        "1959",
        "1958",
        "1957",
        "1956",
        "1955",
        "1954",
        "1953",
        "1952",
        "1951",
        "1950",
        "1949",
        "1948",
        "1947",
        "1946",
        "1945",
        "1944",
        "1943",
        "1942",
        "1941",
        "1940",
        "1939",
        "1938",
        "1937",
        "1936",
        "1935",
        "1934",
        "1933",
        "1932",
        "1931",
        "1930",
        "1929",
        "1928",
        "1927",
        "1926",
        "1925",
        "1924",
        "1923",
        "1922",
        "1921",
        "1920",
        "1919",
        "1918",
        "1917",
        "1916",
        "1915",
        "1914",
        "1913",
        "1912",
        "1911",
        "1910",
        "1909",
        "1908",
        "1907",
        "1906",
        "1905",
        "1904",
        "1903",
        "1902",
        "1901",
        "1900"};
            this.dropYear.Location = new System.Drawing.Point(248, 345);
            this.dropYear.Margin = new System.Windows.Forms.Padding(4);
            this.dropYear.Name = "dropYear";
            this.dropYear.NomalColor = System.Drawing.Color.White;
            this.dropYear.onHoverColor = System.Drawing.Color.White;
            this.dropYear.selectedIndex = 0;
            this.dropYear.Size = new System.Drawing.Size(100, 36);
            this.dropYear.TabIndex = 5;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(20, 388);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(328, 42);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblM1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblM1.Location = new System.Drawing.Point(31, 443);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(173, 13);
            this.lblM1.TabIndex = 14;
            this.lblM1.Text = "By signing up, you agree to our ";
            // 
            // lblTOS
            // 
            this.lblTOS.AutoSize = true;
            this.lblTOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTOS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTOS.Location = new System.Drawing.Point(199, 444);
            this.lblTOS.Name = "lblTOS";
            this.lblTOS.Size = new System.Drawing.Size(27, 13);
            this.lblTOS.TabIndex = 15;
            this.lblTOS.Text = "TOS";
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblAnd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAnd.Location = new System.Drawing.Point(224, 444);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(27, 13);
            this.lblAnd.TabIndex = 16;
            this.lblAnd.Text = "and";
            // 
            // lblPrivacy
            // 
            this.lblPrivacy.AutoSize = true;
            this.lblPrivacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrivacy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrivacy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPrivacy.Location = new System.Drawing.Point(249, 444);
            this.lblPrivacy.Name = "lblPrivacy";
            this.lblPrivacy.Size = new System.Drawing.Size(78, 13);
            this.lblPrivacy.TabIndex = 17;
            this.lblPrivacy.Text = "Privacy Policy";
            // 
            // lblUNError
            // 
            this.lblUNError.AutoSize = true;
            this.lblUNError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUNError.Location = new System.Drawing.Point(17, 173);
            this.lblUNError.Name = "lblUNError";
            this.lblUNError.Size = new System.Drawing.Size(62, 13);
            this.lblUNError.TabIndex = 18;
            this.lblUNError.Text = "UNERROR";
            this.lblUNError.Visible = false;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailError.Location = new System.Drawing.Point(17, 238);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(78, 13);
            this.lblEmailError.TabIndex = 19;
            this.lblEmailError.Text = "EMAILERROR";
            this.lblEmailError.Visible = false;
            // 
            // lblPWError
            // 
            this.lblPWError.AutoSize = true;
            this.lblPWError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPWError.Location = new System.Drawing.Point(17, 305);
            this.lblPWError.Name = "lblPWError";
            this.lblPWError.Size = new System.Drawing.Size(64, 13);
            this.lblPWError.TabIndex = 20;
            this.lblPWError.Text = "PWERROR";
            this.lblPWError.Visible = false;
            // 
            // picViewPW
            // 
            this.picViewPW.BackColor = System.Drawing.Color.Black;
            this.picViewPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picViewPW.Image = ((System.Drawing.Image)(resources.GetObject("picViewPW.Image")));
            this.picViewPW.Location = new System.Drawing.Point(318, 264);
            this.picViewPW.Name = "picViewPW";
            this.picViewPW.Size = new System.Drawing.Size(27, 30);
            this.picViewPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewPW.TabIndex = 21;
            this.picViewPW.TabStop = false;
            this.picViewPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picViewPW_MouseDown);
            this.picViewPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picViewPW_MouseUp);
            // 
            // CLEARLABEL
            // 
            this.CLEARLABEL.AutoSize = true;
            this.CLEARLABEL.Location = new System.Drawing.Point(3, 434);
            this.CLEARLABEL.Name = "CLEARLABEL";
            this.CLEARLABEL.Size = new System.Drawing.Size(0, 13);
            this.CLEARLABEL.TabIndex = 23;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(17, 102);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(59, 17);
            this.lblSignUp.TabIndex = 24;
            this.lblSignUp.Text = "SIGN UP";
            // 
            // lblBDError
            // 
            this.lblBDError.AutoSize = true;
            this.lblBDError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBDError.Location = new System.Drawing.Point(270, 328);
            this.lblBDError.Name = "lblBDError";
            this.lblBDError.Size = new System.Drawing.Size(78, 13);
            this.lblBDError.TabIndex = 25;
            this.lblBDError.Text = "Invalid birthday";
            this.lblBDError.Visible = false;
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(6, 12);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 70);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 26;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.lblBDError);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.CLEARLABEL);
            this.Controls.Add(this.picViewPW);
            this.Controls.Add(this.lblPWError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblUNError);
            this.Controls.Add(this.lblPrivacy);
            this.Controls.Add(this.lblAnd);
            this.Controls.Add(this.lblTOS);
            this.Controls.Add(this.lblM1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.dropYear);
            this.Controls.Add(this.dropMonth);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dropDay);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.picLogo);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(381, 472);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SignUp_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuDropdown dropDay;
        private System.Windows.Forms.Label lblBirthday;
        private Bunifu.Framework.UI.BunifuDropdown dropMonth;
        private Bunifu.Framework.UI.BunifuDropdown dropYear;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.Label lblTOS;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Label lblPrivacy;
        private System.Windows.Forms.Label lblUNError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPWError;
        private System.Windows.Forms.PictureBox picViewPW;
        private System.Windows.Forms.Label CLEARLABEL;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblBDError;
        private System.Windows.Forms.PictureBox picBack;
    }
}
