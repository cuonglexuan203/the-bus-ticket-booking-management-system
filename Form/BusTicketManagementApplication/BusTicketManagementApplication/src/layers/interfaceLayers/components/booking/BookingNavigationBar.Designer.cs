namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.booking
{
    partial class BookingNavigationBar
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
            this.BtnBooked = new System.Windows.Forms.Button();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.PnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.BackColor = System.Drawing.Color.Transparent;
            this.PnlMainContainer.Controls.Add(this.BtnBooked);
            this.PnlMainContainer.Controls.Add(this.BtnBooking);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 44);
            this.PnlMainContainer.TabIndex = 0;
            this.PnlMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMainContainer_Paint);
            // 
            // BtnBooked
            // 
            this.BtnBooked.FlatAppearance.BorderSize = 0;
            this.BtnBooked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooked.Location = new System.Drawing.Point(202, 5);
            this.BtnBooked.Name = "BtnBooked";
            this.BtnBooked.Size = new System.Drawing.Size(144, 30);
            this.BtnBooked.TabIndex = 1;
            this.BtnBooked.Tag = "1";
            this.BtnBooked.Text = "Booked";
            this.BtnBooked.UseVisualStyleBackColor = true;
            this.BtnBooked.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // BtnBooking
            // 
            this.BtnBooking.FlatAppearance.BorderSize = 0;
            this.BtnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooking.Location = new System.Drawing.Point(22, 5);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(144, 30);
            this.BtnBooking.TabIndex = 0;
            this.BtnBooking.Tag = "0";
            this.BtnBooking.Text = "Booking";
            this.BtnBooking.UseVisualStyleBackColor = true;
            this.BtnBooking.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // BookingNavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 44);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingNavigationBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NavigationBar";
            this.PnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.Button BtnBooked;
    }
}