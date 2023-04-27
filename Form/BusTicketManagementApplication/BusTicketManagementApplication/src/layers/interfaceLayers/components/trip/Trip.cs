using BusTicketManagementApplication.src.layers.businessLayers;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.booking;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.home;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.staff;
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

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.trip
{
    public partial class Trip : Form
    {
        private App parentForm;
        //
        private string searchInput = string.Empty;
        private string source = string.Empty;
        private string destination = string.Empty;
        private DateTime departureTime;
        // load data
        public Trip()
        {
            InitializeComponent();
        }
        public Trip(App parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            //
            if (!UserData.IsPassenger)
            {
                this.BtnBooking.Hide();
            }
        }
        private void Trip_Load(object sender, EventArgs e)
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
        private void FilterTrips()
        {
            BSTrip bSTrip = new BSTrip();
            if (this.parentForm.MainFeatureIndex == 1)
            {
                this.DgvMainData.DataSource = bSTrip.SearchAvailableTrips(searchInput, source, destination, departureTime);

            }
            else if (this.parentForm.MainFeatureIndex == 6 && StaffNavigationbar.NavIndex == 1)
            {
                this.DgvMainData.DataSource = bSTrip.SearchTrips(searchInput, source, destination, departureTime);
            }
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
            FilterTrips();
        }

        private void BtnSearchIcon_Click(object sender, EventArgs e)
        {
            FilterTrips();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            UserData.CurrentSelectedTripId = DgvMainData.CurrentRow?.Cells[0].Value.ToString();
            BookingNavigationBar.NavIndex = 0;
            this.parentForm.MainFeatureIndex = 4;
        }

        private void DgvMainData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedId = DgvMainData.CurrentRow?.Cells[0].Value.ToString();
            this.LbSelectedId.Text = selectedId;
        }


        private void CbSource_TextChanged(object sender, EventArgs e)
        {
            this.source = CbSource.Text;
            //
            FilterTrips();
        }

        private void CbDestination_TextChanged(object sender, EventArgs e)
        {
            this.destination = CbDestination.Text;
            //
            FilterTrips();
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchInput = this.TbSearch.Text;
                FilterTrips();
            }
        }


    }
}
