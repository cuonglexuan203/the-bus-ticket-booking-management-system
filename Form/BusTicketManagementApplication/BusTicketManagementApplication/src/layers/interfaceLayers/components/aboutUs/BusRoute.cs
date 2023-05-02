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

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.aboutUs
{
    public partial class BusRoute : Form
    {
        public BusRoute()
        {
            InitializeComponent();
        }

        private void BusRoute_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }


        private void LoadDefault()
        {
            BSRoute bSBusRoute = new BSRoute();
            this.dgvBusRoute.DataSource = bSBusRoute.GetAllRoutes();
        }
    }
}
