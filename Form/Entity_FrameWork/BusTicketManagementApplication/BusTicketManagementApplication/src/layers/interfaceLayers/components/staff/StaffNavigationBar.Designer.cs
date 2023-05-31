namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.staff
{
    partial class StaffNavigationbar
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
            this.BtnAllTrip = new System.Windows.Forms.Button();
            this.BtnPassenger = new System.Windows.Forms.Button();
            this.PnlMainContainer = new System.Windows.Forms.Panel();
            this.BtnPassengerStatistic = new System.Windows.Forms.Button();
            this.PnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAllTrip
            // 
            this.BtnAllTrip.FlatAppearance.BorderSize = 0;
            this.BtnAllTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllTrip.Location = new System.Drawing.Point(202, 5);
            this.BtnAllTrip.Name = "BtnAllTrip";
            this.BtnAllTrip.Size = new System.Drawing.Size(144, 30);
            this.BtnAllTrip.TabIndex = 1;
            this.BtnAllTrip.Tag = "1";
            this.BtnAllTrip.Text = "All Trip";
            this.BtnAllTrip.UseVisualStyleBackColor = true;
            this.BtnAllTrip.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // BtnPassenger
            // 
            this.BtnPassenger.FlatAppearance.BorderSize = 0;
            this.BtnPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPassenger.Location = new System.Drawing.Point(22, 5);
            this.BtnPassenger.Name = "BtnPassenger";
            this.BtnPassenger.Size = new System.Drawing.Size(144, 30);
            this.BtnPassenger.TabIndex = 0;
            this.BtnPassenger.Tag = "0";
            this.BtnPassenger.Text = "Passenger";
            this.BtnPassenger.UseVisualStyleBackColor = true;
            this.BtnPassenger.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.BackColor = System.Drawing.Color.Transparent;
            this.PnlMainContainer.Controls.Add(this.BtnPassengerStatistic);
            this.PnlMainContainer.Controls.Add(this.BtnAllTrip);
            this.PnlMainContainer.Controls.Add(this.BtnPassenger);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 44);
            this.PnlMainContainer.TabIndex = 1;
            this.PnlMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMainContainer_Paint);
            // 
            // BtnPassengerStatistic
            // 
            this.BtnPassengerStatistic.FlatAppearance.BorderSize = 0;
            this.BtnPassengerStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPassengerStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPassengerStatistic.Location = new System.Drawing.Point(410, 7);
            this.BtnPassengerStatistic.Name = "BtnPassengerStatistic";
            this.BtnPassengerStatistic.Size = new System.Drawing.Size(220, 30);
            this.BtnPassengerStatistic.TabIndex = 2;
            this.BtnPassengerStatistic.Tag = "2";
            this.BtnPassengerStatistic.Text = "Passenger Statistic";
            this.BtnPassengerStatistic.UseVisualStyleBackColor = true;
            this.BtnPassengerStatistic.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // StaffNavigationbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(965, 44);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffNavigationbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffNavigationBar";
            this.PnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAllTrip;
        private System.Windows.Forms.Button BtnPassenger;
        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Button BtnPassengerStatistic;
    }
}