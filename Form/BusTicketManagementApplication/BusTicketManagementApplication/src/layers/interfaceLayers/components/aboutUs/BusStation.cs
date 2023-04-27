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
    public partial class BusStation : Form
    {
        public BusStation()
        {
            InitializeComponent();
        }

        private void BusStation_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void LoadDefault()
        {
            BSBusStation bSBusStation = new BSBusStation();
            this.dgvBusStation.DataSource = bSBusStation.GetAllStations();
        }
    }
}
