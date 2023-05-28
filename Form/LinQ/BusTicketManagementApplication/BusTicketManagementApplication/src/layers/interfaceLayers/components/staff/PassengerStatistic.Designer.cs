namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.staff
{
    partial class PassengerStatistic
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PnlMainContainer = new System.Windows.Forms.Panel();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.bookedTicketPassengerDataSet = new BusTicketManagementApplication.src.layers.interfaceLayers.components.staff.reports.BookedTicketPassengerDataSet();
            this.bOOKEDTICKETPASSENGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKEDTICKETPASSENGERTableAdapter = new BusTicketManagementApplication.src.layers.interfaceLayers.components.staff.reports.BookedTicketPassengerDataSetTableAdapters.BOOKEDTICKETPASSENGERTableAdapter();
            this.RVPassengerStatistic = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PnlMainContainer.SuspendLayout();
            this.PnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTicketPassengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKEDTICKETPASSENGERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Controls.Add(this.PnlContent);
            this.PnlMainContainer.Controls.Add(this.PnlControl);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 598);
            this.PnlMainContainer.TabIndex = 0;
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.RVPassengerStatistic);
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 54);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(965, 544);
            this.PnlContent.TabIndex = 1;
            // 
            // PnlControl
            // 
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(965, 54);
            this.PnlControl.TabIndex = 0;
            // 
            // bookedTicketPassengerDataSet
            // 
            this.bookedTicketPassengerDataSet.DataSetName = "BookedTicketPassengerDataSet";
            this.bookedTicketPassengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKEDTICKETPASSENGERBindingSource
            // 
            this.bOOKEDTICKETPASSENGERBindingSource.DataMember = "BOOKEDTICKETPASSENGER";
            this.bOOKEDTICKETPASSENGERBindingSource.DataSource = this.bookedTicketPassengerDataSet;
            // 
            // bOOKEDTICKETPASSENGERTableAdapter
            // 
            this.bOOKEDTICKETPASSENGERTableAdapter.ClearBeforeFill = true;
            // 
            // RVPassengerStatistic
            // 
            this.RVPassengerStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BookedTicketPassengerDataSet";
            reportDataSource1.Value = this.bOOKEDTICKETPASSENGERBindingSource;
            this.RVPassengerStatistic.LocalReport.DataSources.Add(reportDataSource1);
            this.RVPassengerStatistic.LocalReport.ReportEmbeddedResource = "BusTicketManagementApplication.src.layers.interfaceLayers.components.staff.report" +
    "s.BookedTicketPassengerStatistic.rdlc";
            this.RVPassengerStatistic.Location = new System.Drawing.Point(0, 0);
            this.RVPassengerStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.RVPassengerStatistic.Name = "RVPassengerStatistic";
            this.RVPassengerStatistic.ServerReport.BearerToken = null;
            this.RVPassengerStatistic.Size = new System.Drawing.Size(965, 544);
            this.RVPassengerStatistic.TabIndex = 0;
            // 
            // PassengerStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PassengerStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerStatistic";
            this.Load += new System.EventHandler(this.PassengerStatistic_Load);
            this.PnlMainContainer.ResumeLayout(false);
            this.PnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookedTicketPassengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKEDTICKETPASSENGERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Panel PnlControl;
        private reports.BookedTicketPassengerDataSet bookedTicketPassengerDataSet;
        private System.Windows.Forms.BindingSource bOOKEDTICKETPASSENGERBindingSource;
        private reports.BookedTicketPassengerDataSetTableAdapters.BOOKEDTICKETPASSENGERTableAdapter bOOKEDTICKETPASSENGERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer RVPassengerStatistic;
    }
}