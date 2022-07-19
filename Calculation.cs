using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text;

namespace CAESimulation
{
    class Calculation
    {
        public DataTable dtWind;
        public DataTable dtPower;
        public DataTable dtTb;
        public DataTable dtPwrGen;
        public void LoadDataTable(Input ip, Turbine tb)
        {
            dtWind = ip.dtWind;
            dtPower = ip.dtPower;
            dtTb = tb.dtTb; // Load Infors from Tb, ip class
        }
        public static string DissectDateTime(string date) // 0 to 23
        {
            string result = String.Copy(date);


            char[] dateAsChar = date.ToCharArray();

            dateAsChar[11] = '0';
            dateAsChar[12] = '0';

            string newDate = new string(dateAsChar);
            DateTime dtTime = DateTime.ParseExact(newDate, "yyyy-MM-ddTHH:mm:ss",
                                            System.Globalization.CultureInfo.InvariantCulture);
            dtTime = dtTime.AddDays(1);

            return(dtTime.ToString("yyyy-MM-ddTHH:mm:ss"));
        }

//        public void 
    }
}
