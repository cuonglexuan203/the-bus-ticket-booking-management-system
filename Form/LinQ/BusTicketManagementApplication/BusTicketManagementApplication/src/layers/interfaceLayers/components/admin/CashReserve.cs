using BusTicketManagementApplication.src.dbConnection;
using BusTicketManagementApplication.src.layers.businessLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.admin
{
    public partial class CashReserve : Form
    {
        private string searchInput = string.Empty;

        public CashReserve()
        {
            InitializeComponent();
        }

        private void CashReserve_Load(object sender, EventArgs e)
        {
            LoadDefaultPlaces();
        }
        private void LoadDefaultPlaces()
        {
            var defaultPlace = new BSPlace().GetPlaceNames().ToArray();
            this.CbRegion.Items.Add("All");
            this.CbRegion.Items.AddRange(defaultPlace);
            this.CbRegion.SelectedIndex = 0;
        }
        private void FilterAgent()
        {
            BSAgent bsagent = new BSAgent();
            List<V_AGENTINFOR> dataSource = bsagent.SearchAgents(this.searchInput.Trim(), this.CbRegion.Text.Trim());
            this.DgvMainData.DataSource = dataSource;
            this.LbSumMoney.Text = dataSource?.Aggregate(0m, (s, d) => s + (decimal)d.Money).ToString("###,###,###,###");
        }
        private void TbSearch_Leave(object sender, EventArgs e)
        {
            this.searchInput = this.TbSearch.Text.Trim();
        }

        private void DgvMainData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LbSelectedId.Text = DgvMainData.CurrentRow?.Cells[0]?.Value.ToString().Trim();
        }

        private void BtnSearchIcon_Click(object sender, EventArgs e)
        {
            FilterAgent();
        }

        private void CbRegion_TextChanged(object sender, EventArgs e)
        {
            FilterAgent();
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchInput = this.TbSearch.Text;
                FilterAgent();
            }
        }
    }
}
