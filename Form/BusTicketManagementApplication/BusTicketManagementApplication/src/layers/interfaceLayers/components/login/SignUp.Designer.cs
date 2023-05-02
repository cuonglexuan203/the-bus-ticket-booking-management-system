namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlMainContainer = new System.Windows.Forms.Panel();
            this.LbErrorMessage = new System.Windows.Forms.Label();
            this.LbLogin = new System.Windows.Forms.Label();
            this.PnlUserInput = new System.Windows.Forms.Panel();
            this.ChbShow = new System.Windows.Forms.CheckBox();
            this.PnlPhone = new System.Windows.Forms.Panel();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.LbPhone = new System.Windows.Forms.Label();
            this.PnlFullName = new System.Windows.Forms.Panel();
            this.TbFullName = new System.Windows.Forms.TextBox();
            this.LbFullName = new System.Windows.Forms.Label();
            this.PnlPassword = new System.Windows.Forms.Panel();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.PnlUsername = new System.Windows.Forms.Panel();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbSignUp = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.PnlMainContainer.SuspendLayout();
            this.PnlUserInput.SuspendLayout();
            this.PnlPhone.SuspendLayout();
            this.PnlFullName.SuspendLayout();
            this.PnlPassword.SuspendLayout();
            this.PnlUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.BackColor = System.Drawing.Color.White;
            this.PnlMainContainer.Controls.Add(this.LbErrorMessage);
            this.PnlMainContainer.Controls.Add(this.LbLogin);
            this.PnlMainContainer.Controls.Add(this.PnlUserInput);
            this.PnlMainContainer.Controls.Add(this.LbSignUp);
            this.PnlMainContainer.Controls.Add(this.BtnSignUp);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(503, 680);
            this.PnlMainContainer.TabIndex = 0;
            this.PnlMainContainer.Click += new System.EventHandler(this.Handler_Click);
            // 
            // LbErrorMessage
            // 
            this.LbErrorMessage.AutoSize = true;
            this.LbErrorMessage.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LbErrorMessage.Location = new System.Drawing.Point(39, 582);
            this.LbErrorMessage.Name = "LbErrorMessage";
            this.LbErrorMessage.Size = new System.Drawing.Size(0, 18);
            this.LbErrorMessage.TabIndex = 7;
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbLogin.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.ForeColor = System.Drawing.Color.Blue;
            this.LbLogin.Location = new System.Drawing.Point(361, 622);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(65, 21);
            this.LbLogin.TabIndex = 6;
            this.LbLogin.Text = "Login";
            this.LbLogin.Click += new System.EventHandler(this.LbLogin_Click);
            // 
            // PnlUserInput
            // 
            this.PnlUserInput.Controls.Add(this.ChbShow);
            this.PnlUserInput.Controls.Add(this.PnlPhone);
            this.PnlUserInput.Controls.Add(this.PnlFullName);
            this.PnlUserInput.Controls.Add(this.PnlPassword);
            this.PnlUserInput.Controls.Add(this.PnlUsername);
            this.PnlUserInput.Location = new System.Drawing.Point(12, 94);
            this.PnlUserInput.Name = "PnlUserInput";
            this.PnlUserInput.Size = new System.Drawing.Size(479, 393);
            this.PnlUserInput.TabIndex = 5;
            this.PnlUserInput.Click += new System.EventHandler(this.Handler_Click);
            // 
            // ChbShow
            // 
            this.ChbShow.AutoSize = true;
            this.ChbShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.ChbShow.Location = new System.Drawing.Point(41, 365);
            this.ChbShow.Name = "ChbShow";
            this.ChbShow.Size = new System.Drawing.Size(175, 25);
            this.ChbShow.TabIndex = 8;
            this.ChbShow.TabStop = false;
            this.ChbShow.Text = "Show password";
            this.ChbShow.UseVisualStyleBackColor = true;
            this.ChbShow.CheckedChanged += new System.EventHandler(this.ChbShow_CheckedChanged);
            // 
            // PnlPhone
            // 
            this.PnlPhone.Controls.Add(this.TbPhone);
            this.PnlPhone.Controls.Add(this.LbPhone);
            this.PnlPhone.Location = new System.Drawing.Point(30, 283);
            this.PnlPhone.Margin = new System.Windows.Forms.Padding(0);
            this.PnlPhone.Name = "PnlPhone";
            this.PnlPhone.Size = new System.Drawing.Size(417, 65);
            this.PnlPhone.TabIndex = 9;
            this.PnlPhone.Click += new System.EventHandler(this.Handler_Click);
            // 
            // TbPhone
            // 
            this.TbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPhone.Location = new System.Drawing.Point(15, 41);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(390, 21);
            this.TbPhone.TabIndex = 4;
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.ForeColor = System.Drawing.Color.Gray;
            this.LbPhone.Location = new System.Drawing.Point(11, 10);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(65, 21);
            this.LbPhone.TabIndex = 3;
            this.LbPhone.Text = "Phone";
            // 
            // PnlFullName
            // 
            this.PnlFullName.Controls.Add(this.TbFullName);
            this.PnlFullName.Controls.Add(this.LbFullName);
            this.PnlFullName.Location = new System.Drawing.Point(30, 200);
            this.PnlFullName.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFullName.Name = "PnlFullName";
            this.PnlFullName.Size = new System.Drawing.Size(417, 65);
            this.PnlFullName.TabIndex = 8;
            this.PnlFullName.Click += new System.EventHandler(this.Handler_Click);
            // 
            // TbFullName
            // 
            this.TbFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbFullName.Location = new System.Drawing.Point(15, 41);
            this.TbFullName.Name = "TbFullName";
            this.TbFullName.Size = new System.Drawing.Size(390, 21);
            this.TbFullName.TabIndex = 3;
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.ForeColor = System.Drawing.Color.Gray;
            this.LbFullName.Location = new System.Drawing.Point(11, 10);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(109, 21);
            this.LbFullName.TabIndex = 3;
            this.LbFullName.Text = "Full Name";
            // 
            // PnlPassword
            // 
            this.PnlPassword.Controls.Add(this.TbPassword);
            this.PnlPassword.Controls.Add(this.LbPassword);
            this.PnlPassword.Location = new System.Drawing.Point(30, 117);
            this.PnlPassword.Margin = new System.Windows.Forms.Padding(0);
            this.PnlPassword.Name = "PnlPassword";
            this.PnlPassword.Size = new System.Drawing.Size(417, 65);
            this.PnlPassword.TabIndex = 7;
            this.PnlPassword.Click += new System.EventHandler(this.Handler_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPassword.Location = new System.Drawing.Point(15, 41);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(390, 21);
            this.TbPassword.TabIndex = 2;
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.ForeColor = System.Drawing.Color.Gray;
            this.LbPassword.Location = new System.Drawing.Point(11, 10);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(98, 21);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Password";
            // 
            // PnlUsername
            // 
            this.PnlUsername.Controls.Add(this.TbUsername);
            this.PnlUsername.Controls.Add(this.LbUsername);
            this.PnlUsername.Location = new System.Drawing.Point(30, 34);
            this.PnlUsername.Margin = new System.Windows.Forms.Padding(0);
            this.PnlUsername.Name = "PnlUsername";
            this.PnlUsername.Size = new System.Drawing.Size(417, 65);
            this.PnlUsername.TabIndex = 6;
            this.PnlUsername.Click += new System.EventHandler(this.Handler_Click);
            // 
            // TbUsername
            // 
            this.TbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbUsername.Location = new System.Drawing.Point(15, 41);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(390, 21);
            this.TbUsername.TabIndex = 1;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.ForeColor = System.Drawing.Color.Gray;
            this.LbUsername.Location = new System.Drawing.Point(11, 10);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(98, 21);
            this.LbUsername.TabIndex = 3;
            this.LbUsername.Text = "Username";
            // 
            // LbSignUp
            // 
            this.LbSignUp.AutoSize = true;
            this.LbSignUp.Font = new System.Drawing.Font("Roboto", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSignUp.Location = new System.Drawing.Point(177, 47);
            this.LbSignUp.Name = "LbSignUp";
            this.LbSignUp.Size = new System.Drawing.Size(148, 44);
            this.LbSignUp.TabIndex = 4;
            this.LbSignUp.Text = "Sign Up";
            this.LbSignUp.Click += new System.EventHandler(this.Handler_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignUp.FlatAppearance.BorderSize = 0;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Hack NF", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.White;
            this.BtnSignUp.Location = new System.Drawing.Point(53, 500);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(392, 56);
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            this.BtnSignUp.MouseEnter += new System.EventHandler(this.BtnSignUp_MouseEnter);
            this.BtnSignUp.MouseLeave += new System.EventHandler(this.BtnSignUp_MouseLeave);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 680);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.PnlMainContainer.ResumeLayout(false);
            this.PnlMainContainer.PerformLayout();
            this.PnlUserInput.ResumeLayout(false);
            this.PnlUserInput.PerformLayout();
            this.PnlPhone.ResumeLayout(false);
            this.PnlPhone.PerformLayout();
            this.PnlFullName.ResumeLayout(false);
            this.PnlFullName.PerformLayout();
            this.PnlPassword.ResumeLayout(false);
            this.PnlPassword.PerformLayout();
            this.PnlUsername.ResumeLayout(false);
            this.PnlUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label LbSignUp;
        private System.Windows.Forms.Panel PnlUserInput;
        private System.Windows.Forms.Panel PnlUsername;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Panel PnlPhone;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label LbPhone;
        private System.Windows.Forms.Panel PnlFullName;
        private System.Windows.Forms.TextBox TbFullName;
        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Panel PnlPassword;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Label LbErrorMessage;
        private System.Windows.Forms.CheckBox ChbShow;
    }
}