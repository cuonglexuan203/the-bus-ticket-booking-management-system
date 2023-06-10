namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.admin
{
    partial class AdminNavigationBar
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
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.BtnCashReserve = new System.Windows.Forms.Button();
            this.BtnCashReserveStatistic = new System.Windows.Forms.Button();
            this.PnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.BackColor = System.Drawing.Color.Transparent;
            this.PnlMainContainer.Controls.Add(this.BtnCashReserveStatistic);
            this.PnlMainContainer.Controls.Add(this.BtnEmployee);
            this.PnlMainContainer.Controls.Add(this.BtnCashReserve);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 44);
            this.PnlMainContainer.TabIndex = 2;
            this.PnlMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMainContainer_Paint);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.Location = new System.Drawing.Point(202, 5);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(144, 30);
            this.BtnEmployee.TabIndex = 1;
            this.BtnEmployee.Tag = "1";
            this.BtnEmployee.Text = "Employee";
            this.BtnEmployee.UseVisualStyleBackColor = true;
            this.BtnEmployee.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // BtnCashReserve
            // 
            this.BtnCashReserve.FlatAppearance.BorderSize = 0;
            this.BtnCashReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCashReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCashReserve.Location = new System.Drawing.Point(22, 5);
            this.BtnCashReserve.Name = "BtnCashReserve";
            this.BtnCashReserve.Size = new System.Drawing.Size(144, 30);
            this.BtnCashReserve.TabIndex = 0;
            this.BtnCashReserve.Tag = "0";
            this.BtnCashReserve.Text = "Cash reserve";
            this.BtnCashReserve.UseVisualStyleBackColor = true;
            this.BtnCashReserve.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // BtnCashReserveStatistic
            // 
            this.BtnCashReserveStatistic.FlatAppearance.BorderSize = 0;
            this.BtnCashReserveStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCashReserveStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCashReserveStatistic.Location = new System.Drawing.Point(410, 7);
            this.BtnCashReserveStatistic.Name = "BtnCashReserveStatistic";
            this.BtnCashReserveStatistic.Size = new System.Drawing.Size(144, 30);
            this.BtnCashReserveStatistic.TabIndex = 2;
            this.BtnCashReserveStatistic.Tag = "2";
            this.BtnCashReserveStatistic.Text = "Statistic";
            this.BtnCashReserveStatistic.UseVisualStyleBackColor = true;
            this.BtnCashReserveStatistic.Click += new System.EventHandler(this.Handler_NavBtn_Click);
            // 
            // AdminNavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(965, 44);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminNavigationBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminNavigationBar";
            this.PnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Button BtnEmployee;
        private System.Windows.Forms.Button BtnCashReserve;
        private System.Windows.Forms.Button BtnCashReserveStatistic;
    }
}