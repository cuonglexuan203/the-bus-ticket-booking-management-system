using BusTicketManagementApplication.src.layers.businessLayers;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.staff
{
    public partial class Passenger : Form
    {
        private string searchInput = string.Empty;
        public Passenger()
        {
            InitializeComponent();
        }

        private void Passenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'busManagementDataSet.PASSENGER' table. You can move, or remove it, as needed.
            this.pASSENGERTableAdapter.Fill(this.busManagementDataSet.PASSENGER);
            //
            LoadDefaultFilterItems();
        }
        private void LoadDefaultFilterItems()
        {
            string[] items = "ID Name".Split(' ');
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
        private void FilterPassengers()
        {
            BSPassenger bsbooked = new BSPassenger();
            int tag = this.CbField.SelectedIndex; 
            this.DgvMainData.DataSource = bsbooked.SearchPassenger(searchInput, tag); // 0: ID, 1: Name
        }
        private void BtnSearchIcon_Click(object sender, EventArgs e)
        {
            FilterPassengers();
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
                FilterPassengers();
            }
        }

        private void CbField_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPassengers();
        }
    }
}
