using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.login
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            DrawUI();
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
            //
            new List<Control>() { this.PnlUsername, this.PnlPassword, this.PnlFullName, this.PnlPhone }.ForEach(c => DrawHorizontalBar(c));
        }

        private void SetBackgroundImageBtnLogin(int angle = 0)
        {
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(BtnSignUp.Width, BtnSignUp.Height)), Color.FromArgb(0, 219, 222), Color.FromArgb(252, 0, 255), angle, true);
            BtnSignUp.BackgroundImage = new Bitmap(BtnSignUp.Width, BtnSignUp.Height);
            using (Graphics g = Graphics.FromImage(BtnSignUp.BackgroundImage))
            {
                g.FillRectangle(brush, 0, 0, BtnSignUp.Width, BtnSignUp.Height);
            }
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

        private void BtnSignUp_MouseEnter(object sender, EventArgs e)
        {
            SetBackgroundImageBtnLogin(180);
        }

        private void BtnSignUp_MouseLeave(object sender, EventArgs e)
        {
            SetBackgroundImageBtnLogin();
        }
        private void DrawHorizontalBar(Control ctr)
        {
            ctr.BackgroundImage = new Bitmap(ctr.Width, ctr.Height);
            using (Graphics g = Graphics.FromImage(ctr.BackgroundImage))
            {
                g.Clear(Color.White);
                g.DrawLine(new Pen(Color.FromArgb(126, 126, 126)), 0, ctr.Height - 2, ctr.Width, ctr.Height - 2);
            }
        }

        private void LbLogin_Click(object sender, EventArgs e)
        {
            RenderActiveForm(new Login(), this);
        }

        private void Handler_Click(object sender, EventArgs e)
        {
            this.PnlMainContainer.Focus();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
