namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.trip
{
    partial class Trip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trip));
            this.PnlApp = new System.Windows.Forms.Panel();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.DgvMainData = new System.Windows.Forms.DataGridView();
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.CbSource = new System.Windows.Forms.ComboBox();
            this.DtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.CbDestination = new System.Windows.Forms.ComboBox();
            this.vTRIPINFORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationnumberofbusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainseatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).BeginInit();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTRIPINFORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlApp
            // 
            this.PnlApp.Controls.Add(this.BtnBooking);
            this.PnlApp.Controls.Add(this.DgvMainData);
            this.PnlApp.Controls.Add(this.PnlFilter);
            this.PnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlApp.Location = new System.Drawing.Point(0, 0);
            this.PnlApp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlApp.Name = "PnlApp";
            this.PnlApp.Size = new System.Drawing.Size(966, 597);
            this.PnlApp.TabIndex = 0;
            // 
            // BtnBooking
            // 
            this.BtnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.BtnBooking.FlatAppearance.BorderSize = 0;
            this.BtnBooking.Font = new System.Drawing.Font("Hack NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooking.ForeColor = System.Drawing.Color.White;
            this.BtnBooking.Image = ((System.Drawing.Image)(resources.GetObject("BtnBooking.Image")));
            this.BtnBooking.Location = new System.Drawing.Point(831, 37);
            this.BtnBooking.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(123, 50);
            this.BtnBooking.TabIndex = 10;
            this.BtnBooking.Text = "Booking";
            this.BtnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBooking.UseVisualStyleBackColor = false;
            // 
            // DgvMainData
            // 
            this.DgvMainData.AllowUserToAddRows = false;
            this.DgvMainData.AllowUserToDeleteRows = false;
            this.DgvMainData.AutoGenerateColumns = false;
            this.DgvMainData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMainData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripIDDataGridViewTextBoxColumn,
            this.registrationnumberofbusDataGridViewTextBoxColumn,
            this.startpointDataGridViewTextBoxColumn,
            this.endpointDataGridViewTextBoxColumn,
            this.departuretimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.remainseatDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.DgvMainData.DataSource = this.vTRIPINFORBindingSource;
            this.DgvMainData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvMainData.Location = new System.Drawing.Point(0, 163);
            this.DgvMainData.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DgvMainData.MultiSelect = false;
            this.DgvMainData.Name = "DgvMainData";
            this.DgvMainData.ReadOnly = true;
            this.DgvMainData.RowHeadersVisible = false;
            this.DgvMainData.RowHeadersWidth = 51;
            this.DgvMainData.RowTemplate.Height = 24;
            this.DgvMainData.Size = new System.Drawing.Size(966, 434);
            this.DgvMainData.TabIndex = 9;
            // 
            // PnlFilter
            // 
            this.PnlFilter.Controls.Add(this.CbSource);
            this.PnlFilter.Controls.Add(this.DtpDepartureTime);
            this.PnlFilter.Controls.Add(this.CbDestination);
            this.PnlFilter.Location = new System.Drawing.Point(373, 88);
            this.PnlFilter.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFilter.Name = "PnlFilter";
            this.PnlFilter.Size = new System.Drawing.Size(584, 58);
            this.PnlFilter.TabIndex = 8;
            // 
            // CbSource
            // 
            this.CbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSource.FormattingEnabled = true;
            this.CbSource.Location = new System.Drawing.Point(10, 14);
            this.CbSource.Margin = new System.Windows.Forms.Padding(0);
            this.CbSource.MaxDropDownItems = 64;
            this.CbSource.Name = "CbSource";
            this.CbSource.Size = new System.Drawing.Size(175, 29);
            this.CbSource.TabIndex = 5;
            this.CbSource.TabStop = false;
            // 
            // DtpDepartureTime
            // 
            this.DtpDepartureTime.CustomFormat = "d/M/yyyy";
            this.DtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDepartureTime.Location = new System.Drawing.Point(384, 16);
            this.DtpDepartureTime.Margin = new System.Windows.Forms.Padding(0);
            this.DtpDepartureTime.Name = "DtpDepartureTime";
            this.DtpDepartureTime.Size = new System.Drawing.Size(192, 28);
            this.DtpDepartureTime.TabIndex = 6;
            this.DtpDepartureTime.TabStop = false;
            // 
            // CbDestination
            // 
            this.CbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDestination.FormattingEnabled = true;
            this.CbDestination.Location = new System.Drawing.Point(197, 14);
            this.CbDestination.Margin = new System.Windows.Forms.Padding(0);
            this.CbDestination.MaxDropDownItems = 64;
            this.CbDestination.Name = "CbDestination";
            this.CbDestination.Size = new System.Drawing.Size(175, 29);
            this.CbDestination.TabIndex = 7;
            this.CbDestination.TabStop = false;
            // 
            // vTRIPINFORBindingSource
            // 
            this.vTRIPINFORBindingSource.DataSource = typeof(BusTicketManagementApplication.src.dbConnection.V_TRIPINFOR);
            // 
            // tripIDDataGridViewTextBoxColumn
            // 
            this.tripIDDataGridViewTextBoxColumn.DataPropertyName = "Trip_ID";
            this.tripIDDataGridViewTextBoxColumn.HeaderText = "Trip_ID";
            this.tripIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tripIDDataGridViewTextBoxColumn.Name = "tripIDDataGridViewTextBoxColumn";
            this.tripIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tripIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // registrationnumberofbusDataGridViewTextBoxColumn
            // 
            this.registrationnumberofbusDataGridViewTextBoxColumn.DataPropertyName = "Registration_number_of_bus";
            this.registrationnumberofbusDataGridViewTextBoxColumn.HeaderText = "Registration_number_of_bus";
            this.registrationnumberofbusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registrationnumberofbusDataGridViewTextBoxColumn.Name = "registrationnumberofbusDataGridViewTextBoxColumn";
            this.registrationnumberofbusDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationnumberofbusDataGridViewTextBoxColumn.Width = 125;
            // 
            // startpointDataGridViewTextBoxColumn
            // 
            this.startpointDataGridViewTextBoxColumn.DataPropertyName = "Start_point";
            this.startpointDataGridViewTextBoxColumn.HeaderText = "Start_point";
            this.startpointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startpointDataGridViewTextBoxColumn.Name = "startpointDataGridViewTextBoxColumn";
            this.startpointDataGridViewTextBoxColumn.ReadOnly = true;
            this.startpointDataGridViewTextBoxColumn.Width = 125;
            // 
            // endpointDataGridViewTextBoxColumn
            // 
            this.endpointDataGridViewTextBoxColumn.DataPropertyName = "End_point";
            this.endpointDataGridViewTextBoxColumn.HeaderText = "End_point";
            this.endpointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endpointDataGridViewTextBoxColumn.Name = "endpointDataGridViewTextBoxColumn";
            this.endpointDataGridViewTextBoxColumn.ReadOnly = true;
            this.endpointDataGridViewTextBoxColumn.Width = 125;
            // 
            // departuretimeDataGridViewTextBoxColumn
            // 
            this.departuretimeDataGridViewTextBoxColumn.DataPropertyName = "Departure_time";
            this.departuretimeDataGridViewTextBoxColumn.HeaderText = "Departure_time";
            this.departuretimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departuretimeDataGridViewTextBoxColumn.Name = "departuretimeDataGridViewTextBoxColumn";
            this.departuretimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.departuretimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // remainseatDataGridViewTextBoxColumn
            // 
            this.remainseatDataGridViewTextBoxColumn.DataPropertyName = "Remain_seat";
            this.remainseatDataGridViewTextBoxColumn.HeaderText = "Remain_seat";
            this.remainseatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remainseatDataGridViewTextBoxColumn.Name = "remainseatDataGridViewTextBoxColumn";
            this.remainseatDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainseatDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(966, 597);
            this.Controls.Add(this.PnlApp);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Trip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip";
            this.PnlApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).EndInit();
            this.PnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vTRIPINFORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlApp;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.ComboBox CbDestination;
        private System.Windows.Forms.DateTimePicker DtpDepartureTime;
        private System.Windows.Forms.ComboBox CbSource;
        private System.Windows.Forms.DataGridView DgvMainData;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedseatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationnumberofbusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainseatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vTRIPINFORBindingSource;
    }
}