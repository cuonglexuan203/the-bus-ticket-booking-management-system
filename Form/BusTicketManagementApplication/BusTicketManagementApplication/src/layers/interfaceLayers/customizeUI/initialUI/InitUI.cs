using System;
using System.Collections.Generic;
using System.Drawing;
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
        private void LoadUI()
        {
            DrawRectangleFrame(this.PnlContainer, Color.FromArgb(183, 183, 183), 1, new Point(0, 0), this.PnlContainer.Width - 2, this.PnlContainer.Height - 2);
        }
        //
        private void DrawRectangleFrame(Control ctr,Color color, int frameWidth, Point p1, int width, int height)
        {
            ctr.BackgroundImage = new Bitmap(ctr.Width, ctr.Height);
            using(Graphics g = Graphics.FromImage(ctr.BackgroundImage))
            {
                g.DrawRectangle(new Pen(color, frameWidth), p1.X, p1.Y, width, height);
            }
        }
    }
}
