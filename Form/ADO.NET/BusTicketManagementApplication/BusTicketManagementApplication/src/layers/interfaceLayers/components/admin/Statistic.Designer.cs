namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.admin
{
    partial class Statistic
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
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.LbYearFilter = new System.Windows.Forms.Label();
            this.CbYearFilter = new System.Windows.Forms.ComboBox();
            this.RwCashReserveStatistic = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cashReserveStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashReserveStatisticDataSet = new BusTicketManagementApplication.src.layers.interfaceLayers.components.admin.reports.CashReserveStatisticDataSet();
            this.cashReserveStatisticTableAdapter = new BusTicketManagementApplication.src.layers.interfaceLayers.components.admin.reports.CashReserveStatisticDataSetTableAdapters.CashReserveStatisticTableAdapter();
            this.PnlMainContainer.SuspendLayout();
            this.PnlContent.SuspendLayout();
            this.PnlControl.SuspendLayout();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveStatisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveStatisticDataSet)).BeginInit();
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
            this.PnlContent.Controls.Add(this.RwCashReserveStatistic);
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 124);
            this.PnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(965, 474);
            this.PnlContent.TabIndex = 2;
            // 
            // PnlControl
            // 
            this.PnlControl.Controls.Add(this.PnlFilter);
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Margin = new System.Windows.Forms.Padding(0);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(965, 124);
            this.PnlControl.TabIndex = 1;
            // 
            // PnlFilter
            // 
            this.PnlFilter.Controls.Add(this.LbYearFilter);
            this.PnlFilter.Controls.Add(this.CbYearFilter);
            this.PnlFilter.Location = new System.Drawing.Point(573, 37);
            this.PnlFilter.Name = "PnlFilter";
            this.PnlFilter.Size = new System.Drawing.Size(380, 84);
            this.PnlFilter.TabIndex = 9;
            // 
            // LbYearFilter
            // 
            this.LbYearFilter.AutoSize = true;
            this.LbYearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbYearFilter.Location = new System.Drawing.Point(40, 45);
            this.LbYearFilter.Margin = new System.Windows.Forms.Padding(0);
            this.LbYearFilter.Name = "LbYearFilter";
            this.LbYearFilter.Size = new System.Drawing.Size(54, 21);
            this.LbYearFilter.TabIndex = 8;
            this.LbYearFilter.Text = "Year";
            // 
            // CbYearFilter
            // 
            this.CbYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbYearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbYearFilter.FormattingEnabled = true;
            this.CbYearFilter.Location = new System.Drawing.Point(165, 37);
            this.CbYearFilter.Margin = new System.Windows.Forms.Padding(0);
            this.CbYearFilter.MaxDropDownItems = 10;
            this.CbYearFilter.Name = "CbYearFilter";
            this.CbYearFilter.Size = new System.Drawing.Size(175, 29);
            this.CbYearFilter.TabIndex = 5;
            this.CbYearFilter.TabStop = false;
            this.CbYearFilter.TextChanged += new System.EventHandler(this.CbYearFilter_TextChanged);
            // 
            // RwCashReserveStatistic
            // 
            this.RwCashReserveStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CashReserveStatisticDataSet";
            reportDataSource1.Value = this.cashReserveStatisticBindingSource;
            this.RwCashReserveStatistic.LocalReport.DataSources.Add(reportDataSource1);
            this.RwCashReserveStatistic.LocalReport.ReportEmbeddedResource = "BusTicketManagementApplication.src.layers.interfaceLayers.components.admin.report" +
    "s.CashReserveStatisticReport.rdlc";
            this.RwCashReserveStatistic.Location = new System.Drawing.Point(0, 0);
            this.RwCashReserveStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.RwCashReserveStatistic.Name = "RwCashReserveStatistic";
            this.RwCashReserveStatistic.ServerReport.BearerToken = null;
            this.RwCashReserveStatistic.Size = new System.Drawing.Size(965, 474);
            this.RwCashReserveStatistic.TabIndex = 0;
            // 
            // cashReserveStatisticBindingSource
            // 
            this.cashReserveStatisticBindingSource.DataMember = "CashReserveStatistic";
            this.cashReserveStatisticBindingSource.DataSource = this.cashReserveStatisticDataSet;
            // 
            // cashReserveStatisticDataSet
            // 
            this.cashReserveStatisticDataSet.DataSetName = "CashReserveStatisticDataSet";
            this.cashReserveStatisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashReserveStatisticTableAdapter
            // 
            this.cashReserveStatisticTableAdapter.ClearBeforeFill = true;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.PnlMainContainer.ResumeLayout(false);
            this.PnlContent.ResumeLayout(false);
            this.PnlControl.ResumeLayout(false);
            this.PnlFilter.ResumeLayout(false);
            this.PnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveStatisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveStatisticDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.Label LbYearFilter;
        private System.Windows.Forms.ComboBox CbYearFilter;
        private Microsoft.Reporting.WinForms.ReportViewer RwCashReserveStatistic;
        private reports.CashReserveStatisticDataSet cashReserveStatisticDataSet;
        private System.Windows.Forms.BindingSource cashReserveStatisticBindingSource;
        private reports.CashReserveStatisticDataSetTableAdapters.CashReserveStatisticTableAdapter cashReserveStatisticTableAdapter;
    }
}