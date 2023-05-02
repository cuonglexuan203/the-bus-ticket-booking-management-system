
namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.aboutUs
{
    partial class BusRoute
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
            this.dgvBusRoute = new System.Windows.Forms.DataGridView();
            this.startpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusRoutebindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusRoutebindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusRoute
            // 
            this.dgvBusRoute.AllowUserToAddRows = false;
            this.dgvBusRoute.AllowUserToDeleteRows = false;
            this.dgvBusRoute.AllowUserToResizeRows = false;
            this.dgvBusRoute.AutoGenerateColumns = false;
            this.dgvBusRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusRoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBusRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startpointDataGridViewTextBoxColumn,
            this.endpointDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn});
            this.dgvBusRoute.DataSource = this.BusRoutebindingSource;
            this.dgvBusRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBusRoute.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBusRoute.Location = new System.Drawing.Point(0, 0);
            this.dgvBusRoute.MultiSelect = false;
            this.dgvBusRoute.Name = "dgvBusRoute";
            this.dgvBusRoute.ReadOnly = true;
            this.dgvBusRoute.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBusRoute.RowHeadersVisible = false;
            this.dgvBusRoute.RowHeadersWidth = 60;
            this.dgvBusRoute.RowTemplate.Height = 40;
            this.dgvBusRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusRoute.Size = new System.Drawing.Size(800, 450);
            this.dgvBusRoute.TabIndex = 0;
            // 
            // startpointDataGridViewTextBoxColumn
            // 
            this.startpointDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startpointDataGridViewTextBoxColumn.DataPropertyName = "Start_point";
            this.startpointDataGridViewTextBoxColumn.HeaderText = "Start_point";
            this.startpointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startpointDataGridViewTextBoxColumn.Name = "startpointDataGridViewTextBoxColumn";
            this.startpointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endpointDataGridViewTextBoxColumn
            // 
            this.endpointDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endpointDataGridViewTextBoxColumn.DataPropertyName = "End_point";
            this.endpointDataGridViewTextBoxColumn.HeaderText = "End_point";
            this.endpointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endpointDataGridViewTextBoxColumn.Name = "endpointDataGridViewTextBoxColumn";
            this.endpointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BusRoutebindingSource
            // 
            this.BusRoutebindingSource.DataSource = typeof(BusTicketManagementApplication.src.dbConnection.V_ROUTEINFOR);
            // 
            // BusRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBusRoute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusRoute";
            this.Text = "BusRoute";
            this.Load += new System.EventHandler(this.BusRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusRoutebindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusRoute;
        private System.Windows.Forms.BindingSource BusRoutebindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn startpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
    }
}