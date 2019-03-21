namespace BigBoyPrototype.Controls
{
    partial class VerificationCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationCode));
            this.txtCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblVerify = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCodeError = new System.Windows.Forms.Label();
            this.CLEARLABEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txtCode.BackColor = System.Drawing.Color.Black;
            this.txtCode.BorderColorFocused = System.Drawing.Color.Black;
            this.txtCode.BorderColorIdle = System.Drawing.Color.Black;
            this.txtCode.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtCode.BorderThickness = 3;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Gray;
            this.txtCode.isPassword = false;
            this.txtCode.Location = new System.Drawing.Point(20, 124);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(331, 45);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "Code";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(375, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVerify.ForeColor = System.Drawing.Color.White;
            this.lblVerify.Location = new System.Drawing.Point(17, 101);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(177, 17);
            this.lblVerify.TabIndex = 25;
            this.lblVerify.Text = "EMAIL VERIFICATION CODE";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(20, 194);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(328, 42);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCodeError
            // 
            this.lblCodeError.AutoSize = true;
            this.lblCodeError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCodeError.Location = new System.Drawing.Point(17, 175);
            this.lblCodeError.Name = "lblCodeError";
            this.lblCodeError.Size = new System.Drawing.Size(65, 13);
            this.lblCodeError.TabIndex = 27;
            this.lblCodeError.Text = "Invalid code";
            this.lblCodeError.Visible = false;
            // 
            // CLEARLABEL
            // 
            this.CLEARLABEL.AutoSize = true;
            this.CLEARLABEL.Location = new System.Drawing.Point(-21, 235);
            this.CLEARLABEL.Name = "CLEARLABEL";
            this.CLEARLABEL.Size = new System.Drawing.Size(0, 13);
            this.CLEARLABEL.TabIndex = 28;
            // 
            // VerificationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.CLEARLABEL);
            this.Controls.Add(this.lblCodeError);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtCode);
            this.Name = "VerificationCode";
            this.Size = new System.Drawing.Size(381, 249);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtCode;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCodeError;
        private System.Windows.Forms.Label CLEARLABEL;
    }
}
