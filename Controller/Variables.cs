using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaquinaEstacionamiento.Controller
{
    public class Variables
    {
        public static TimeSpan tDiference;
        public static DateTime tCheckInTime;
        public static DateTime tDepartureTime;
        public static DateTime tDiferenceTime;
        public static decimal toPay = 0.00m;
        public static decimal Change = 0.00m;
        public static string CheckInTime;
        public static string DepartureTime;
        public static string DiferenceTime;
        public static decimal amountOflPay = 0.00m;
        public static List<string> Data = new List<string>();

        public static Ticket Tmenu = new Ticket();
        public static PayMenu Pmenu = new PayMenu();
        public static Panel panel = new Panel();
        

        
    }
}

