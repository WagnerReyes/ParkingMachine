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
    public partial class PayMenu : UserControl
    {
        public PayMenu()
        {
            InitializeComponent();
        }

        
        private void PayMenu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Functions.centerX(panelTopPay, lblMenuP);
            Functions.centerX(panelPay, lblOptions);
            rtbData.Clear();
            rtbData.SelectionAlignment = HorizontalAlignment.Center;
            foreach (string item in Variables.Data)
            {
                rtbData.AppendText($"{item}\n");
            }
            rtbData.AppendText("Increase the amount of payment with the pots on the sides");
            rtbData.AppendText($"\nCurrent Amount: {Variables.amountOflPay}");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Variables.amountOflPay += 01.00m;
            Functions.channgeAmount(rtbData);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Variables.amountOflPay += 05.00m;
            Functions.channgeAmount(rtbData);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Variables.amountOflPay += 10.00m;
            Functions.channgeAmount(rtbData);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Variables.amountOflPay += 20.00m;
            Functions.channgeAmount(rtbData);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            Variables.amountOflPay += 50.00m;
            Functions.channgeAmount(rtbData);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Variables.amountOflPay += 100.00m;
            Functions.channgeAmount(rtbData);
        }

        private void btnConfirmPay_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (Variables.amountOflPay == Variables.toPay)
            {
                MessageBox.Show("Payment made Succesfully");
                success = true;

            }
            else
            {
                if (Variables.amountOflPay > Variables.toPay)
                {
                    Variables.Change = Variables.amountOflPay - Variables.toPay;
                    MessageBox.Show($"Your Change Is:\n${Variables.Change}");
                    success = true;

                }
                if ((Variables.amountOflPay > Variables.toPay) == false)
                {
                    MessageBox.Show("Insufficient Amount\nCheck and Try Again");
                    success = false;

                }
            }
            if (success == true)
            {
                rtbData.Clear();
                rtbData.SelectionAlignment = HorizontalAlignment.Center;
                rtbData.AppendText("Thank you For\nVisiting Us\nHave a Good Trip");
                panelPay.BackColor = Color.YellowGreen;
                rtbData.BackColor = Color.YellowGreen;
                btnConfirmPay.Visible = false;
                panelLeft.Visible = false;
                panelRight.Visible = false;
                lblOptions.Visible = false;
            }

        }
    }
}
