namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.staff
{
    partial class BookedTicketPassenger
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
            this.bOOKEDTICKETPASSENGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedTicketPassengerDataSet = new BusTicketManagementApplication.src.layers.interfaceLayers.components.staff.reports.BookedTicketPassengerDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bOOKEDTICKETPASSENGERTableAdapter = new BusTicketManagementApplication.src.layers.interfaceLayers.components.staff.reports.BookedTicketPassengerDataSetTableAdapters.BOOKEDTICKETPASSENGERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKEDTICKETPASSENGERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTicketPassengerDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOOKEDTICKETPASSENGERBindingSource
            // 
            this.bOOKEDTICKETPASSENGERBindingSource.DataMember = "BOOKEDTICKETPASSENGER";
            this.bOOKEDTICKETPASSENGERBindingSource.DataSource = this.bookedTicketPassengerDataSet;
            // 
            // bookedTicketPassengerDataSet
            // 
            this.bookedTicketPassengerDataSet.DataSetName = "BookedTicketPassengerDataSet";
            this.bookedTicketPassengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 598);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 498);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BookedTicketPassengerDataSet";
            reportDataSource1.Value = this.bOOKEDTICKETPASSENGERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BusTicketManagementApplication.src.layers.interfaceLayers.components.staff.report" +
    "s.BookedTicketPassengerStatistic.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(965, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(965, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bOOKEDTICKETPASSENGERTableAdapter
            // 
            this.bOOKEDTICKETPASSENGERTableAdapter.ClearBeforeFill = true;
            // 
            // BookedTicketPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookedTicketPassenger";
            this.Text = "BookedTicketPassenger";
            this.Load += new System.EventHandler(this.BookedTicketPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKEDTICKETPASSENGERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTicketPassengerDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private reports.BookedTicketPassengerDataSet bookedTicketPassengerDataSet;
        private System.Windows.Forms.BindingSource bOOKEDTICKETPASSENGERBindingSource;
        private reports.BookedTicketPassengerDataSetTableAdapters.BOOKEDTICKETPASSENGERTableAdapter bOOKEDTICKETPASSENGERTableAdapter;
    }
}