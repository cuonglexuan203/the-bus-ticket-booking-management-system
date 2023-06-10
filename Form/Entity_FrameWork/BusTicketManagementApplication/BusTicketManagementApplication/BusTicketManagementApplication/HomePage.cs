using BusTicketManagementApplication.src.layers.interfaceLayers.components.booking;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.home;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.login;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.Profile;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.trip;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.bus;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.aboutUs;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.driver;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.setting;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.staff;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.admin;
using BusTicketManagementApplication.src.layers.businessLayers;

namespace BusTicketManagementApplication
{
    public partial class App : Form
    {
        //
        private Form activatedForm;
        private string searchInput = string.Empty;
        private int mainFeatureIndex = 0;

        public Form ActivatedForm { get => activatedForm; set => activatedForm = value; }
        public string SearchInput { get => searchInput; set => searchInput = value; }
        public int MainFeatureIndex { get => mainFeatureIndex; set { 
            if (value >= 0)
                {
                    mainFeatureIndex = value;
                    if (value >= 0 && value < 100)
                    {
                        ResetFeatures();
                        ActiveFeature(value);
                        this.PnlNavigationBar.Controls.Clear();
                    }
                    switch (value)
                    {
                        case 100:
                            {
                                ToggleControl(PnlUserSetting);
                                break;
                            }
                        case 0:
                            {
                                RenderActiveForm(new Home(), this.PnlFillContent);
                                break;
                            }
                        case 1:
                            {
                                RenderActiveForm(new Trip(this), this.PnlFillContent);
                                break;
                            }
                        case 2:
                            {
                                RenderActiveForm(new Bus(this), this.PnlFillContent);
                                break;
                            }
                        case 3:
                            {
                                RenderActiveForm(new Driver(), this.PnlFillContent);
                                break;
                            }
                        case 4:
                            {
                                RenderActiveForm(new BookingNavigationBar(this), this.PnlNavigationBar);
                                //
                                Form renderForm = new Booking(this);
                                if (BookingNavigationBar.NavIndex == 0)
                                {
                                    if (string.IsNullOrEmpty(UserData.CurrentSelectedTripId))
                                    {
                                        renderForm = new UnSelectBooking();
                                    }
                                }
                                else if(BookingNavigationBar.NavIndex == 1)
                                {
                                    renderForm = new Booked();
                                }
                                RenderActiveForm(renderForm, this.PnlFillContent);
                                break;
                            }
                        case 5:
                            {
                                RenderActiveForm(new AboutUsNavigationBar(this), this.PnlNavigationBar);

                                Form renderform = new Form();
                                if (AboutUsNavigationBar.NavIndex == 0)
                                {
                                    renderform = new AboutUs();
                                }
                                else if (AboutUsNavigationBar.NavIndex == 1)
                                {
                                    renderform = new BusStation();
                                }
                                else if (AboutUsNavigationBar.NavIndex == 2)
                                {
                                    renderform = new BusRoute();
                                }
                                RenderActiveForm(renderform, this.PnlFillContent);
                                break;
                            }
                        case 6:
                            {
                                RenderActiveForm(new StaffNavigationbar(this), this.PnlNavigationBar);
                                //
                                Form renderForm = new Passenger();
                                if (StaffNavigationbar.NavIndex == 0)
                                {

                                }
                                else if(StaffNavigationbar.NavIndex == 1)
                                {
                                    renderForm = new Trip(this);
                                }
                                else if (StaffNavigationbar.NavIndex == 2)
                                {
                                    renderForm = new BookedTicketPassenger();
                                }
                                RenderActiveForm(renderForm, this.PnlFillContent);
                                break;
                            }
                        case 7:
                            {
                                RenderActiveForm(new AdminNavigationBar(this), this.PnlNavigationBar);
                                //
                                Form renderForm = new CashReserve();
                                if (AdminNavigationBar.NavIndex == 0)
                                {

                                }
                                else if (AdminNavigationBar.NavIndex == 1)
                                {
                                    renderForm = new Employee();
                                }
                                else if (AdminNavigationBar.NavIndex == 2)
                                {
                                    renderForm = new Statistic();
                                }
                                RenderActiveForm(renderForm, this.PnlFillContent);
                                break;
                            }
                    }
                }

            } }

        //
        // load function
        public App()
        {
            InitializeComponent();
            if (Keyboard.IsKeyDown(Key.A))
            {

            }
            
        }
        private void App_Load(object sender, EventArgs e)
        {
            //
            InitUI();
            LoadUI();
            // load current date, time
            this.LbDate.Text = "Today - " + DateTime.Now.ToString().Split(' ')[0];
            //
            string[] rightTime = DateTime.Now.ToString().Split(' ');
            this.LbTime.Text = rightTime[1] + " " + rightTime[2];
            TimerNow.Start();
            //
        }
        // Login process
        private DialogResult GetFormResult(Form fm)
        {
            return fm.ShowDialog();
        }
        private bool CheckLogin()
        {
            if (!UserData.Islogin)
            {
                DialogResult loginResult = GetFormResult(new Login());
                if(loginResult == DialogResult.OK)
                {
                    UserData.Islogin = true;
                    HideAdminUI();
                    if (UserData.IsStaff)
                    {

                        ShowStaffUI();
                    }
                    else if (UserData.IsAdmin)
                    {
                        ShowAdminUI();
                    }

                }
            }
            return UserData.Islogin;
        }

        //
        // common functions
        private bool RenderActiveForm(Form fm, Control control)
        {
            bool res = fm != null;
            if(res)
            {
                ActivatedForm = fm;
                ActivatedForm.TopLevel = false;
                ActivatedForm.Dock = DockStyle.Fill;
                ActivatedForm.FormBorderStyle = FormBorderStyle.None;
                control.Controls.Add(ActivatedForm);
                ActivatedForm.Show();
                ActivatedForm.BringToFront();
            }
            return res;
        }
        // end common functions

        // timer tick function
        private void TimerNow_Tick(object sender, EventArgs e)
        {
            string[] rightTime = DateTime.Now.ToString().Split(' ');
            this.LbTime.Text = rightTime[1] + " " + rightTime[2];
        }
        // end timer tick function
        private void ToggleControl(Control control)
        {
            if (control.Visible)
            {
                control.Hide();
            }
            else
            {
                control.Show();
            }
        }
        private void TbSearch_Leave(object sender, EventArgs e)
        {
            SearchInput = this.TbSearch.Text.Trim();
            if (string.IsNullOrEmpty(SearchInput))
            {
                this.LbPlaceholder.Show();
            }
        }
        private void ResetFeatures()
        {
            foreach (Control[] ctrArr in featureItems)
            {
                foreach(Control ctr in ctrArr)
                {
                    ctr.BackColor = Color.Transparent;
                }
            }
        }
        private void ActiveFeature(int featureIndex)
        {
            foreach (Control ctr in featureItems[featureIndex])
            {
                ctr.BackColor = Color.Gainsboro;
            }
        }
        private void Handler_Features_Click(object sender, EventArgs e)
        {
            if (!UserData.Islogin)
            {
                CheckLogin();
            }
            if(UserData.Islogin)
            {
                SetTagIndex(sender);
            }
        }
        private void SetTagIndex(object sender)
        {
            Control ctr = sender as Control;
            int tag = Convert.ToInt16(ctr.Tag.ToString());
            if (ctr != null)
            {
                this.MainFeatureIndex = tag;

            }
        }

        private void LbPlaceholder_Click(object sender, EventArgs e)
        {
            this.TbSearch.Focus();
        }

        private void TbSearch_Enter(object sender, EventArgs e)
        {
            this.LbPlaceholder.Hide();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            ToggleControl(this.PnlUserSetting);
            RenderActiveForm(new Profile(), this.PnlFillContent);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            ToggleControl(this.PnlUserSetting);
            UserData.ClearUserData();
            ResetFeatures();
            this.PnlNavigationBar.Controls.Clear();
            this.PnlFillContent.Controls.Clear();
        }

        private void Handler_Setting_Click(object sender, EventArgs e)
        {
            ResetFeatures();
            if (this.PnlSettingMenu.Visible)
            {
                this.PnlSettingMenu.Hide();
            }
            else
            {
                this.PnlSettingMenu.Show();
            }
        }

        private void Handler_Setting_MouseEnter(object sender, EventArgs e)
        {
            this.PcbSetting.BackColor = Color.Gainsboro;
            this.BtnSetting.ForeColor = Color.Black;
        }

        private void Handler_Setting_MouseLeave(object sender, EventArgs e)
        {
            this.PcbSetting.BackColor = Color.Transparent;
            this.BtnSetting.ForeColor = Color.White;
        }
        private void SetBackgroundColor_HoverControl(Control ctr, Color color)
        {
            for (int i = 0; i < featureItems.Count; i++)
            {
                if (i != mainFeatureIndex)
                {
                    if (featureItems[i][0] == ctr || featureItems[i][1] == ctr)
                    {
                        featureItems[i][0].BackColor = color;
                        featureItems[i][1].BackColor = color;
                    }
                }
            }
        }
        private void Handler_Features_MouseEnter(object sender, EventArgs e)
        {
            Control curCtrl = sender as Control;
            SetBackgroundColor_HoverControl(curCtrl, Color.Gainsboro);
        }

        private void Handler_Features_MouseLeave(object sender, EventArgs e)
        {
            Control curCtrl = sender as Control;
            SetBackgroundColor_HoverControl(curCtrl, Color.Transparent);
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (!UserData.Islogin)
            {
                CheckLogin();
            }
            if (UserData.Islogin)
            {
                this.PnlNavigationBar.Controls.Clear();
                this.PnlFillContent.Controls.Clear();
                //
                RenderActiveForm(new ChangePassword(), this.PnlFillContent);
                this.PnlSettingMenu.Hide();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?","Exit application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
