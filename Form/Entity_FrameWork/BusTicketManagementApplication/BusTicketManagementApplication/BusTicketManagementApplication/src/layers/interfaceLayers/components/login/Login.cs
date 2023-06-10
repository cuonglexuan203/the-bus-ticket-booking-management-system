using BusTicketManagementApplication.src.dbConnection;
using BusTicketManagementApplication.src.layers.businessLayers;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Animation;


namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.login
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            Keyboard.IsKeyDown(Key.Enter);
            DrawUI();
            //
            TbUsername.GotFocus += TbUsername_GotFocus;
            TbUsername.LostFocus += TbUsername_LostFocus;
            //
            TbPassword.GotFocus += TbPassword_GotFocus;
            TbPassword.LostFocus += TbPassword_LostFocus;
            //
        }
        private void DrawUI()
        {
            // draw background of btn login
            SetBackgroundImageBtnLogin();
            //
            PnlMainContainer.BackgroundImage = new Bitmap(PnlMainContainer.Width, PnlMainContainer.Height);
            using (Graphics g = Graphics.FromImage(PnlMainContainer.BackgroundImage))
            {
                g.Clear(Color.White);
                g.DrawRectangle(new Pen(Color.FromArgb(178, 175, 173)), new Rectangle(0, 0, PnlMainContainer.Width - 2, PnlMainContainer.Height - 2));
            }
        }

        private void SetBackgroundImageBtnLogin(int angle = 0)
        {
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(BtnLogin.Width, BtnLogin.Height)), Color.FromArgb(0, 219, 222), Color.FromArgb(252, 0, 255), angle, true);
            BtnLogin.BackgroundImage = new Bitmap(BtnLogin.Width, BtnLogin.Height);
            using (Graphics g = Graphics.FromImage(BtnLogin.BackgroundImage))
            {
                g.FillRectangle(brush, 0, 0, BtnLogin.Width, BtnLogin.Height);
            }
        }
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            SetBackgroundImageBtnLogin(180);
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            SetBackgroundImageBtnLogin();
        }

        private void Handler_UsernameInput_Click(object sender, EventArgs e)
        {
            this.TbUsername.Focus();
        }

        private void Handler_PasswordInput_Click(object sender, EventArgs e)
        {
            this.TbPassword.Focus();
        }
        private void Handler_ShowPlaceholder(TextBox tb, Label lb)
        {
            if (tb.Focused)
            {
                lb.Hide();
            }
            else
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    lb.Show();
                }
            }
        }
        private void TbUsername_GotFocus(object sender, EventArgs e)
        {
            Handler_ShowPlaceholder((TextBox)sender, this.LbPlaceholderUsername);
        }
        private void TbUsername_LostFocus(object sender, EventArgs e)
        {
            Handler_ShowPlaceholder((TextBox)sender, this.LbPlaceholderUsername);
        }
        private void TbPassword_GotFocus(object sender, EventArgs e)
        {
            Handler_ShowPlaceholder((TextBox)sender, this.LbPlaceholderPassword);
        }
        private void TbPassword_LostFocus(object sender, EventArgs e)
        {
            Handler_ShowPlaceholder((TextBox)sender, this.LbPlaceholderPassword);
        }

        private void Handler_Focus(object sender, EventArgs e)
        {
            this.PnlMainContainer.Focus();
        }

        private void TbPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnLogin.PerformClick();
            }
        }
        private void Handler_LoginSuccessfully()
        {
            this.DialogResult = DialogResult.OK;
            List<Form> closedForms = new List<Form>();
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Contains(this))
                {
                    closedForms.Add(Application.OpenForms[i]);
                }
            }
            foreach (Form fm in closedForms)
            {
                fm.DialogResult = DialogResult.OK;
                fm.Close();
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = this.TbUsername.Text;
            string password = this.TbPassword.Text;
            string passengerId = string.Empty;
            string employeeId = string.Empty;
            string errMsg = string.Empty;
            //
            bool isLogin = new BSLogin().ValidateUser(username, password,ref passengerId, ref employeeId, ref errMsg);
            UserData.ClearUserData();
            if (isLogin && !string.IsNullOrEmpty(passengerId))
            {
                UserData.IsPassenger = true;
                UserData.SetUserLoginData(username, password);
                UserData.SetPassengerId(passengerId);
                //
                V_USERINFOR curUser = new BSLogin().GetUser(passengerId);
                UserData.SetUserData(curUser.name.Trim(), curUser.phone_number.Trim());
                //
                PASSENGER curPassenger = new BSPassenger().GetPassenger(passengerId);
                UserData.Email = curPassenger?.email?.Trim();
                UserData.Gender = curPassenger.gender;
                //
                //
                Handler_LoginSuccessfully();
            }
            else if(isLogin && !string.IsNullOrEmpty(employeeId))
            {
                bool isAdmin = new BSLogin().IsAdmin(employeeId);
                UserData.ClearUserData();
                if (isAdmin)
                {
                    UserData.IsAdmin = true;
                }
                else
                {
                    UserData.IsStaff = true;
                }
                UserData.SetUserLoginData(username, password);
                UserData.SetSystemId(employeeId);
                //
                V_EMPLOYEEINFOR curEmployee = new BSLogin().GetEmployee(employeeId);
                UserData.SetUserData(curEmployee.Name.Trim(), curEmployee.Phone_Number.Trim());
                //
                UserData.Email = curEmployee.Email?.Trim();
                UserData.Gender = curEmployee.Gender;
                Handler_LoginSuccessfully();
            }
            else
            {
                this.LbErrorMessage.Text = errMsg;
            }
        }

        private void PnlMainContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool RenderActiveForm(Form fm, Control control)
        {
            bool res = fm != null;
            if (res)
            {
                fm.TopLevel = false;
                fm.Dock = DockStyle.Fill;
                fm.FormBorderStyle = FormBorderStyle.None;
                control.Controls.Add(fm);
                fm.Show();
                fm.BringToFront();
            }
            return res;
        }
        private void LbSignUp_Click(object sender, EventArgs e)
        {
            RenderActiveForm(new SignUp(), this);
        }

        private void ChbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbShow.Checked)
            {
                this.TbPassword.PasswordChar = '\0';
            }
            else
            {
                this.TbPassword.PasswordChar = '*';
            }
        }
    }
}