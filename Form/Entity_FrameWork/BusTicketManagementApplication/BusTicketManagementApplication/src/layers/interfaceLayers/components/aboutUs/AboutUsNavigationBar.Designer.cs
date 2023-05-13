
namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.aboutUs
{
    partial class AboutUsNavigationBar
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
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnBusStation = new System.Windows.Forms.Button();
            this.BtnBusRoute = new System.Windows.Forms.Button();
            this.PnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.BackColor = System.Drawing.Color.Transparent;
            this.PnlMainContainer.Controls.Add(this.btnAboutUs);
            this.PnlMainContainer.Controls.Add(this.btnBusStation);
            this.PnlMainContainer.Controls.Add(this.BtnBusRoute);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 44);
            this.PnlMainContainer.TabIndex = 1;
            this.PnlMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMainContainer_Paint);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Location = new System.Drawing.Point(51, 3);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(144, 30);
            this.btnAboutUs.TabIndex = 2;
            this.btnAboutUs.Tag = "0";
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // btnBusStation
            // 
            this.btnBusStation.FlatAppearance.BorderSize = 0;
            this.btnBusStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusStation.Location = new System.Drawing.Point(270, 3);
            this.btnBusStation.Name = "btnBusStation";
            this.btnBusStation.Size = new System.Drawing.Size(144, 30);
            this.btnBusStation.TabIndex = 1;
            this.btnBusStation.Tag = "1";
            this.btnBusStation.Text = "Bus Station";
            this.btnBusStation.UseVisualStyleBackColor = true;
            this.btnBusStation.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // BtnBusRoute
            // 
            this.BtnBusRoute.FlatAppearance.BorderSize = 0;
            this.BtnBusRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusRoute.Location = new System.Drawing.Point(459, 3);
            this.BtnBusRoute.Name = "BtnBusRoute";
            this.BtnBusRoute.Size = new System.Drawing.Size(144, 30);
            this.BtnBusRoute.TabIndex = 0;
            this.BtnBusRoute.Tag = "2";
            this.BtnBusRoute.Text = "Bus Route";
            this.BtnBusRoute.UseVisualStyleBackColor = true;
            this.BtnBusRoute.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // AboutUsNavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 44);
            this.Controls.Add(this.PnlMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutUsNavigationBar";
            this.Text = "AboutUsNavigationBar";
            this.PnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Button btnBusStation;
        private System.Windows.Forms.Button BtnBusRoute;
        private System.Windows.Forms.Button btnAboutUs;
    }
}