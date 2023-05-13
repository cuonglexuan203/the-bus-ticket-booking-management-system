using BusTicketManagementApplication.src.layers.businessLayers;
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

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.setting
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string curPassword = this.TbCurrentPassword.Text.Trim();
            string newPassword = this.TbNewPassword.Text.Trim();
            string retypeNewPassword = this.TbRetypeNewPassword.Text.Trim();
            //
            if( string.IsNullOrEmpty(curPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(retypeNewPassword) )
            {
                this.LbNotifiedMessage.Text = "Please fully fill fields";
                this.LbNotifiedMessage.Show();
                return;
            }
            //
            BSLogin bslogin = new BSLogin();
            if (curPassword != UserData.Password)
            {
                this.LbNotifiedMessage.Text = "Current password is not correct!";
                this.LbNotifiedMessage.Show();
                return;
            }
            //
            if (newPassword != retypeNewPassword)
            {
                this.LbNotifiedMessage.Text = "Retype password is not match!";
                this.LbNotifiedMessage.Show();
                return;
            }
            //
            bool res = bslogin.ChangeUserPassword(UserData.Username, newPassword);
            if (!res)
            {
                this.LbNotifiedMessage.Text =  "Change password failed.";
                return;
            }
            //
            UserData.Password = newPassword;
            //
            this.LbNotifiedMessage.Text = "Change password succsessfully!"; 
            this.LbNotifiedMessage.Show();
            ClearInput();
        }
        private void ClearInput()
        {
            this.TbCurrentPassword.Text = string.Empty;
            this.TbNewPassword.Text = string.Empty;
            this.TbRetypeNewPassword.Text = string.Empty;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
