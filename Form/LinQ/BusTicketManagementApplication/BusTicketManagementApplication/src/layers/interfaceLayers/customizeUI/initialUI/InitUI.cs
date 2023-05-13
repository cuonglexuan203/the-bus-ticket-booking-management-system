using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using Org.BouncyCastle.Asn1.Mozilla;
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
        private List<Control> hideOnLostFocusControls;
        private List<Control> staffControls;
        private List<Control> adminControls;
        //

        private void InitUI()
        {
            featureItems = new List<Control[]> { new Control[]{ this.PcbHome, this.BtnHome }, new Control[] { this.PcbTrip, this.BtnTrip }
            , new Control[] { this.PcbBus, this.BtnBus }, new Control[] { this.PcbDriver, this.BtnDriver }, new Control []{this.PcbBooking, this.BtnBooking }
            , new Control[]{ this.PcbAboutUs, this.BtnAboutUs }, new Control[] {this.PcbStaff, this.BtnStaff }, new Control[] {this.PcbAdmin, this.BtnAdmin } };
            staffControls = new List<Control> { this.PcbStaff, this.BtnStaff };
            adminControls = new List<Control> { this.PcbAdmin, this.BtnAdmin };
            //
            hideOnLostFocusControls = new List<Control> { this.PnlUserSetting, this.PnlSettingMenu };
            // 
            List<Control> initialHideControls = new List<Control> {this.BtnStaff, this.PcbStaff, this.BtnAdmin, this.PcbAdmin};
            initialHideControls.AddRange(hideOnLostFocusControls);
            HideControls(initialHideControls);
            //


            //
            AddEvent_Controls_OnClick(new List<Control> { this.PnlDashboardMenuItems, this.PnlNavigationBar, this.PnlBrandInfor, this.PnlFillContent }, new List<Action<object, EventArgs>> { HideOptionalControls_OnClick });

        }
        public void ShowStaffUI()
        {
            ShowUI(staffControls);
        }
        public void ShowAdminUI()
        {
            ShowStaffUI();
            ShowUI(adminControls);
        }
        public void HideStaffUI()
        {
            HideUI(staffControls);
        }
        public void HideAdminUI()
        {
            HideStaffUI();
            HideUI(adminControls);
        }
        public void ShowUI(List<Control> ls)
        {
            foreach(Control c in ls)
            {
                c.Show();
            }
        }
        public void HideUI(List<Control> ls)
        {
            foreach (Control control in ls)
            {
                control.Hide();
            }
        }
        public void HideOptionalControls_OnClick(object sender, EventArgs e)
        {

            HideControls(hideOnLostFocusControls);
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
        //
        public void HideControls(List <Control> autoHideControls)
        {
            foreach(Control control in autoHideControls)
            {
                control.Hide();
            }
        }
        //
        public void AddEvents_ForClick(Control c, List<Action<Object, EventArgs>> elist) // event list
        {
            foreach (Action<Object, EventArgs> ev in elist)
            {
                c.Click += new System.EventHandler(ev);
            }
        }

        public void AddEventHandlerForFullControls(Control parent, List<Action<object, EventArgs>> elist) // add event handler for the control include its child (full tree)
        {
            AddEvents_ForClick(parent, elist);
            foreach (Control c in parent.Controls)
            {
                //bool isNonHideControlOnClick = false;
                //foreach (Control ctr in hideOnLostFocusControls)
                //{
                //    if (c == ctr)
                //    {
                //        isNonHideControlOnClick = true;
                //        break;
                //    }
                //}
                //if (isNonHideControlOnClick)
                //{
                //    continue;
                //}
                //
                AddEvents_ForClick(c, elist); // add all event handler in list for the control
                if (c.HasChildren)
                {
                    AddEventHandlerForFullControls(c, elist);
                }
            }
        }
        public void AddEvent_Controls_OnClick(List<Control> optionalControls, List<Action<object, EventArgs>> elist) // traverse all panel need to add event handler
        {
            foreach (Control c in optionalControls)
            {
                AddEventHandlerForFullControls(c, elist);
            }
        }
    }
}
