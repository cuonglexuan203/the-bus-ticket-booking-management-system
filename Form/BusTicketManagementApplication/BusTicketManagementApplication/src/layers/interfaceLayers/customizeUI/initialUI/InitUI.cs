using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication
{
    public partial class App
    {
        private List<Control[]> featureItems;
        
        //

        private void InitUI()
        {
            featureItems = new List<Control[]> { new Control[]{ this.PcbHome, this.BtnHome }, new Control[] { this.PcbTrip, this.BtnTrip }
            , new Control[] { this.PcbBus, this.BtnBus }, new Control[] { this.PcbDriver, this.BtnDriver }, new Control []{this.PcbBooking, this.BtnBooking }
            , new Control[]{ this.PcbAboutUs, this.BtnAboutUs } };
        }
    }
}
