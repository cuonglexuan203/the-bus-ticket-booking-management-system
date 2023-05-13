
namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.aboutUs
{
    partial class BusStation
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
            this.dgvBusStation = new System.Windows.Forms.DataGridView();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBUSSTATIONINFORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBUSSTATIONINFORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusStation
            // 
            this.dgvBusStation.AllowUserToAddRows = false;
            this.dgvBusStation.AllowUserToDeleteRows = false;
            this.dgvBusStation.AllowUserToResizeRows = false;
            this.dgvBusStation.AutoGenerateColumns = false;
            this.dgvBusStation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBusStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn});
            this.dgvBusStation.DataSource = this.vBUSSTATIONINFORBindingSource;
            this.dgvBusStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBusStation.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBusStation.Location = new System.Drawing.Point(0, 0);
            this.dgvBusStation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBusStation.MultiSelect = false;
            this.dgvBusStation.Name = "dgvBusStation";
            this.dgvBusStation.ReadOnly = true;
            this.dgvBusStation.RowHeadersVisible = false;
            this.dgvBusStation.RowHeadersWidth = 60;
            this.dgvBusStation.RowTemplate.Height = 40;
            this.dgvBusStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusStation.Size = new System.Drawing.Size(800, 450);
            this.dgvBusStation.TabIndex = 0;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vBUSSTATIONINFORBindingSource
            // 
            this.vBUSSTATIONINFORBindingSource.DataSource = typeof(BusTicketManagementApplication.src.dbConnection.V_BUSSTATIONINFOR);
            // 
            // BusStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBusStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusStation";
            this.Text = "BusStation";
            this.Load += new System.EventHandler(this.BusStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBUSSTATIONINFORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusStation;
        private System.Windows.Forms.BindingSource vBUSSTATIONINFORBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
    }
}