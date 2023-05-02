namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.admin
{
    partial class CashReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashReserve));
            this.LbRegion = new System.Windows.Forms.Label();
            this.CbRegion = new System.Windows.Forms.ComboBox();
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.DgvMainData = new System.Windows.Forms.DataGridView();
            this.BtnSearchIcon = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.LbSelectedId = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.GbSearchBox = new System.Windows.Forms.GroupBox();
            this.PnlApp = new System.Windows.Forms.Panel();
            this.LbSumMoney = new System.Windows.Forms.Label();
            this.LbMoney = new System.Windows.Forms.Label();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainData)).BeginInit();
            this.GbSearchBox.SuspendLayout();
            this.PnlApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbRegion
            // 
            this.LbRegion.AutoSize = true;
            this.LbRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbRegion.Location = new System.Drawing.Point(40, 45);
            this.LbRegion.Margin = new System.Windows.Forms.Padding(0);
            this.LbRegion.Name = "LbRegion";
            this.LbRegion.Size = new System.Drawing.Size(76, 21);
            this.LbRegion.TabIndex = 8;
            this.LbRegion.Text = "Region";
            // 
            // CbRegion
            // 
            this.CbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbRegion.FormattingEnabled = true;
            this.CbRegion.Location = new System.Drawing.Point(165, 37);
            this.CbRegion.Margin = new System.Windows.Forms.Padding(0);
            this.CbRegion.MaxDropDownItems = 10;
            this.CbRegion.Name = "CbRegion";
            this.CbRegion.Size = new System.Drawing.Size(175, 29);
            this.CbRegion.TabIndex = 5;
            this.CbRegion.TabStop = false;
            this.CbRegion.TextChanged += new System.EventHandler(this.CbRegion_TextChanged);
            // 
            // PnlFilter
            // 
            this.PnlFilter.Controls.Add(this.LbRegion);
            this.PnlFilter.Controls.Add(this.CbRegion);
            this.PnlFilter.Location = new System.Drawing.Point(492, 71);
            this.PnlFilter.Name = "PnlFilter";
            this.PnlFilter.Size = new System.Drawing.Size(380, 84);
            this.PnlFilter.TabIndex = 8;
            // 
            // DgvMainData
            // 
            this.DgvMainData.AllowUserToAddRows = false;
            this.DgvMainData.AllowUserToDeleteRows = false;
            this.DgvMainData.AllowUserToResizeRows = false;
            this.DgvMainData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.PnlApp.Controls.Add(this.LbSumMoney);
            this.PnlApp.Controls.Add(this.LbMoney);
            this.PnlApp.Controls.Add(this.LbSelectedId);
            this.PnlApp.Controls.Add(this.LbId);
            this.PnlApp.Controls.Add(this.GbSearchBox);
            this.PnlApp.Controls.Add(this.DgvMainData);
            this.PnlApp.Controls.Add(this.PnlFilter);
            this.PnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlApp.Location = new System.Drawing.Point(0, 0);
            this.PnlApp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlApp.Name = "PnlApp";
            this.PnlApp.Size = new System.Drawing.Size(965, 598);
            this.PnlApp.TabIndex = 1;
            // 
            // LbSumMoney
            // 
            this.LbSumMoney.AutoSize = true;
            this.LbSumMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSumMoney.Location = new System.Drawing.Point(696, 31);
            this.LbSumMoney.Margin = new System.Windows.Forms.Padding(0);
            this.LbSumMoney.Name = "LbSumMoney";
            this.LbSumMoney.Size = new System.Drawing.Size(0, 21);
            this.LbSumMoney.TabIndex = 14;
            // 
            // LbMoney
            // 
            this.LbMoney.AutoSize = true;
            this.LbMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbMoney.Location = new System.Drawing.Point(602, 31);
            this.LbMoney.Margin = new System.Windows.Forms.Padding(0);
            this.LbMoney.Name = "LbMoney";
            this.LbMoney.Size = new System.Drawing.Size(76, 21);
            this.LbMoney.TabIndex = 13;
            this.LbMoney.Text = "Money:";
            // 
            // CashReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlApp);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashReserve";
            this.Load += new System.EventHandler(this.CashReserve_Load);
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
        private System.Windows.Forms.Label LbRegion;
        private System.Windows.Forms.ComboBox CbRegion;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.DataGridView DgvMainData;
        private System.Windows.Forms.Button BtnSearchIcon;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Label LbSelectedId;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.GroupBox GbSearchBox;
        private System.Windows.Forms.Panel PnlApp;
        private System.Windows.Forms.Label LbSumMoney;
        private System.Windows.Forms.Label LbMoney;
    }
}