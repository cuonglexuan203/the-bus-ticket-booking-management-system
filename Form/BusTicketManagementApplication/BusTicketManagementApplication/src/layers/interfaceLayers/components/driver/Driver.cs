using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketManagementApplication.src.layers.businessLayers;
namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.driver
{
    public partial class Driver : Form
    {
        private string searchInput = string.Empty;
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'busManagementDataSet.PASSENGER' table. You can move, or remove it, as needed.
            //
            LoadMainData();
            LoadDefaultFilterItems();
        }

        private void LoadMainData()
        {
            BSDriver bSDriver = new BSDriver();
            this.DgvMainData.DataSource = bSDriver.GetAllDrivers();
        }
        private void LoadDefaultFilterItems()
        {
            string[] items = "ID,Lisence level".Split(',');
            this.CbField.Items.AddRange(items);
            this.CbField.SelectedIndex = 0;
        }
        private void DgvMainData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedId = DgvMainData?.CurrentRow?.Cells[0].Value.ToString();
            this.LbSelectedId.Text = selectedId;
            //
            string selectedName = DgvMainData?.CurrentRow?.Cells[1].Value.ToString();
            this.LbSelectedName.Text = selectedName;
        }
        private void FilterDrivers()
        {
            BSDriver bSDriver = new BSDriver();
            int tag = this.CbField.SelectedIndex;
            this.DgvMainData.DataSource = bSDriver.SearchDriver(searchInput, tag); // 0: ID, 1: lisence level
        }
        private void BtnSearchIcon_Click(object sender, EventArgs e)
        {
            FilterDrivers();
        }

        private void TbSearch_Leave(object sender, EventArgs e)
        {
            this.searchInput = this.TbSearch.Text.Trim();
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchInput = this.TbSearch.Text;
                FilterDrivers();
            }
        }

        private void CbField_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDrivers();
        }
    }
}
