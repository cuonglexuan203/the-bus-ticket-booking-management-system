using BusTicketManagementApplication.src.layers.interfaceLayers.components.trip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BusTicketManagementApplication
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            if (Keyboard.IsKeyDown(Key.A))
            {

            }
        }

        private void BtnTrip_Click(object sender, EventArgs e)
        {
            Trip foo = new Trip();
            foo.TopLevel = false;
            foo.Dock = DockStyle.Fill;
            this.PnlFillContent.Controls.Add(foo);
            foo.Show();
        }
    }
}
