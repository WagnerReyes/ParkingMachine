using MaquinaEstacionamiento.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaquinaEstacionamiento
{
  
    public partial class ParkingMachine : Form
    {
        public ParkingMachine()
        {
            InitializeComponent();
        }

        

        private void BtnRequestTicket_Click(object sender, EventArgs e)
        {
            Variables.tCheckInTime = DateTime.Now;
            Variables.CheckInTime = Variables.tCheckInTime.ToString("hh:mm tt");
            panelMain.Visible = false;
            this.Controls.Add(Variables.panel);
            Variables.panel.Dock = DockStyle.Fill;
            Variables.panel.BringToFront();
            Variables.panel.Controls.Add(Variables.Tmenu);
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
