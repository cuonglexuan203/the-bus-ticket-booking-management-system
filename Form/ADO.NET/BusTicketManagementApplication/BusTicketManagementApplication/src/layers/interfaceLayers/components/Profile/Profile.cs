using BusTicketManagementApplication.src.layers.businessLayers;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.Profile
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            System.Windows.Input.Keyboard.IsKeyDown(Key.A);
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            LoadUserInfor();
        }
        private void ToggleControls(List<Control> ctrls)
        {
            foreach(Control ctrl in ctrls)
            {
                ctrl.Enabled = !ctrl.Enabled;
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (this.TbFullname.Enabled)
            {
                
                string email = null;
                if (!string.IsNullOrEmpty(this.TbEmail.Text.Trim()))
                {
                    email = this.TbEmail.Text.Trim();
                    if (!email.Contains("@gmail.com"))
                    {
                        MessageBox.Show("Email is incorrect format!");
                        return;
                    }
                }
                string fullname = this.TbFullname.Text.Trim();
                string phone = this.TbPhone.Text.Trim();

                bool? gender = null;
                if (this.RbMale.Checked)
                {
                    gender = false;
                }
                else if (this.RbFemale.Checked)
                {
                    gender = true;
                }
                if(string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("The full name and phone fields can not be empty!");
                    return;
                }
                bool response = false;
                if (!UserData.IsPassenger)
                {
                    string employeeId = UserData.GetSystemId();
                    response = new BSPassenger().UpdateEmployee(employeeId, fullname, phone, email, gender);
                }
                else
                {
                    string passengerId = UserData.GetPassengerId();
                    response = new BSPassenger().UpdatePassenger(passengerId, fullname, phone, email, gender);
                }
                //
                if (!response)
                {
                    MessageBox.Show("Update failed!");
                    return;
                }
                SetUserInfor(fullname, phone, email, gender);
                MessageBox.Show("Update successfully!");
            }
            //
            List<Control> ctrls = new List<Control>() { this.TbFullname, this.TbPhone, this.TbEmail, this.RbMale, this.RbFemale };
            ToggleControls(ctrls);
        }
        private void LoadUserInfor()
        {
            this.TbFullname.Text = UserData.FullName;
            this.TbEmail.Text = UserData.Email;
            this.TbPhone.Text = UserData.Phone;
            this.RbMale.Checked = UserData.Gender == false;
            this.RbFemale.Checked = UserData.Gender == true;
        }
        private void SetUserInfor(string fullname, string phone, string email, bool? gender)
        {
            UserData.FullName = fullname;
            UserData.Email = email;
            UserData.Phone = phone;
            UserData.Gender = gender;
        }
        
    }
}
