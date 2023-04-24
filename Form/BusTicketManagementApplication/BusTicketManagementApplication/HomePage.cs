using BusTicketManagementApplication.src.layers.interfaceLayers.components.booking;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.home;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.login;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.Profile;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.trip;
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
                                break;
                            }
                        case 3:
                            {
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
                ctr.BackColor = Color.White;
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
    }
}
