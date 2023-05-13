namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.booking
{
    partial class Booked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booked));
            this.PnlMainContainer = new System.Windows.Forms.Panel();
            this.LbDepartureTime = new System.Windows.Forms.Label();
            this.LbDestination = new System.Windows.Forms.Label();
            this.LbSource = new System.Windows.Forms.Label();
            this.CbSource = new System.Windows.Forms.ComboBox();
            this.CbDestination = new System.Windows.Forms.ComboBox();
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.DtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DgvMainData = new System.Windows.Forms.DataGridView();
            this.BtnSearchIcon = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.LbSelectedId = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.GbSearchBox = new System.Windows.Forms.GroupBox();
            this.PnlApp = new System.Windows.Forms.Panel();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).BeginInit();
            this.GbSearchBox.SuspendLayout();
            this.PnlApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 598);
            this.PnlMainContainer.TabIndex = 0;
            // 
            // LbDepartureTime
            // 
            this.LbDepartureTime.AutoSize = true;
            this.LbDepartureTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbDepartureTime.Location = new System.Drawing.Point(379, 13);
            this.LbDepartureTime.Margin = new System.Windows.Forms.Padding(0);
            this.LbDepartureTime.Name = "LbDepartureTime";
            this.LbDepartureTime.Size = new System.Drawing.Size(164, 21);
            this.LbDepartureTime.TabIndex = 10;
            this.LbDepartureTime.Text = "Departure time";
            // 
            // LbDestination
            // 
            this.LbDestination.AutoSize = true;
            this.LbDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbDestination.Location = new System.Drawing.Point(192, 13);
            this.LbDestination.Margin = new System.Windows.Forms.Padding(0);
            this.LbDestination.Name = "LbDestination";
            this.LbDestination.Size = new System.Drawing.Size(32, 21);
            this.LbDestination.TabIndex = 9;
            this.LbDestination.Text = "To";
            // 
            // LbSource
            // 
            this.LbSource.AutoSize = true;
            this.LbSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSource.Location = new System.Drawing.Point(5, 13);
            this.LbSource.Margin = new System.Windows.Forms.Padding(0);
            this.LbSource.Name = "LbSource";
            this.LbSource.Size = new System.Drawing.Size(54, 21);
            this.LbSource.TabIndex = 8;
            this.LbSource.Text = "From";
            // 
            // CbSource
            // 
            this.CbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSource.FormattingEnabled = true;
            this.CbSource.Location = new System.Drawing.Point(9, 45);
            this.CbSource.Margin = new System.Windows.Forms.Padding(0);
            this.CbSource.MaxDropDownItems = 10;
            this.CbSource.Name = "CbSource";
            this.CbSource.Size = new System.Drawing.Size(175, 29);
            this.CbSource.TabIndex = 5;
            this.CbSource.TabStop = false;
            this.CbSource.TextChanged += new System.EventHandler(this.CbSource_TextChanged);
            // 
            // CbDestination
            // 
            this.CbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDestination.FormattingEnabled = true;
            this.CbDestination.Location = new System.Drawing.Point(196, 45);
            this.CbDestination.Margin = new System.Windows.Forms.Padding(0);
            this.CbDestination.MaxDropDownItems = 10;
            this.CbDestination.Name = "CbDestination";
            this.CbDestination.Size = new System.Drawing.Size(175, 29);
            this.CbDestination.TabIndex = 7;
            this.CbDestination.TabStop = false;
            this.CbDestination.TextChanged += new System.EventHandler(this.CbDestination_TextChanged);
            // 
            // PnlFilter
            // 
            this.PnlFilter.Controls.Add(this.LbDepartureTime);
            this.PnlFilter.Controls.Add(this.LbDestination);
            this.PnlFilter.Controls.Add(this.LbSource);
            this.PnlFilter.Controls.Add(this.CbSource);
            this.PnlFilter.Controls.Add(this.DtpDepartureTime);
            this.PnlFilter.Controls.Add(this.CbDestination);
            this.PnlFilter.Location = new System.Drawing.Point(377, 71);
            this.PnlFilter.Name = "PnlFilter";
            this.PnlFilter.Size = new System.Drawing.Size(580, 84);
            this.PnlFilter.TabIndex = 8;
            // 
            // DtpDepartureTime
            // 
            this.DtpDepartureTime.CustomFormat = "d/M/yyyy";
            this.DtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDepartureTime.Location = new System.Drawing.Point(383, 47);
            this.DtpDepartureTime.Margin = new System.Windows.Forms.Padding(0);
            this.DtpDepartureTime.Name = "DtpDepartureTime";
            this.DtpDepartureTime.Size = new System.Drawing.Size(192, 28);
            this.DtpDepartureTime.TabIndex = 6;
            this.DtpDepartureTime.TabStop = false;
            this.DtpDepartureTime.ValueChanged += new System.EventHandler(this.DtpDepartureTime_ValueChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Hack NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(834, 12);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(123, 50);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DgvMainData
            // 
            this.DgvMainData.AllowUserToAddRows = false;
            this.DgvMainData.AllowUserToDeleteRows = false;
            this.DgvMainData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMainData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvMainData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvMainData.Location = new System.Drawing.Point(0, 164);
            this.DgvMainData.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DgvMainData.MultiSelect = false;
            this.DgvMainData.Name = "DgvMainData";
            this.DgvMainData.ReadOnly = true;
            this.DgvMainData.RowHeadersVisible = false;
            this.DgvMainData.RowHeadersWidth = 51;
            this.DgvMainData.RowTemplate.Height = 40;
            this.DgvMainData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMainData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMainData.Size = new System.Drawing.Size(965, 434);
            this.DgvMainData.TabIndex = 9;
            this.DgvMainData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMainData_CellClick);
            // 
            // BtnSearchIcon
            // 
            this.BtnSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchIcon.FlatAppearance.BorderSize = 0;
            this.BtnSearchIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSearchIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchIcon.Image")));
            this.BtnSearchIcon.Location = new System.Drawing.Point(421, 21);
            this.BtnSearchIcon.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearchIcon.Name = "BtnSearchIcon";
            this.BtnSearchIcon.Size = new System.Drawing.Size(35, 35);
            this.BtnSearchIcon.TabIndex = 1;
            this.BtnSearchIcon.TabStop = false;
            this.BtnSearchIcon.UseVisualStyleBackColor = false;
            this.BtnSearchIcon.Click += new System.EventHandler(this.BtnSearchIcon_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbSearch.Location = new System.Drawing.Point(13, 28);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(398, 21);
            this.TbSearch.TabIndex = 0;
            this.TbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearch_KeyDown);
            this.TbSearch.Leave += new System.EventHandler(this.TbSearch_Leave);
            // 
            // LbSelectedId
            // 
            this.LbSelectedId.AutoSize = true;
            this.LbSelectedId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSelectedId.Location = new System.Drawing.Point(77, 116);
            this.LbSelectedId.Margin = new System.Windows.Forms.Padding(0);
            this.LbSelectedId.Name = "LbSelectedId";
            this.LbSelectedId.Size = new System.Drawing.Size(0, 21);
            this.LbSelectedId.TabIndex = 12;
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbId.Location = new System.Drawing.Point(34, 116);
            this.LbId.Margin = new System.Windows.Forms.Padding(0);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(43, 21);
            this.LbId.TabIndex = 9;
            this.LbId.Text = "ID:";
            // 
            // GbSearchBox
            // 
            this.GbSearchBox.Controls.Add(this.BtnSearchIcon);
            this.GbSearchBox.Controls.Add(this.TbSearch);
            this.GbSearchBox.Location = new System.Drawing.Point(25, 3);
            this.GbSearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.GbSearchBox.Name = "GbSearchBox";
            this.GbSearchBox.Padding = new System.Windows.Forms.Padding(0);
            this.GbSearchBox.Size = new System.Drawing.Size(496, 62);
            this.GbSearchBox.TabIndex = 11;
            this.GbSearchBox.TabStop = false;
            this.GbSearchBox.Text = "Search";
            // 
            // PnlApp
            // 
            this.PnlApp.Controls.Add(this.LbSelectedId);
            this.PnlApp.Controls.Add(this.LbId);
            this.PnlApp.Controls.Add(this.GbSearchBox);
            this.PnlApp.Controls.Add(this.BtnCancel);
            this.PnlApp.Controls.Add(this.DgvMainData);
            this.PnlApp.Controls.Add(this.PnlFilter);
            this.PnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlApp.Location = new System.Drawing.Point(0, 0);
            this.PnlApp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlApp.Name = "PnlApp";
            this.PnlApp.Size = new System.Drawing.Size(965, 598);
            this.PnlApp.TabIndex = 1;
            // 
            // Booked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlApp);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booked";
            this.Load += new System.EventHandler(this.Booked_Load);
            this.PnlFilter.ResumeLayout(false);
            this.PnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).EndInit();
            this.GbSearchBox.ResumeLayout(false);
            this.GbSearchBox.PerformLayout();
            this.PnlApp.ResumeLayout(false);
            this.PnlApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.Label LbDepartureTime;
        private System.Windows.Forms.Label LbDestination;
        private System.Windows.Forms.Label LbSource;
        private System.Windows.Forms.ComboBox CbSource;
        private System.Windows.Forms.ComboBox CbDestination;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.DateTimePicker DtpDepartureTime;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridView DgvMainData;
        private System.Windows.Forms.Button BtnSearchIcon;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Label LbSelectedId;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.GroupBox GbSearchBox;
        private System.Windows.Forms.Panel PnlApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberOfBusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}