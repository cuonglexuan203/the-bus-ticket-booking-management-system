
namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.driver
{
    partial class Driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver));
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.CbField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbSelectedName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbLisenceLevel = new System.Windows.Forms.Label();
            this.PnlApp = new System.Windows.Forms.Panel();
            this.LbSelectedId = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.GbSearchBox = new System.Windows.Forms.GroupBox();
            this.BtnSearchIcon = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.DgvMainData = new System.Windows.Forms.DataGridView();
            this.employeesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lisenceLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDRIVERINFORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PnlFilter.SuspendLayout();
            this.PnlApp.SuspendLayout();
            this.GbSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDRIVERINFORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFilter
            // 
            this.PnlFilter.Controls.Add(this.CbField);
            this.PnlFilter.Location = new System.Drawing.Point(585, 85);
            this.PnlFilter.Name = "PnlFilter";
            this.PnlFilter.Size = new System.Drawing.Size(262, 76);
            this.PnlFilter.TabIndex = 15;
            // 
            // CbField
            // 
            this.CbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbField.FormattingEnabled = true;
            this.CbField.Location = new System.Drawing.Point(44, 24);
            this.CbField.Margin = new System.Windows.Forms.Padding(0);
            this.CbField.MaxDropDownItems = 10;
            this.CbField.Name = "CbField";
            this.CbField.Size = new System.Drawing.Size(175, 28);
            this.CbField.TabIndex = 6;
            this.CbField.TabStop = false;
            this.CbField.SelectedIndexChanged += new System.EventHandler(this.CbField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(402, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // LbSelectedName
            // 
            this.LbSelectedName.AutoSize = true;
            this.LbSelectedName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSelectedName.Location = new System.Drawing.Point(380, 116);
            this.LbSelectedName.Margin = new System.Windows.Forms.Padding(0);
            this.LbSelectedName.Name = "LbSelectedName";
            this.LbSelectedName.Size = new System.Drawing.Size(0, 20);
            this.LbSelectedName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(482, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 14;
            // 
            // LbLisenceLevel
            // 
            this.LbLisenceLevel.AutoSize = true;
            this.LbLisenceLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbLisenceLevel.Location = new System.Drawing.Point(268, 117);
            this.LbLisenceLevel.Margin = new System.Windows.Forms.Padding(0);
            this.LbLisenceLevel.Name = "LbLisenceLevel";
            this.LbLisenceLevel.Size = new System.Drawing.Size(112, 20);
            this.LbLisenceLevel.TabIndex = 13;
            this.LbLisenceLevel.Text = "Lisence level:";
            // 
            // PnlApp
            // 
            this.PnlApp.Controls.Add(this.PnlFilter);
            this.PnlApp.Controls.Add(this.label1);
            this.PnlApp.Controls.Add(this.LbSelectedName);
            this.PnlApp.Controls.Add(this.label2);
            this.PnlApp.Controls.Add(this.LbLisenceLevel);
            this.PnlApp.Controls.Add(this.LbSelectedId);
            this.PnlApp.Controls.Add(this.LbId);
            this.PnlApp.Controls.Add(this.GbSearchBox);
            this.PnlApp.Controls.Add(this.DgvMainData);
            this.PnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlApp.Location = new System.Drawing.Point(0, 0);
            this.PnlApp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlApp.Name = "PnlApp";
            this.PnlApp.Size = new System.Drawing.Size(1206, 748);
            this.PnlApp.TabIndex = 2;
            // 
            // LbSelectedId
            // 
            this.LbSelectedId.AutoSize = true;
            this.LbSelectedId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSelectedId.Location = new System.Drawing.Point(77, 116);
            this.LbSelectedId.Margin = new System.Windows.Forms.Padding(0);
            this.LbSelectedId.Name = "LbSelectedId";
            this.LbSelectedId.Size = new System.Drawing.Size(0, 20);
            this.LbSelectedId.TabIndex = 12;
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbId.Location = new System.Drawing.Point(34, 116);
            this.LbId.Margin = new System.Windows.Forms.Padding(0);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(31, 20);
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
            this.TbSearch.Size = new System.Drawing.Size(398, 20);
            this.TbSearch.TabIndex = 0;
            this.TbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearch_KeyDown);
            this.TbSearch.Leave += new System.EventHandler(this.TbSearch_Leave);
            // 
            // DgvMainData
            // 
            this.DgvMainData.AllowUserToAddRows = false;
            this.DgvMainData.AllowUserToDeleteRows = false;
            this.DgvMainData.AllowUserToResizeRows = false;
            this.DgvMainData.AutoGenerateColumns = false;
            this.DgvMainData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMainData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMainData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeesIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.lisenceLevelDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.DgvMainData.DataSource = this.vDRIVERINFORBindingSource;
            this.DgvMainData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvMainData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvMainData.Location = new System.Drawing.Point(0, 314);
            this.DgvMainData.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DgvMainData.MultiSelect = false;
            this.DgvMainData.Name = "DgvMainData";
            this.DgvMainData.ReadOnly = true;
            this.DgvMainData.RowHeadersVisible = false;
            this.DgvMainData.RowHeadersWidth = 51;
            this.DgvMainData.RowTemplate.Height = 40;
            this.DgvMainData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMainData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMainData.Size = new System.Drawing.Size(1206, 434);
            this.DgvMainData.TabIndex = 9;
            this.DgvMainData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMainData_CellClick);
            // 
            // employeesIDDataGridViewTextBoxColumn
            // 
            this.employeesIDDataGridViewTextBoxColumn.DataPropertyName = "Employees_ID";
            this.employeesIDDataGridViewTextBoxColumn.HeaderText = "Employees_ID";
            this.employeesIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeesIDDataGridViewTextBoxColumn.Name = "employeesIDDataGridViewTextBoxColumn";
            this.employeesIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lisenceLevelDataGridViewTextBoxColumn
            // 
            this.lisenceLevelDataGridViewTextBoxColumn.DataPropertyName = "Lisence_Level";
            this.lisenceLevelDataGridViewTextBoxColumn.HeaderText = "Lisence_Level";
            this.lisenceLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lisenceLevelDataGridViewTextBoxColumn.Name = "lisenceLevelDataGridViewTextBoxColumn";
            this.lisenceLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDRIVERINFORBindingSource
            // 
            this.vDRIVERINFORBindingSource.DataSource = typeof(BusTicketManagementApplication.src.dbConnection.V_DRIVERINFOR);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 748);
            this.Controls.Add(this.PnlApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Driver";
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            this.PnlFilter.ResumeLayout(false);
            this.PnlApp.ResumeLayout(false);
            this.PnlApp.PerformLayout();
            this.GbSearchBox.ResumeLayout(false);
            this.GbSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDRIVERINFORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.ComboBox CbField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbSelectedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbLisenceLevel;
        private System.Windows.Forms.Panel PnlApp;
        private System.Windows.Forms.Label LbSelectedId;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.GroupBox GbSearchBox;
        private System.Windows.Forms.Button BtnSearchIcon;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.DataGridView DgvMainData;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lisenceLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vDRIVERINFORBindingSource;
    }
}