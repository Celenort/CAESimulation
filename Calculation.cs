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

        public double LinIntp(double velo, DataTable dtTb)
            // Perform Linear Interpolation using Velocity-Power curve
            // Input : velocity (double), Turbine DataTable("V" -> "P")
            // Output : Interpolated (Estimation) Power at given vel.
        {
            object[] arrObj = dtTb.Select().Select(x => x["V"]).ToArray();
            double[] arrDouble = arrObj.Cast<double>().ToArray();

            int i;
            for (i =0;i<arrDouble.Length-1;i++)
            {
                if (arrDouble[i]<=velo && arrDouble[i+1]>=velo)
                {
                    break;
                }
            }
            DataRow dr1 = dtTb.Rows.Find(arrDouble[i]);
            DataRow dr2 = dtTb.Rows.Find(arrDouble[i+1]);
            double P1 = Double.Parse(dr1["P"].ToString());
            double P2 = Double.Parse(dr2["P"].ToString());

            double proportion = (velo - arrDouble[i]) / (arrDouble[i + 1] - arrDouble[i]);
            return (proportion * P2 + (1 - proportion) * P1);
        }

        public DataTable VelocityToPower(DataTable dtWind, DataTable dtTb)
        {
            //Todo: Vel ->Pwr

            return new DataTable();
        }
    }
}
