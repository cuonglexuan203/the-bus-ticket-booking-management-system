namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.home
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.timerLabel = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lbPicture = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.FlpHome = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.FlpHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BusTicketManagementApplication.Properties.Resources.home3;
            this.pictureBox2.Location = new System.Drawing.Point(33, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1205, 354);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnNext.Image = global::BusTicketManagementApplication.Properties.Resources.chevron_right;
            this.btnNext.Location = new System.Drawing.Point(540, 537);
            this.btnNext.Margin = new System.Windows.Forms.Padding(150, 3, 3, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 28);
            this.btnNext.TabIndex = 11;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnPrevious.Image = global::BusTicketManagementApplication.Properties.Resources.chevron_left;
            this.btnPrevious.Location = new System.Drawing.Point(320, 537);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(320, 3, 3, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(67, 28);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pbHome
            // 
            this.FlpHome.SetFlowBreak(this.pbHome, true);
            this.pbHome.Location = new System.Drawing.Point(332, 173);
            this.pbHome.Margin = new System.Windows.Forms.Padding(80, 3, 3, 3);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(359, 358);
            this.pbHome.TabIndex = 9;
            this.pbHome.TabStop = false;
            // 
            // lbPicture
            // 
            this.lbPicture.AutoSize = true;
            this.lbPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPicture.ForeColor = System.Drawing.Color.Crimson;
            this.lbPicture.Location = new System.Drawing.Point(50, 220);
            this.lbPicture.Margin = new System.Windows.Forms.Padding(50, 50, 3, 0);
            this.lbPicture.Name = "lbPicture";
            this.lbPicture.Size = new System.Drawing.Size(199, 24);
            this.lbPicture.TabIndex = 8;
            this.lbPicture.Text = "Some poluar routes:";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpHome.SetFlowBreak(this.lbWelcome, true);
            this.lbWelcome.Location = new System.Drawing.Point(20, 50);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(20, 50, 3, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(1183, 120);
            this.lbWelcome.TabIndex = 2;
            this.lbWelcome.Text = resources.GetString("lbWelcome.Text");
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlpHome
            // 
            this.FlpHome.Controls.Add(this.lbWelcome);
            this.FlpHome.Controls.Add(this.lbPicture);
            this.FlpHome.Controls.Add(this.pbHome);
            this.FlpHome.Controls.Add(this.btnPrevious);
            this.FlpHome.Controls.Add(this.btnNext);
            this.FlpHome.Location = new System.Drawing.Point(19, 372);
            this.FlpHome.Name = "FlpHome";
            this.FlpHome.Size = new System.Drawing.Size(1215, 2705);
            this.FlpHome.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1231, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FlpHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.FlpHome.ResumeLayout(false);
            this.FlpHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerLabel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.FlowLayoutPanel FlpHome;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbPicture;
    }
}