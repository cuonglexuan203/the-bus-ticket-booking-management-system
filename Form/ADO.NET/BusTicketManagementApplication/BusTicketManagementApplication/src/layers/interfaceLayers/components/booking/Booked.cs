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

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.booking
{
    public partial class Booked : Form
    {
        //
        private string searchInput = string.Empty;
        private string source = string.Empty;
        private string destination = string.Empty;
        private DateTime departureTime;
        // load data
        public Booked()
        {
            InitializeComponent();
        }
        private void Booked_Load(object sender, EventArgs e)
        {
            LoadDefaultPlace();
        }
        // common functions
        private void LoadDefaultPlace()
        {
            var defaultPlace = new BSPlace().GetPlaceNames().ToArray();
            this.CbSource.Items.Add("All");
            this.CbSource.Items.AddRange(defaultPlace);
            this.CbSource.SelectedIndex = 0;
            //
            this.CbDestination.Items.Add("All");
            this.CbDestination.Items.AddRange(defaultPlace);
            this.CbDestination.SelectedIndex = 0;

        }
        private void FilterBookedTickets()
        {
            BSBooked bsbooked = new BSBooked();
            this.DgvMainData.DataSource = bsbooked.SearchBookedTickets(UserData.GetPassengerId(),searchInput, source, destination, departureTime);
        }

        //
        private void TbSearch_Leave(object sender, EventArgs e)
        {
            this.searchInput = TbSearch.Text;
        }



        private void DtpDepartureTime_ValueChanged(object sender, EventArgs e)
        {
            this.departureTime = DtpDepartureTime.Value;
            //
            FilterBookedTickets();
        }

        private void BtnSearchIcon_Click(object sender, EventArgs e)
        {
            FilterBookedTickets();
        }


        private void DgvMainData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedId = DgvMainData?.CurrentRow?.Cells[0].Value.ToString();
            this.LbSelectedId.Text = selectedId;
        }


        private void CbSource_TextChanged(object sender, EventArgs e)
        {
            this.source = CbSource.Text;
            //
            FilterBookedTickets();
        }

        private void CbDestination_TextChanged(object sender, EventArgs e)
        {
            this.destination = CbDestination.Text;
            //
            FilterBookedTickets();
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchInput = this.TbSearch.Text;
                FilterBookedTickets();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.LbSelectedId.Text.Trim()))
            {
                MessageBox.Show("Please select the ticket to cancel!");
                return;
            }
            BusManagementEntities db = new BusManagementEntities();
            //
            db.pro_CancelTicket(this.LbSelectedId.Text.Trim());
            this.LbSelectedId.Text = string.Empty;
            MessageBox.Show("Cancel successfully!");
            FilterBookedTickets();
        }
    }
}
