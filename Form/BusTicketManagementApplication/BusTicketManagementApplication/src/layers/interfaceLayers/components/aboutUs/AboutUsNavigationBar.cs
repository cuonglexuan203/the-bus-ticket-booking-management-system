using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.aboutUs
{
    public partial class AboutUsNavigationBar : Form
    {
        private static int navIndex = 0;
        private App parentForm;
        public AboutUsNavigationBar()
        {
            InitializeComponent();
        }
        public AboutUsNavigationBar(App parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        public static int NavIndex { get => navIndex; set => navIndex = value; }

        private void Handler_NavBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int tag = Convert.ToInt16(button.Tag.ToString());
            AboutUsNavigationBar.NavIndex = tag;
            this.parentForm.MainFeatureIndex = 5; // virtual number
        }

        private void PnlMainContainer_Paint(object sender, PaintEventArgs e)
        {
            Button selectedBtn = null;
            if (navIndex == 0)
            {
                selectedBtn = this.btnAboutUs;
            }
            else if (navIndex == 1)
            {
                selectedBtn = this.btnBusStation;
            }
            else if (navIndex == 2)
            {
                selectedBtn = this.BtnBusRoute;
            }
            e.Graphics.DrawLine(new Pen(Color.FromArgb(82, 203, 255), 2), selectedBtn.Left, selectedBtn.Bottom, selectedBtn.Right, selectedBtn.Bottom);
        }

    }
}
