﻿
namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.bus
{
    partial class Bus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bus));
            this.dgvMainData = new System.Windows.Forms.DataGridView();
            this.GbSearchBox = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.BtnSearchIcon = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.PnlApp = new System.Windows.Forms.Panel();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.idbusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRIPsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).BeginInit();
            this.GbSearchBox.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.PnlApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMainData
            // 
            this.dgvMainData.AllowUserToAddRows = false;
            this.dgvMainData.AllowUserToDeleteRows = false;
            this.dgvMainData.AutoGenerateColumns = false;
            this.dgvMainData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbusDataGridViewTextBoxColumn,
            this.registrationnumberDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn,
            this.tRIPsDataGridViewTextBoxColumn});
            this.dgvMainData.DataSource = this.busBindingSource;
            this.dgvMainData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMainData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMainData.Location = new System.Drawing.Point(0, 391);
            this.dgvMainData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMainData.MultiSelect = false;
            this.dgvMainData.Name = "dgvMainData";
            this.dgvMainData.ReadOnly = true;
            this.dgvMainData.RowHeadersVisible = false;
            this.dgvMainData.RowHeadersWidth = 51;
            this.dgvMainData.RowTemplate.Height = 24;
            this.dgvMainData.Size = new System.Drawing.Size(1185, 365);
            this.dgvMainData.TabIndex = 12;
            // 
            // GbSearchBox
            // 
            this.GbSearchBox.Controls.Add(this.lblSearch);
            this.GbSearchBox.Controls.Add(this.cbSearch);
            this.GbSearchBox.Controls.Add(this.BtnSearchIcon);
            this.GbSearchBox.Controls.Add(this.TbSearch);
            this.GbSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbSearchBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSearchBox.Location = new System.Drawing.Point(0, 0);
            this.GbSearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.GbSearchBox.Name = "GbSearchBox";
            this.GbSearchBox.Padding = new System.Windows.Forms.Padding(0);
            this.GbSearchBox.Size = new System.Drawing.Size(1185, 756);
            this.GbSearchBox.TabIndex = 11;
            this.GbSearchBox.TabStop = false;
            this.GbSearchBox.Text = "Search";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(11, 37);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(86, 19);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search by:";
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(126, 33);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(214, 27);
            this.cbSearch.TabIndex = 13;
            this.cbSearch.Tag = "0,1";
            // 
            // BtnSearchIcon
            // 
            this.BtnSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchIcon.FlatAppearance.BorderSize = 0;
            this.BtnSearchIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSearchIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchIcon.Image")));
            this.BtnSearchIcon.Location = new System.Drawing.Point(456, 96);
            this.BtnSearchIcon.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearchIcon.Name = "BtnSearchIcon";
            this.BtnSearchIcon.Size = new System.Drawing.Size(44, 48);
            this.BtnSearchIcon.TabIndex = 1;
            this.BtnSearchIcon.TabStop = false;
            this.BtnSearchIcon.UseVisualStyleBackColor = true;
            this.BtnSearchIcon.Click += new System.EventHandler(this.BtnSearchIcon_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearch.Location = new System.Drawing.Point(126, 111);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(306, 20);
            this.TbSearch.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cbType);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFilter.Location = new System.Drawing.Point(743, 0);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(442, 391);
            this.pnlFilter.TabIndex = 13;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(25, 96);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(214, 27);
            this.cbType.TabIndex = 16;
            this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(20, 30);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(60, 19);
            this.lblFilter.TabIndex = 15;
            this.lblFilter.Text = "Filter:";
            // 
            // PnlApp
            // 
            this.PnlApp.Controls.Add(this.pnlFilter);
            this.PnlApp.Controls.Add(this.dgvMainData);
            this.PnlApp.Controls.Add(this.GbSearchBox);
            this.PnlApp.Controls.Add(this.BtnBooking);
            this.PnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlApp.Location = new System.Drawing.Point(0, 0);
            this.PnlApp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlApp.Name = "PnlApp";
            this.PnlApp.Size = new System.Drawing.Size(1185, 756);
            this.PnlApp.TabIndex = 2;
            // 
            // BtnBooking
            // 
            this.BtnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.BtnBooking.FlatAppearance.BorderSize = 0;
            this.BtnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooking.ForeColor = System.Drawing.Color.White;
            this.BtnBooking.Image = ((System.Drawing.Image)(resources.GetObject("BtnBooking.Image")));
            this.BtnBooking.Location = new System.Drawing.Point(1042, 16);
            this.BtnBooking.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(154, 69);
            this.BtnBooking.TabIndex = 10;
            this.BtnBooking.Text = "Booking";
            this.BtnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBooking.UseVisualStyleBackColor = false;
            // 
            // idbusDataGridViewTextBoxColumn
            // 
            this.idbusDataGridViewTextBoxColumn.DataPropertyName = "id_bus";
            this.idbusDataGridViewTextBoxColumn.HeaderText = "id_bus";
            this.idbusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbusDataGridViewTextBoxColumn.Name = "idbusDataGridViewTextBoxColumn";
            this.idbusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbusDataGridViewTextBoxColumn.Width = 125;
            // 
            // registrationnumberDataGridViewTextBoxColumn
            // 
            this.registrationnumberDataGridViewTextBoxColumn.DataPropertyName = "registration_number";
            this.registrationnumberDataGridViewTextBoxColumn.HeaderText = "registration_number";
            this.registrationnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registrationnumberDataGridViewTextBoxColumn.Name = "registrationnumberDataGridViewTextBoxColumn";
            this.registrationnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "type";
            this.typeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tRIPsDataGridViewTextBoxColumn
            // 
            this.tRIPsDataGridViewTextBoxColumn.DataPropertyName = "TRIPs";
            this.tRIPsDataGridViewTextBoxColumn.HeaderText = "TRIPs";
            this.tRIPsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRIPsDataGridViewTextBoxColumn.Name = "tRIPsDataGridViewTextBoxColumn";
            this.tRIPsDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRIPsDataGridViewTextBoxColumn.Width = 125;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataSource = typeof(BusTicketManagementApplication.src.dbConnection.BUS);
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1185, 756);
            this.ControlBox = false;
            this.Controls.Add(this.PnlApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus";
            this.Load += new System.EventHandler(this.Bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).EndInit();
            this.GbSearchBox.ResumeLayout(false);
            this.GbSearchBox.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.PnlApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainData;
        private System.Windows.Forms.GroupBox GbSearchBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button BtnSearchIcon;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel PnlApp;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.BindingSource busBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPsDataGridViewTextBoxColumn;
    }
}