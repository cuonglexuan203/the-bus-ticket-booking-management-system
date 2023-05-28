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
            this.RwCashReverseStatistic = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cashReserveStatisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashReserveDataSet = new BusTicketManagementApplication.src.layers.interfaceLayers.components.admin.reports.CashReserveDataSet();
            this.cashReserveStatisticsTableAdapter = new BusTicketManagementApplication.src.layers.interfaceLayers.components.admin.reports.CashReserveDataSetTableAdapters.CashReserveStatisticsTableAdapter();
            this.PnlMainContainer.SuspendLayout();
            this.PnlContent.SuspendLayout();
            this.PnlControl.SuspendLayout();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveStatisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Controls.Add(this.PnlContent);
            this.PnlMainContainer.Controls.Add(this.PnlControl);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 598);
            this.PnlMainContainer.TabIndex = 0;
            this.PnlMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.RwCashReverseStatistic);
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 125);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(965, 473);
            this.PnlContent.TabIndex = 1;
            // 
            // PnlControl
            // 
            this.PnlControl.Controls.Add(this.PnlFilter);
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(965, 125);
            this.PnlControl.TabIndex = 0;
            this.PnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // PnlFilter
            // 
            this.PnlFilter.Controls.Add(this.LbYearFilter);
            this.PnlFilter.Controls.Add(this.CbYearFilter);
            this.PnlFilter.Location = new System.Drawing.Point(573, 41);
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
            this.LbYearFilter.Size = new System.Drawing.Size(42, 20);
            this.LbYearFilter.TabIndex = 8;
            this.LbYearFilter.Text = "Year";
            // 
            // CbYearFilter
            // 
            this.CbYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbYearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbYearFilter.FormattingEnabled = true;
            this.CbYearFilter.Location = new System.Drawing.Point(184, 37);
            this.CbYearFilter.Margin = new System.Windows.Forms.Padding(0);
            this.CbYearFilter.MaxDropDownItems = 10;
            this.CbYearFilter.Name = "CbYearFilter";
            this.CbYearFilter.Size = new System.Drawing.Size(175, 28);
            this.CbYearFilter.TabIndex = 5;
            this.CbYearFilter.TabStop = false;
            this.CbYearFilter.TextChanged += new System.EventHandler(this.CbYearFilter_TextChanged);
            // 
            // RwCashReverseStatistic
            // 
            this.RwCashReverseStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CashReserveStatisticDataSet";
            reportDataSource1.Value = this.cashReserveStatisticsBindingSource;
            this.RwCashReverseStatistic.LocalReport.DataSources.Add(reportDataSource1);
            this.RwCashReverseStatistic.LocalReport.ReportEmbeddedResource = "BusTicketManagementApplication.src.layers.interfaceLayers.components.admin.report" +
    "s.CashReserveStatistic.rdlc";
            this.RwCashReverseStatistic.Location = new System.Drawing.Point(0, 0);
            this.RwCashReverseStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.RwCashReverseStatistic.Name = "RwCashReverseStatistic";
            this.RwCashReverseStatistic.ServerReport.BearerToken = null;
            this.RwCashReverseStatistic.Size = new System.Drawing.Size(965, 473);
            this.RwCashReverseStatistic.TabIndex = 0;
            // 
            // cashReserveStatisticsBindingSource
            // 
            this.cashReserveStatisticsBindingSource.DataMember = "CashReserveStatistics";
            this.cashReserveStatisticsBindingSource.DataSource = this.cashReserveDataSet;
            // 
            // cashReserveDataSet
            // 
            this.cashReserveDataSet.DataSetName = "CashReserveDataSet";
            this.cashReserveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashReserveStatisticsTableAdapter
            // 
            this.cashReserveStatisticsTableAdapter.ClearBeforeFill = true;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveStatisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashReserveDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.Label LbYearFilter;
        private System.Windows.Forms.ComboBox CbYearFilter;
        private Microsoft.Reporting.WinForms.ReportViewer RwCashReverseStatistic;
        private reports.CashReserveDataSet cashReserveDataSet;
        private System.Windows.Forms.BindingSource cashReserveStatisticsBindingSource;
        private reports.CashReserveDataSetTableAdapters.CashReserveStatisticsTableAdapter cashReserveStatisticsTableAdapter;
    }
}