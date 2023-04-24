namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.Profile
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.PnlMainContainer = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.PnlInfor = new System.Windows.Forms.Panel();
            this.PcbAAvatar = new System.Windows.Forms.PictureBox();
            this.LbFullname = new System.Windows.Forms.Label();
            this.TbFullname = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.LbPhone = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbGender = new System.Windows.Forms.Label();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.PnlMainContainer.SuspendLayout();
            this.PnlInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Controls.Add(this.BtnUpdate);
            this.PnlMainContainer.Controls.Add(this.PnlInfor);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 598);
            this.PnlMainContainer.TabIndex = 0;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(397, 460);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(172, 86);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // PnlInfor
            // 
            this.PnlInfor.Controls.Add(this.RbFemale);
            this.PnlInfor.Controls.Add(this.RbMale);
            this.PnlInfor.Controls.Add(this.LbGender);
            this.PnlInfor.Controls.Add(this.TbEmail);
            this.PnlInfor.Controls.Add(this.LbEmail);
            this.PnlInfor.Controls.Add(this.TbPhone);
            this.PnlInfor.Controls.Add(this.LbPhone);
            this.PnlInfor.Controls.Add(this.TbFullname);
            this.PnlInfor.Controls.Add(this.LbFullname);
            this.PnlInfor.Controls.Add(this.PcbAAvatar);
            this.PnlInfor.Location = new System.Drawing.Point(197, 12);
            this.PnlInfor.Name = "PnlInfor";
            this.PnlInfor.Size = new System.Drawing.Size(571, 427);
            this.PnlInfor.TabIndex = 0;
            // 
            // PcbAAvatar
            // 
            this.PcbAAvatar.Image = ((System.Drawing.Image)(resources.GetObject("PcbAAvatar.Image")));
            this.PcbAAvatar.Location = new System.Drawing.Point(218, 14);
            this.PcbAAvatar.Name = "PcbAAvatar";
            this.PcbAAvatar.Size = new System.Drawing.Size(128, 128);
            this.PcbAAvatar.TabIndex = 0;
            this.PcbAAvatar.TabStop = false;
            // 
            // LbFullname
            // 
            this.LbFullname.AutoSize = true;
            this.LbFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbFullname.Location = new System.Drawing.Point(78, 231);
            this.LbFullname.Margin = new System.Windows.Forms.Padding(0);
            this.LbFullname.Name = "LbFullname";
            this.LbFullname.Size = new System.Drawing.Size(109, 21);
            this.LbFullname.TabIndex = 10;
            this.LbFullname.Text = "Full name";
            // 
            // TbFullname
            // 
            this.TbFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbFullname.Enabled = false;
            this.TbFullname.Location = new System.Drawing.Point(200, 231);
            this.TbFullname.Margin = new System.Windows.Forms.Padding(0);
            this.TbFullname.Name = "TbFullname";
            this.TbFullname.Size = new System.Drawing.Size(360, 21);
            this.TbFullname.TabIndex = 11;
            // 
            // TbPhone
            // 
            this.TbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPhone.Enabled = false;
            this.TbPhone.Location = new System.Drawing.Point(200, 280);
            this.TbPhone.Margin = new System.Windows.Forms.Padding(0);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(360, 21);
            this.TbPhone.TabIndex = 13;
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPhone.Location = new System.Drawing.Point(78, 280);
            this.LbPhone.Margin = new System.Windows.Forms.Padding(0);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(65, 21);
            this.LbPhone.TabIndex = 12;
            this.LbPhone.Text = "Phone";
            // 
            // TbEmail
            // 
            this.TbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbEmail.Enabled = false;
            this.TbEmail.Location = new System.Drawing.Point(200, 333);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(360, 21);
            this.TbEmail.TabIndex = 15;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbEmail.Location = new System.Drawing.Point(78, 333);
            this.LbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(65, 21);
            this.LbEmail.TabIndex = 14;
            this.LbEmail.Text = "Email";
            // 
            // LbGender
            // 
            this.LbGender.AutoSize = true;
            this.LbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbGender.Location = new System.Drawing.Point(78, 388);
            this.LbGender.Margin = new System.Windows.Forms.Padding(0);
            this.LbGender.Name = "LbGender";
            this.LbGender.Size = new System.Drawing.Size(76, 21);
            this.LbGender.TabIndex = 18;
            this.LbGender.Text = "Gender";
            // 
            // RbMale
            // 
            this.RbMale.AutoSize = true;
            this.RbMale.Enabled = false;
            this.RbMale.Location = new System.Drawing.Point(200, 388);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(75, 25);
            this.RbMale.TabIndex = 21;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.UseVisualStyleBackColor = true;
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Enabled = false;
            this.RbFemale.Location = new System.Drawing.Point(362, 388);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(97, 25);
            this.RbFemale.TabIndex = 22;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.PnlMainContainer.ResumeLayout(false);
            this.PnlInfor.ResumeLayout(false);
            this.PnlInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Panel PnlInfor;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.PictureBox PcbAAvatar;
        private System.Windows.Forms.Label LbFullname;
        private System.Windows.Forms.TextBox TbFullname;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label LbPhone;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbGender;
        private System.Windows.Forms.RadioButton RbMale;
        private System.Windows.Forms.RadioButton RbFemale;
    }
}