namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PnlMainContainer = new System.Windows.Forms.Panel();
            this.LbErrorMessage = new System.Windows.Forms.Label();
            this.LbSignUp = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PnlInput = new System.Windows.Forms.Panel();
            this.ChbShow = new System.Windows.Forms.CheckBox();
            this.PnlPassword = new System.Windows.Forms.Panel();
            this.LbPlaceholderPassword = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.PcbPassword = new System.Windows.Forms.PictureBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbForgetPassword = new System.Windows.Forms.Label();
            this.PnlUsername = new System.Windows.Forms.Panel();
            this.LbPlaceholderUsername = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.PcbUsername = new System.Windows.Forms.PictureBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbLogin = new System.Windows.Forms.Label();
            this.PnlMainContainer.SuspendLayout();
            this.PnlInput.SuspendLayout();
            this.PnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPassword)).BeginInit();
            this.PnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Controls.Add(this.LbErrorMessage);
            this.PnlMainContainer.Controls.Add(this.LbSignUp);
            this.PnlMainContainer.Controls.Add(this.BtnLogin);
            this.PnlMainContainer.Controls.Add(this.PnlInput);
            this.PnlMainContainer.Controls.Add(this.LbLogin);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(503, 680);
            this.PnlMainContainer.TabIndex = 0;
            this.PnlMainContainer.Click += new System.EventHandler(this.Handler_Focus);
            this.PnlMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMainContainer_Paint);
            // 
            // LbErrorMessage
            // 
            this.LbErrorMessage.AutoSize = true;
            this.LbErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LbErrorMessage.Location = new System.Drawing.Point(52, 585);
            this.LbErrorMessage.Name = "LbErrorMessage";
            this.LbErrorMessage.Size = new System.Drawing.Size(0, 21);
            this.LbErrorMessage.TabIndex = 4;
            // 
            // LbSignUp
            // 
            this.LbSignUp.AutoSize = true;
            this.LbSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSignUp.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSignUp.ForeColor = System.Drawing.Color.Blue;
            this.LbSignUp.Location = new System.Drawing.Point(361, 622);
            this.LbSignUp.Name = "LbSignUp";
            this.LbSignUp.Size = new System.Drawing.Size(87, 21);
            this.LbSignUp.TabIndex = 3;
            this.LbSignUp.Text = "Sign Up";
            this.LbSignUp.Click += new System.EventHandler(this.LbSignUp_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Hack NF", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(53, 500);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(392, 56);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // PnlInput
            // 
            this.PnlInput.Controls.Add(this.ChbShow);
            this.PnlInput.Controls.Add(this.PnlPassword);
            this.PnlInput.Controls.Add(this.LbForgetPassword);
            this.PnlInput.Controls.Add(this.PnlUsername);
            this.PnlInput.Location = new System.Drawing.Point(40, 129);
            this.PnlInput.Name = "PnlInput";
            this.PnlInput.Size = new System.Drawing.Size(422, 354);
            this.PnlInput.TabIndex = 1;
            this.PnlInput.Click += new System.EventHandler(this.Handler_Focus);
            // 
            // ChbShow
            // 
            this.ChbShow.AutoSize = true;
            this.ChbShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.ChbShow.Location = new System.Drawing.Point(34, 274);
            this.ChbShow.Name = "ChbShow";
            this.ChbShow.Size = new System.Drawing.Size(175, 25);
            this.ChbShow.TabIndex = 4;
            this.ChbShow.TabStop = false;
            this.ChbShow.Text = "Show password";
            this.ChbShow.UseVisualStyleBackColor = true;
            this.ChbShow.CheckedChanged += new System.EventHandler(this.ChbShow_CheckedChanged);
            // 
            // PnlPassword
            // 
            this.PnlPassword.Controls.Add(this.LbPlaceholderPassword);
            this.PnlPassword.Controls.Add(this.TbPassword);
            this.PnlPassword.Controls.Add(this.PcbPassword);
            this.PnlPassword.Controls.Add(this.LbPassword);
            this.PnlPassword.Location = new System.Drawing.Point(16, 150);
            this.PnlPassword.Name = "PnlPassword";
            this.PnlPassword.Size = new System.Drawing.Size(392, 110);
            this.PnlPassword.TabIndex = 3;
            this.PnlPassword.Click += new System.EventHandler(this.Handler_Focus);
            // 
            // LbPlaceholderPassword
            // 
            this.LbPlaceholderPassword.AutoSize = true;
            this.LbPlaceholderPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LbPlaceholderPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPlaceholderPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(175)))), ((int)(((byte)(173)))));
            this.LbPlaceholderPassword.Location = new System.Drawing.Point(66, 69);
            this.LbPlaceholderPassword.Name = "LbPlaceholderPassword";
            this.LbPlaceholderPassword.Size = new System.Drawing.Size(208, 21);
            this.LbPlaceholderPassword.TabIndex = 4;
            this.LbPlaceholderPassword.Text = "Type your password";
            this.LbPlaceholderPassword.Click += new System.EventHandler(this.Handler_PasswordInput_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPassword.Location = new System.Drawing.Point(56, 69);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(333, 21);
            this.TbPassword.TabIndex = 2;
            this.TbPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TbPassword_PreviewKeyDown);
            // 
            // PcbPassword
            // 
            this.PcbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PcbPassword.Image = ((System.Drawing.Image)(resources.GetObject("PcbPassword.Image")));
            this.PcbPassword.Location = new System.Drawing.Point(18, 62);
            this.PcbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.PcbPassword.Name = "PcbPassword";
            this.PcbPassword.Size = new System.Drawing.Size(32, 32);
            this.PcbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbPassword.TabIndex = 1;
            this.PcbPassword.TabStop = false;
            this.PcbPassword.Click += new System.EventHandler(this.Handler_PasswordInput_Click);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(14, 12);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(98, 21);
            this.LbPassword.TabIndex = 0;
            this.LbPassword.Text = "Password";
            this.LbPassword.Click += new System.EventHandler(this.Handler_Focus);
            // 
            // LbForgetPassword
            // 
            this.LbForgetPassword.AutoSize = true;
            this.LbForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LbForgetPassword.Location = new System.Drawing.Point(222, 315);
            this.LbForgetPassword.Name = "LbForgetPassword";
            this.LbForgetPassword.Size = new System.Drawing.Size(186, 21);
            this.LbForgetPassword.TabIndex = 2;
            this.LbForgetPassword.Text = "Forgot password?";
            // 
            // PnlUsername
            // 
            this.PnlUsername.Controls.Add(this.LbPlaceholderUsername);
            this.PnlUsername.Controls.Add(this.TbUsername);
            this.PnlUsername.Controls.Add(this.PcbUsername);
            this.PnlUsername.Controls.Add(this.LbUsername);
            this.PnlUsername.Location = new System.Drawing.Point(16, 23);
            this.PnlUsername.Name = "PnlUsername";
            this.PnlUsername.Size = new System.Drawing.Size(392, 110);
            this.PnlUsername.TabIndex = 0;
            this.PnlUsername.Click += new System.EventHandler(this.Handler_Focus);
            // 
            // LbPlaceholderUsername
            // 
            this.LbPlaceholderUsername.AutoSize = true;
            this.LbPlaceholderUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LbPlaceholderUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPlaceholderUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(175)))), ((int)(((byte)(173)))));
            this.LbPlaceholderUsername.Location = new System.Drawing.Point(66, 69);
            this.LbPlaceholderUsername.Name = "LbPlaceholderUsername";
            this.LbPlaceholderUsername.Size = new System.Drawing.Size(208, 21);
            this.LbPlaceholderUsername.TabIndex = 3;
            this.LbPlaceholderUsername.Text = "Type your username";
            this.LbPlaceholderUsername.Click += new System.EventHandler(this.Handler_UsernameInput_Click);
            // 
            // TbUsername
            // 
            this.TbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbUsername.Location = new System.Drawing.Point(56, 69);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(333, 21);
            this.TbUsername.TabIndex = 2;
            // 
            // PcbUsername
            // 
            this.PcbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PcbUsername.Image = ((System.Drawing.Image)(resources.GetObject("PcbUsername.Image")));
            this.PcbUsername.Location = new System.Drawing.Point(18, 62);
            this.PcbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.PcbUsername.Name = "PcbUsername";
            this.PcbUsername.Size = new System.Drawing.Size(32, 32);
            this.PcbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbUsername.TabIndex = 1;
            this.PcbUsername.TabStop = false;
            this.PcbUsername.Click += new System.EventHandler(this.Handler_UsernameInput_Click);
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(14, 12);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(98, 21);
            this.LbUsername.TabIndex = 0;
            this.LbUsername.Text = "Username";
            this.LbUsername.Click += new System.EventHandler(this.Handler_Focus);
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Font = new System.Drawing.Font("Roboto", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.Location = new System.Drawing.Point(195, 47);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(112, 44);
            this.LbLogin.TabIndex = 0;
            this.LbLogin.Text = "Login";
            this.LbLogin.Click += new System.EventHandler(this.Handler_Focus);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 680);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PnlMainContainer.ResumeLayout(false);
            this.PnlMainContainer.PerformLayout();
            this.PnlInput.ResumeLayout(false);
            this.PnlInput.PerformLayout();
            this.PnlPassword.ResumeLayout(false);
            this.PnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPassword)).EndInit();
            this.PnlUsername.ResumeLayout(false);
            this.PnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Panel PnlInput;
        private System.Windows.Forms.Panel PnlUsername;
        private System.Windows.Forms.Label LbForgetPassword;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.PictureBox PcbUsername;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Panel PnlPassword;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.PictureBox PcbPassword;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LbPlaceholderUsername;
        private System.Windows.Forms.Label LbPlaceholderPassword;
        private System.Windows.Forms.Label LbSignUp;
        private System.Windows.Forms.Label LbErrorMessage;
        private System.Windows.Forms.CheckBox ChbShow;
    }
}