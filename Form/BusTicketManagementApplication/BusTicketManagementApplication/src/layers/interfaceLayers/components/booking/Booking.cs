using BusTicketManagementApplication.src.dbConnection;
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
    public partial class Booking : Form
    {
        //
        private App parentForm;
        //
        public Booking()
        {
            InitializeComponent();
        }
        public Booking(App parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            LoadSelectedTrip();
            LoadDefaultTicketType();
        }
        // Common function
        public void LoadDefaultTicketType()
        {
            this.CbType.Items.AddRange("Seat,Sleeper".Split(','));
            this.CbType.SelectedIndex = 0;
        }
        public void LoadSelectedTrip()
        {
            BSBooking bsbooking = new BSBooking();
            V_AVAILABLETRIP avaiTrip = bsbooking.GetTrip(UserData.CurrentSelectedTripId);
            string routeId = bsbooking.GetRouteId(avaiTrip.Trip_ID);
            V_ROUTEINFOR route = new BSRoute().GetRoute(routeId);
            //
            this.TbFrom.Text = route.Start_point.Trim();
            this.TbTo.Text = route.End_point.Trim();
            this.TbIDTrip.Text = UserData.CurrentSelectedTripId;
            this.TbDistance.Text = route.Distance.ToString().Trim();
            this.TbDuration.Text = avaiTrip.Duration.ToString().Trim();
        }
        public void LoadAvailableSeat(int type)
        {
            this.CbBookedSeat.DataSource = new BSBooking().GetAvailableSeat(UserData.CurrentSelectedTripId.Trim(), type);
            this.CbBookedSeat.SelectedIndex = 0;
        }
        public void LoadSelectedTicket()
        {
            BSBooking bsbooking = new BSBooking();
            bool type = this.CbType.SelectedIndex != 0;
            TICKET selectedTicket = bsbooking.GetTicket(UserData.CurrentSelectedTripId, type, this.CbBookedSeat.Text);
            this.TbIDTicket.Text = selectedTicket.id_ticket.ToString().Trim();
            this.TbFare.Text = selectedTicket.fare.ToString().Trim();
        }
        // end common function
        private void TbName_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.TbName.Text))
            {
                List<string> name = this.TbName.Text.Split(' ').ToList();
                UserData.Lastname = name?[name.Count - 1];
                UserData.Firstname = string.Join(" ", name.Take(name.Count - 1));
            }

        }

        private void MtbPhone_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.MtbPhone.Text))
            {
                UserData.Phone = this.MtbPhone.Text.Trim();

            }
        }

        private void CbBookedSeat_TextChanged(object sender, EventArgs e)
        {
            LoadSelectedTicket();
        }

        private void CbType_TextChanged(object sender, EventArgs e)
        {
            LoadAvailableSeat(this.CbType.SelectedIndex);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show( "Are you sure?", "Cancel Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.OK)
            {
                UserData.CurrentSelectedTripId = string.Empty;
                if (parentForm != null)
                {
                    parentForm.MainFeatureIndex = 4;
                }
            }
            
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            BSBooking bsbooking = new BSBooking();
            bsbooking.AddPassenger(this.TbName.Text, this.MtbPhone.Text);
        }



        //
    }
}
