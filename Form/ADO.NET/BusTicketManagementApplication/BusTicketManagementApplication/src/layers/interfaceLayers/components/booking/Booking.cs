using BusTicketManagementApplication.src.env.statics;
using BusTicketManagementApplication.src.layers.businessLayers;
using BusTicketManagementApplication.src.layers.interfaceLayers.controllers;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            LoadUserInfor();
        }
        // Common function
        private void LoadUserInfor()
        {
            this.TbName.Text = UserData.FullName;
            this.MtbPhone.Text = UserData.Phone;
            this.TbEmail.Text = UserData.Email;

        }
        public void LoadDefaultTicketType()
        {
            this.CbType.Items.AddRange("Seat,Sleeper".Split(','));
            if (CbType.Items.Count > 0)
            {
                this.CbType.SelectedIndex = 0;
            }
        }
        public void LoadSelectedTrip()
        {
            BSBooking bsbooking = new BSBooking();
            DataRowView avaiTrip = bsbooking.GetTrip(UserData.CurrentSelectedTripId);
            string routeId = bsbooking.GetRouteId(avaiTrip["Trip_ID"].ToString().Trim());
            DataRowView route = new BSRoute().GetRoute(routeId);
            //
            this.TbFrom.Text = route["Start_point"].ToString().Trim();
            this.TbTo.Text = route["End_point"].ToString().Trim();
            this.TbIDTrip.Text = UserData.CurrentSelectedTripId;
            this.TbDistance.Text = route["Distance"].ToString().Trim();
            this.TbDuration.Text = avaiTrip["Duration"].ToString().Trim();
        }
        public void LoadAvailableSeat(int type)
        {
            this.TbIDTicket.Text = string.Empty;
            this.TbFare.Text = string.Empty;
            this.CbBookedSeat.DataSource = new BSBooking().GetAvailableSeat(UserData.CurrentSelectedTripId.Trim(), type);
            if (CbBookedSeat.Items.Count > 0)
            {
                this.CbBookedSeat.SelectedIndex = 0;
            }
        }
        public void LoadSelectedTicket()
        {
            BSBooking bsbooking = new BSBooking();
            bool type = this.CbType.SelectedIndex != 0;
            DataRowView selectedTicket = bsbooking.GetTicket(UserData.CurrentSelectedTripId, type, this.CbBookedSeat.Text);
            if (selectedTicket != null)
            {
                this.TbIDTicket.Text = selectedTicket["id_ticket"].ToString().Trim();
                this.TbFare.Text = selectedTicket["fare"].ToString().Trim();
            }
            else
            {
                this.TbIDTicket.Text = string.Empty;
                this.TbFare.Text = string.Empty;
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

            if(string.IsNullOrEmpty(this.TbIDTicket.Text.Trim()))
            {
                MessageBox.Show("Please select the ticket to booking!");
                return;
            }
            if (string.IsNullOrEmpty(this.TbEmail.Text.Trim()))
            {
                MessageBox.Show("Please input email to recieve the confirm mail");
                return;
            }
            else if (!this.TbEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("The email format is incorrect!");
                return;
            }
            BusManagementEntities db = new BusManagementEntities();
            //
            db.pro_AddDefaultBooking(this.TbIDTicket.Text.Trim(), UserData.GetPassengerId());
            // payment logic ( directly, online )


            // confirm logic
            Task res = SendConfirmEmail();
            if (res != null)
            {
                MessageBox.Show("Booking successfully, Confirm mail has been sent to you mailbox, please check to ensure that all informations are correct!");
            }
            else
            {
                MessageBox.Show("Booking successfully!, but can not send the confirm email");
            }
            LoadAvailableSeat(this.CbType.SelectedIndex);

        }
        //
        private Task SendConfirmEmail()
        {
            string userEmail = this.TbEmail.Text.Trim();
            if(string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Please input email to recieve the confirm mail");
                return null;
            }
            var bookedTicket = new BSBooking().GetBookedTicket(this.TbIDTicket.Text);
            if (bookedTicket == null)
            {
                return null;
            }

            EmailSender emailSender = new EmailSender();
            //
            return emailSender.SendEmailAsync(userEmail, StaticEnv.GetConfirmSubject(bookedTicket["Ticket_ID"].ToString().Trim()),
                StaticEnv.GetTemPlateConfirmMessage(bookedTicket["Ticket_ID"].ToString().Trim(), bookedTicket["Booking_time"].ToString().Trim(), this.TbName.Text, userEmail, this.MtbPhone.Text, bookedTicket["Start_point"].ToString().Trim()
                , bookedTicket["End_point"].ToString().Trim(), DateTime.Parse(bookedTicket["Departure_time"].ToString().Trim()), bookedTicket["Seat_number"].ToString().Trim(), bookedTicket["Fare"].ToString().Trim()));
        }
        //
    }
}
