namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.staff
{
    partial class Passenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger));
            this.BtnSearchIcon = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.LbSelectedId = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.GbSearchBox = new System.Windows.Forms.GroupBox();
            this.PnlApp = new System.Windows.Forms.Panel();
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.CbField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbSelectedName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.DgvMainData = new System.Windows.Forms.DataGridView();
            this.idpassengerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identitynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSENGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busManagementDataSet = new BusTicketManagementApplication.BusManagementDataSet();
            this.pASSENGERTableAdapter = new BusTicketManagementApplication.BusManagementDataSetTableAdapters.PASSENGERTableAdapter();
            this.GbSearchBox.SuspendLayout();
            this.PnlApp.SuspendLayout();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSENGERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busManagementDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.LbSelectedId.Size = new System.Drawing.Size(0, 22);
            this.LbSelectedId.TabIndex = 12;
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbId.Location = new System.Drawing.Point(34, 116);
            this.LbId.Margin = new System.Windows.Forms.Padding(0);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(32, 22);
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
            this.PnlApp.Controls.Add(this.PnlFilter);
            this.PnlApp.Controls.Add(this.label1);
            this.PnlApp.Controls.Add(this.LbSelectedName);
            this.PnlApp.Controls.Add(this.label2);
            this.PnlApp.Controls.Add(this.LbName);
            this.PnlApp.Controls.Add(this.LbSelectedId);
            this.PnlApp.Controls.Add(this.LbId);
            this.PnlApp.Controls.Add(this.GbSearchBox);
            this.PnlApp.Controls.Add(this.DgvMainData);
            this.PnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlApp.Location = new System.Drawing.Point(0, 0);
            this.PnlApp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlApp.Name = "PnlApp";
            this.PnlApp.Size = new System.Drawing.Size(965, 598);
            this.PnlApp.TabIndex = 1;
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
            this.CbField.Size = new System.Drawing.Size(175, 30);
            this.CbField.TabIndex = 6;
            this.CbField.TabStop = false;
            this.CbField.SelectedIndexChanged += new System.EventHandler(this.CbField_SelectedIndexChanged);
            this.CbField.TextChanged += new System.EventHandler(this.CbField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(402, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 14;
            // 
            // LbSelectedName
            // 
            this.LbSelectedName.AutoSize = true;
            this.LbSelectedName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSelectedName.Location = new System.Drawing.Point(380, 116);
            this.LbSelectedName.Margin = new System.Windows.Forms.Padding(0);
            this.LbSelectedName.Name = "LbSelectedName";
            this.LbSelectedName.Size = new System.Drawing.Size(0, 22);
            this.LbSelectedName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(482, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 14;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbName.Location = new System.Drawing.Point(315, 116);
            this.LbName.Margin = new System.Windows.Forms.Padding(0);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(62, 22);
            this.LbName.TabIndex = 13;
            this.LbName.Text = "Name:";
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
            this.idpassengerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.identitynumberDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DgvMainData.DataSource = this.pASSENGERBindingSource;
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
            // idpassengerDataGridViewTextBoxColumn
            // 
            this.idpassengerDataGridViewTextBoxColumn.DataPropertyName = "id_passenger";
            this.idpassengerDataGridViewTextBoxColumn.HeaderText = "id_passenger";
            this.idpassengerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpassengerDataGridViewTextBoxColumn.Name = "idpassengerDataGridViewTextBoxColumn";
            this.idpassengerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identitynumberDataGridViewTextBoxColumn
            // 
            this.identitynumberDataGridViewTextBoxColumn.DataPropertyName = "identity_number";
            this.identitynumberDataGridViewTextBoxColumn.HeaderText = "identity_number";
            this.identitynumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identitynumberDataGridViewTextBoxColumn.Name = "identitynumberDataGridViewTextBoxColumn";
            this.identitynumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "gender";
            this.genderDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            this.genderDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pASSENGERBindingSource
            // 
            this.pASSENGERBindingSource.DataMember = "PASSENGER";
            this.pASSENGERBindingSource.DataSource = this.busManagementDataSet;
            // 
            // busManagementDataSet
            // 
            this.busManagementDataSet.DataSetName = "BusManagementDataSet";
            this.busManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pASSENGERTableAdapter
            // 
            this.pASSENGERTableAdapter.ClearBeforeFill = true;
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Passenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger";
            this.Load += new System.EventHandler(this.Passenger_Load);
            this.GbSearchBox.ResumeLayout(false);
            this.GbSearchBox.PerformLayout();
            this.PnlApp.ResumeLayout(false);
            this.PnlApp.PerformLayout();
            this.PnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSENGERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSearchIcon;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Label LbSelectedId;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.GroupBox GbSearchBox;
        private System.Windows.Forms.Panel PnlApp;
        private System.Windows.Forms.DataGridView DgvMainData;
        private BusManagementDataSet busManagementDataSet;
        private System.Windows.Forms.BindingSource pASSENGERBindingSource;
        private BusManagementDataSetTableAdapters.PASSENGERTableAdapter pASSENGERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpassengerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identitynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbSelectedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.ComboBox CbField;
    }
}