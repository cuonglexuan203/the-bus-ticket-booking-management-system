using BusTicketManagementApplication.src.layers.interfaceLayers.controllers.interfaces;
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
    public partial class BookingNavigationBar : Form, INavigationBar
    {
        private static int navIndex = 0;
        private App parentForm;
        public BookingNavigationBar()
        {
            InitializeComponent();
        }
        public BookingNavigationBar(App parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        public static int NavIndex { get => navIndex; set => navIndex = value; }

        public void Handler_NavBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int tag = Convert.ToInt16(button.Tag.ToString());
            BookingNavigationBar.NavIndex = tag;
            this.parentForm.MainFeatureIndex = 4; // virtual number
        }


        public void PnlMainContainer_Paint(object sender, PaintEventArgs e)
        {
            Button selectedBtn = null;
            if (navIndex == 0)
            {
                selectedBtn = this.BtnBooking;
            }
            else if (navIndex == 1)
            {
                selectedBtn = this.BtnBooked;
            }
            e.Graphics.DrawLine(new Pen(Color.FromArgb(82, 203, 255), 2), selectedBtn.Left, selectedBtn.Bottom, selectedBtn.Right, selectedBtn.Bottom);
        }
    }
}
