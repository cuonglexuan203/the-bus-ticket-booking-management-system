using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.controllers.interfaces
{
    internal interface INavigationBar
    {
        void Handler_NavBtn_Click(object sender, EventArgs e);
        void PnlMainContainer_Paint(object sender, PaintEventArgs e);
    }
}
