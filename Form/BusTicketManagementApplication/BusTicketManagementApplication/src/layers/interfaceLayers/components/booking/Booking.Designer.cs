﻿namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.booking
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlMainContainer = new System.Windows.Forms.Panel();
            this.GbTravelInfor = new System.Windows.Forms.GroupBox();
            this.GbUserInfor = new System.Windows.Forms.GroupBox();
            this.MtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.LbPhone = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LbTrip = new System.Windows.Forms.Label();
            this.LbTicket = new System.Windows.Forms.Label();
            this.LbFare = new System.Windows.Forms.Label();
            this.LbBookedSeat = new System.Windows.Forms.Label();
            this.LbDistance = new System.Windows.Forms.Label();
            this.LbDuration = new System.Windows.Forms.Label();
            this.LbTo = new System.Windows.Forms.Label();
            this.LbFrom = new System.Windows.Forms.Label();
            this.TbFrom = new System.Windows.Forms.TextBox();
            this.TbTo = new System.Windows.Forms.TextBox();
            this.TbIDTrip = new System.Windows.Forms.TextBox();
            this.TbIDTicket = new System.Windows.Forms.TextBox();
            this.TbDistance = new System.Windows.Forms.TextBox();
            this.TbFare = new System.Windows.Forms.TextBox();
            this.TbDuration = new System.Windows.Forms.TextBox();
            this.CbBookedSeat = new System.Windows.Forms.ComboBox();
            this.PnlMainContainer.SuspendLayout();
            this.GbTravelInfor.SuspendLayout();
            this.GbUserInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Controls.Add(this.BtnCancel);
            this.PnlMainContainer.Controls.Add(this.BtnBooking);
            this.PnlMainContainer.Controls.Add(this.GbTravelInfor);
            this.PnlMainContainer.Controls.Add(this.GbUserInfor);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(965, 598);
            this.PnlMainContainer.TabIndex = 2;
            // 
            // GbTravelInfor
            // 
            this.GbTravelInfor.Controls.Add(this.CbBookedSeat);
            this.GbTravelInfor.Controls.Add(this.TbDuration);
            this.GbTravelInfor.Controls.Add(this.TbDistance);
            this.GbTravelInfor.Controls.Add(this.TbFare);
            this.GbTravelInfor.Controls.Add(this.TbIDTicket);
            this.GbTravelInfor.Controls.Add(this.TbIDTrip);
            this.GbTravelInfor.Controls.Add(this.TbTo);
            this.GbTravelInfor.Controls.Add(this.TbFrom);
            this.GbTravelInfor.Controls.Add(this.LbTo);
            this.GbTravelInfor.Controls.Add(this.LbFrom);
            this.GbTravelInfor.Controls.Add(this.LbDuration);
            this.GbTravelInfor.Controls.Add(this.LbDistance);
            this.GbTravelInfor.Controls.Add(this.LbBookedSeat);
            this.GbTravelInfor.Controls.Add(this.LbFare);
            this.GbTravelInfor.Controls.Add(this.LbTicket);
            this.GbTravelInfor.Controls.Add(this.LbTrip);
            this.GbTravelInfor.Location = new System.Drawing.Point(9, 96);
            this.GbTravelInfor.Name = "GbTravelInfor";
            this.GbTravelInfor.Size = new System.Drawing.Size(944, 401);
            this.GbTravelInfor.TabIndex = 3;
            this.GbTravelInfor.TabStop = false;
            this.GbTravelInfor.Text = "Travel Information";
            // 
            // GbUserInfor
            // 
            this.GbUserInfor.Controls.Add(this.MtbPhone);
            this.GbUserInfor.Controls.Add(this.LbPhone);
            this.GbUserInfor.Controls.Add(this.LbName);
            this.GbUserInfor.Controls.Add(this.textBox1);
            this.GbUserInfor.Location = new System.Drawing.Point(9, 9);
            this.GbUserInfor.Margin = new System.Windows.Forms.Padding(0);
            this.GbUserInfor.Name = "GbUserInfor";
            this.GbUserInfor.Size = new System.Drawing.Size(701, 72);
            this.GbUserInfor.TabIndex = 2;
            this.GbUserInfor.TabStop = false;
            this.GbUserInfor.Text = "User Information";
            // 
            // MtbPhone
            // 
            this.MtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbPhone.Location = new System.Drawing.Point(533, 36);
            this.MtbPhone.Margin = new System.Windows.Forms.Padding(0);
            this.MtbPhone.Mask = "0000 000 0000";
            this.MtbPhone.Name = "MtbPhone";
            this.MtbPhone.Size = new System.Drawing.Size(156, 21);
            this.MtbPhone.TabIndex = 3;
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.BackColor = System.Drawing.Color.Transparent;
            this.LbPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPhone.Location = new System.Drawing.Point(438, 36);
            this.LbPhone.Margin = new System.Windows.Forms.Padding(0);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(65, 21);
            this.LbPhone.TabIndex = 2;
            this.LbPhone.Text = "Phone";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbName.Location = new System.Drawing.Point(20, 36);
            this.LbName.Margin = new System.Windows.Forms.Padding(0);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(54, 21);
            this.LbName.TabIndex = 1;
            this.LbName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(102, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 21);
            this.textBox1.TabIndex = 0;
            // 
            // BtnBooking
            // 
            this.BtnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BtnBooking.ForeColor = System.Drawing.Color.White;
            this.BtnBooking.Location = new System.Drawing.Point(177, 519);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(200, 55);
            this.BtnBooking.TabIndex = 4;
            this.BtnBooking.Text = "Booking";
            this.BtnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBooking.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(542, 519);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(200, 55);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // LbTrip
            // 
            this.LbTrip.AutoSize = true;
            this.LbTrip.BackColor = System.Drawing.Color.Transparent;
            this.LbTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTrip.Location = new System.Drawing.Point(24, 167);
            this.LbTrip.Margin = new System.Windows.Forms.Padding(0);
            this.LbTrip.Name = "LbTrip";
            this.LbTrip.Size = new System.Drawing.Size(98, 21);
            this.LbTrip.TabIndex = 2;
            this.LbTrip.Text = "ID Trip:";
            // 
            // LbTicket
            // 
            this.LbTicket.AutoSize = true;
            this.LbTicket.BackColor = System.Drawing.Color.Transparent;
            this.LbTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTicket.Location = new System.Drawing.Point(24, 264);
            this.LbTicket.Margin = new System.Windows.Forms.Padding(0);
            this.LbTicket.Name = "LbTicket";
            this.LbTicket.Size = new System.Drawing.Size(120, 21);
            this.LbTicket.TabIndex = 3;
            this.LbTicket.Text = "ID Ticket:";
            // 
            // LbFare
            // 
            this.LbFare.AutoSize = true;
            this.LbFare.BackColor = System.Drawing.Color.Transparent;
            this.LbFare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbFare.Location = new System.Drawing.Point(366, 167);
            this.LbFare.Margin = new System.Windows.Forms.Padding(0);
            this.LbFare.Name = "LbFare";
            this.LbFare.Size = new System.Drawing.Size(65, 21);
            this.LbFare.TabIndex = 4;
            this.LbFare.Text = "Fare:";
            // 
            // LbBookedSeat
            // 
            this.LbBookedSeat.AutoSize = true;
            this.LbBookedSeat.BackColor = System.Drawing.Color.Transparent;
            this.LbBookedSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbBookedSeat.Location = new System.Drawing.Point(636, 167);
            this.LbBookedSeat.Margin = new System.Windows.Forms.Padding(0);
            this.LbBookedSeat.Name = "LbBookedSeat";
            this.LbBookedSeat.Size = new System.Drawing.Size(142, 21);
            this.LbBookedSeat.TabIndex = 5;
            this.LbBookedSeat.Text = "Booked seat:";
            // 
            // LbDistance
            // 
            this.LbDistance.AutoSize = true;
            this.LbDistance.BackColor = System.Drawing.Color.Transparent;
            this.LbDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbDistance.Location = new System.Drawing.Point(366, 264);
            this.LbDistance.Margin = new System.Windows.Forms.Padding(0);
            this.LbDistance.Name = "LbDistance";
            this.LbDistance.Size = new System.Drawing.Size(109, 21);
            this.LbDistance.TabIndex = 6;
            this.LbDistance.Text = "Distance:";
            // 
            // LbDuration
            // 
            this.LbDuration.AutoSize = true;
            this.LbDuration.BackColor = System.Drawing.Color.Transparent;
            this.LbDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbDuration.Location = new System.Drawing.Point(636, 264);
            this.LbDuration.Margin = new System.Windows.Forms.Padding(0);
            this.LbDuration.Name = "LbDuration";
            this.LbDuration.Size = new System.Drawing.Size(109, 21);
            this.LbDuration.TabIndex = 7;
            this.LbDuration.Text = "Duration:";
            // 
            // LbTo
            // 
            this.LbTo.AutoSize = true;
            this.LbTo.BackColor = System.Drawing.Color.Transparent;
            this.LbTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTo.Location = new System.Drawing.Point(507, 68);
            this.LbTo.Margin = new System.Windows.Forms.Padding(0);
            this.LbTo.Name = "LbTo";
            this.LbTo.Size = new System.Drawing.Size(32, 21);
            this.LbTo.TabIndex = 9;
            this.LbTo.Text = "To";
            // 
            // LbFrom
            // 
            this.LbFrom.AutoSize = true;
            this.LbFrom.BackColor = System.Drawing.Color.Transparent;
            this.LbFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbFrom.Location = new System.Drawing.Point(142, 68);
            this.LbFrom.Margin = new System.Windows.Forms.Padding(0);
            this.LbFrom.Name = "LbFrom";
            this.LbFrom.Size = new System.Drawing.Size(54, 21);
            this.LbFrom.TabIndex = 8;
            this.LbFrom.Text = "From";
            // 
            // TbFrom
            // 
            this.TbFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbFrom.Enabled = false;
            this.TbFrom.Location = new System.Drawing.Point(206, 68);
            this.TbFrom.Margin = new System.Windows.Forms.Padding(0);
            this.TbFrom.Name = "TbFrom";
            this.TbFrom.Size = new System.Drawing.Size(250, 21);
            this.TbFrom.TabIndex = 10;
            // 
            // TbTo
            // 
            this.TbTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbTo.Enabled = false;
            this.TbTo.Location = new System.Drawing.Point(557, 68);
            this.TbTo.Margin = new System.Windows.Forms.Padding(0);
            this.TbTo.Name = "TbTo";
            this.TbTo.Size = new System.Drawing.Size(250, 21);
            this.TbTo.TabIndex = 11;
            // 
            // TbIDTrip
            // 
            this.TbIDTrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbIDTrip.Enabled = false;
            this.TbIDTrip.Location = new System.Drawing.Point(146, 167);
            this.TbIDTrip.Margin = new System.Windows.Forms.Padding(0);
            this.TbIDTrip.Name = "TbIDTrip";
            this.TbIDTrip.Size = new System.Drawing.Size(180, 21);
            this.TbIDTrip.TabIndex = 12;
            // 
            // TbIDTicket
            // 
            this.TbIDTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbIDTicket.Enabled = false;
            this.TbIDTicket.Location = new System.Drawing.Point(146, 264);
            this.TbIDTicket.Margin = new System.Windows.Forms.Padding(0);
            this.TbIDTicket.Name = "TbIDTicket";
            this.TbIDTicket.Size = new System.Drawing.Size(180, 21);
            this.TbIDTicket.TabIndex = 13;
            // 
            // TbDistance
            // 
            this.TbDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbDistance.Enabled = false;
            this.TbDistance.Location = new System.Drawing.Point(467, 264);
            this.TbDistance.Margin = new System.Windows.Forms.Padding(0);
            this.TbDistance.Name = "TbDistance";
            this.TbDistance.Size = new System.Drawing.Size(150, 21);
            this.TbDistance.TabIndex = 15;
            // 
            // TbFare
            // 
            this.TbFare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbFare.Enabled = false;
            this.TbFare.Location = new System.Drawing.Point(467, 167);
            this.TbFare.Margin = new System.Windows.Forms.Padding(0);
            this.TbFare.Name = "TbFare";
            this.TbFare.Size = new System.Drawing.Size(150, 21);
            this.TbFare.TabIndex = 14;
            // 
            // TbDuration
            // 
            this.TbDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbDuration.Enabled = false;
            this.TbDuration.Location = new System.Drawing.Point(777, 264);
            this.TbDuration.Margin = new System.Windows.Forms.Padding(0);
            this.TbDuration.Name = "TbDuration";
            this.TbDuration.Size = new System.Drawing.Size(121, 21);
            this.TbDuration.TabIndex = 17;
            // 
            // CbBookedSeat
            // 
            this.CbBookedSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBookedSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbBookedSeat.FormattingEnabled = true;
            this.CbBookedSeat.Location = new System.Drawing.Point(777, 159);
            this.CbBookedSeat.Name = "CbBookedSeat";
            this.CbBookedSeat.Size = new System.Drawing.Size(121, 29);
            this.CbBookedSeat.TabIndex = 18;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.PnlMainContainer);
            this.Font = new System.Drawing.Font("Hack NF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.PnlMainContainer.ResumeLayout(false);
            this.GbTravelInfor.ResumeLayout(false);
            this.GbTravelInfor.PerformLayout();
            this.GbUserInfor.ResumeLayout(false);
            this.GbUserInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainContainer;
        private System.Windows.Forms.GroupBox GbTravelInfor;
        private System.Windows.Forms.GroupBox GbUserInfor;
        private System.Windows.Forms.MaskedTextBox MtbPhone;
        private System.Windows.Forms.Label LbPhone;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LbTrip;
        private System.Windows.Forms.Label LbTicket;
        private System.Windows.Forms.Label LbBookedSeat;
        private System.Windows.Forms.Label LbFare;
        private System.Windows.Forms.Label LbDuration;
        private System.Windows.Forms.Label LbDistance;
        private System.Windows.Forms.Label LbTo;
        private System.Windows.Forms.Label LbFrom;
        private System.Windows.Forms.TextBox TbFrom;
        private System.Windows.Forms.TextBox TbTo;
        private System.Windows.Forms.TextBox TbIDTrip;
        private System.Windows.Forms.TextBox TbIDTicket;
        private System.Windows.Forms.TextBox TbDistance;
        private System.Windows.Forms.TextBox TbFare;
        private System.Windows.Forms.TextBox TbDuration;
        private System.Windows.Forms.ComboBox CbBookedSeat;
    }
}