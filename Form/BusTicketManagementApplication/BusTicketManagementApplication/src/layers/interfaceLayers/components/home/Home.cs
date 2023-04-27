using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.trip;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.home
{
    public partial class Home : Form
    {

        private List<Image> images = new List<Image>
            {
        Properties.Resources.Cantho,
        Properties.Resources.Danang,
        Properties.Resources.Hanoi,
        Properties.Resources.Namcan,
        Properties.Resources.SG
        };

        private int currentImageIndex = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void btnRoute1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            pbHome.Image = images[currentImageIndex];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                pbHome.Image = images[currentImageIndex];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < images.Count - 1)
            {
                currentImageIndex++;
                pbHome.Image = images[currentImageIndex];
            }
        }
    }
}
