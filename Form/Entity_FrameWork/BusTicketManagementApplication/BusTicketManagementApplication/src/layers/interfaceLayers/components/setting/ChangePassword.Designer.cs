namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.setting
{
    partial class ChangePassword
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LbChangePassword = new System.Windows.Forms.Label();
            this.PnlChangePassword = new System.Windows.Forms.Panel();
            this.LbNotifiedMessage = new System.Windows.Forms.Label();
            this.TbRetypeNewPassword = new System.Windows.Forms.TextBox();
            this.LbRetypeNewPassword = new System.Windows.Forms.Label();
            this.TbNewPassword = new System.Windows.Forms.TextBox();
            this.LbNewPassword = new System.Windows.Forms.Label();
            this.TbCurrentPassword = new System.Windows.Forms.TextBox();
            this.LbCurrentPassword = new System.Windows.Forms.Label();
            this.PnlMainContainer.SuspendLayout();
            this.PnlChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Controls.Add(this.BtnCancel);
            this.PnlMainContainer.Controls.Add(this.BtnUpdate);
            this.PnlMainContainer.Controls.Add(this.LbChangePassword);
            this.PnlMainContainer.Controls.Add(this.PnlChangePassword);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 598);
            this.PnlMainContainer.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(521, 469);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(172, 86);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(155)))), ((int)(((byte)(207)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(255, 469);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(172, 86);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Save";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LbChangePassword
            // 
            this.LbChangePassword.AutoSize = true;
            this.LbChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbChangePassword.Font = new System.Drawing.Font("Hack NFM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbChangePassword.Location = new System.Drawing.Point(324, 32);
            this.LbChangePassword.Margin = new System.Windows.Forms.Padding(0);
            this.LbChangePassword.Name = "LbChangePassword";
            this.LbChangePassword.Size = new System.Drawing.Size(317, 39);
            this.LbChangePassword.TabIndex = 13;
            this.LbChangePassword.Text = "Change Password";
            // 
            // PnlChangePassword
            // 
            this.PnlChangePassword.Controls.Add(this.LbNotifiedMessage);
            this.PnlChangePassword.Controls.Add(this.TbRetypeNewPassword);
            this.PnlChangePassword.Controls.Add(this.LbRetypeNewPassword);
            this.PnlChangePassword.Controls.Add(this.TbNewPassword);
            this.PnlChangePassword.Controls.Add(this.LbNewPassword);
            this.PnlChangePassword.Controls.Add(this.TbCurrentPassword);
            this.PnlChangePassword.Controls.Add(this.LbCurrentPassword);
            this.PnlChangePassword.Location = new System.Drawing.Point(183, 123);
            this.PnlChangePassword.Name = "PnlChangePassword";
            this.PnlChangePassword.Size = new System.Drawing.Size(584, 328);
            this.PnlChangePassword.TabIndex = 0;
            // 
            // LbNotifiedMessage
            // 
            this.LbNotifiedMessage.AutoSize = true;
            this.LbNotifiedMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbNotifiedMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LbNotifiedMessage.Location = new System.Drawing.Point(16, 293);
            this.LbNotifiedMessage.Margin = new System.Windows.Forms.Padding(0);
            this.LbNotifiedMessage.Name = "LbNotifiedMessage";
            this.LbNotifiedMessage.Size = new System.Drawing.Size(0, 21);
            this.LbNotifiedMessage.TabIndex = 18;
            // 
            // TbRetypeNewPassword
            // 
            this.TbRetypeNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbRetypeNewPassword.Location = new System.Drawing.Point(235, 243);
            this.TbRetypeNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.TbRetypeNewPassword.Name = "TbRetypeNewPassword";
            this.TbRetypeNewPassword.PasswordChar = '*';
            this.TbRetypeNewPassword.Size = new System.Drawing.Size(330, 21);
            this.TbRetypeNewPassword.TabIndex = 17;
            // 
            // LbRetypeNewPassword
            // 
            this.LbRetypeNewPassword.AutoSize = true;
            this.LbRetypeNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbRetypeNewPassword.Location = new System.Drawing.Point(16, 243);
            this.LbRetypeNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.LbRetypeNewPassword.Name = "LbRetypeNewPassword";
            this.LbRetypeNewPassword.Size = new System.Drawing.Size(219, 21);
            this.LbRetypeNewPassword.TabIndex = 16;
            this.LbRetypeNewPassword.Text = "Retype new password";
            // 
            // TbNewPassword
            // 
            this.TbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbNewPassword.Location = new System.Drawing.Point(235, 149);
            this.TbNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.TbNewPassword.Name = "TbNewPassword";
            this.TbNewPassword.PasswordChar = '*';
            this.TbNewPassword.Size = new System.Drawing.Size(330, 21);
            this.TbNewPassword.TabIndex = 15;
            // 
            // LbNewPassword
            // 
            this.LbNewPassword.AutoSize = true;
            this.LbNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbNewPassword.Location = new System.Drawing.Point(16, 149);
            this.LbNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.LbNewPassword.Name = "LbNewPassword";
            this.LbNewPassword.Size = new System.Drawing.Size(142, 21);
            this.LbNewPassword.TabIndex = 14;
            this.LbNewPassword.Text = "New password";
            // 
            // TbCurrentPassword
            // 
            this.TbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbCurrentPassword.Location = new System.Drawing.Point(239, 50);
            this.TbCurrentPassword.Margin = new System.Windows.Forms.Padding(0);
            this.TbCurrentPassword.Name = "TbCurrentPassword";
            this.TbCurrentPassword.PasswordChar = '*';
            this.TbCurrentPassword.Size = new System.Drawing.Size(330, 21);
            this.TbCurrentPassword.TabIndex = 13;
            // 
            // LbCurrentPassword
            // 
            this.LbCurrentPassword.AutoSize = true;
            this.LbCurrentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbCurrentPassword.Location = new System.Drawing.Point(16, 50);
            this.LbCurrentPassword.Margin = new System.Windows.Forms.Padding(0);
            this.LbCurrentPassword.Name = "LbCurrentPassword";
            this.LbCurrentPassword.Size = new System.Drawing.Size(175, 21);
            this.LbCurrentPassword.TabIndex = 12;
            this.LbCurrentPassword.Text = "Current pasword";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.PnlMainContainer.ResumeLayout(false);
            this.PnlMainContainer.PerformLayout();
            this.PnlChangePassword.ResumeLayout(false);
            this.PnlChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Panel PnlChangePassword;
        private System.Windows.Forms.TextBox TbRetypeNewPassword;
        private System.Windows.Forms.Label LbRetypeNewPassword;
        private System.Windows.Forms.TextBox TbNewPassword;
        private System.Windows.Forms.Label LbNewPassword;
        private System.Windows.Forms.TextBox TbCurrentPassword;
        private System.Windows.Forms.Label LbCurrentPassword;
        private System.Windows.Forms.Label LbChangePassword;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LbNotifiedMessage;
    }
}