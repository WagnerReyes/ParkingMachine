using MaquinaEstacionamiento.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace MaquinaEstacionamiento
{
    
    public partial class Ticket : UserControl
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            lblCheckInTime.Text = $"{Variables.CheckInTime} Is Your Time Entry";
            Functions.centerXY(panelTicket, lblCheckInTime);

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            panelDepartureTime.Visible = true;
            Functions.centerXY(panelTicket, panelDepartureTime);
        }

        private void btnConfLeave_Click(object sender, EventArgs e)
        {
            string tt = cbxTime.Texts.Replace(".","");
            tt = tt.Replace(" ", "");

            Variables.DepartureTime = $"{txtHour.Text}:{txtMinutes.Text} {tt}";
            Variables.tDepartureTime = DateTime.Parse(Variables.DepartureTime);
            Variables.tDiference = Variables.tDepartureTime - Variables.tCheckInTime;
            Variables.DiferenceTime = $"{Variables.tDiference.Hours} Hours and {Variables.tDiference.Minutes} Minutes";

            Variables.toPay = Functions.Pay(Variables.tDiference);

            Variables.Data.Add($"Your Check In Time Is: {Variables.CheckInTime}");
            Variables.Data.Add($"Your Check Out Time Is: {Variables.DepartureTime}");
            Variables.Data.Add($"Your Time Of Stay Is: {Variables.DiferenceTime}");
            Variables.Data.Add($"Your Amounth To Pay Is Of: ${Variables.toPay}");

            Variables.Tmenu.Visible = false;
            Variables.panel.Controls.Add(Variables.Pmenu);
        }
    }
}
