using MaquinaEstacionamiento.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaquinaEstacionamiento
{
    
   
    public class Functions
    {

        public static void centerX(Control Father, Control Son)
        {
            int x = 0;
            x = (Father.Width / 2) - (Son.Width / 2);
            Son.Location = new System.Drawing.Point(x, Son.Location.Y);
        }

        public static void centerXY(Control Father, Control Son)
        {
            int x = 0;
            int y = 0;
            x = (Father.Width / 2) - (Son.Width / 2);
            y = (Father.Height / 2) - (Son.Height / 2);
            Son.Location = new System.Drawing.Point(x, y);
        }

        public static decimal Pay(TimeSpan hours)
        {
            decimal pay = 0;
            TimeSpan hours2 = TimeSpan.Parse("02:00");
            TimeSpan Minutes = TimeSpan.Parse("00:15");

            if( hours <= hours2)
            {
                pay += 20.00m;
                hours -= hours;
            }
            if(hours >= hours2)
            {
                pay += 20.00m;
                hours -= hours2;
            }
            while (hours > Minutes)
            {
                pay += 5.00m;
                hours = hours - Minutes;
            }

            return pay;
        }

        public static void channgeAmount(RichTextBox rtb)
        {
            rtb.Select(rtb.GetFirstCharIndexFromLine(6), rtb.GetFirstCharIndexFromLine(6));
            rtb.SelectedText = $"Current Amount: ${Variables.amountOflPay}";
        }
    }
}
