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
    class Theory
    {
        public DataTable dtWind;
        public DataTable dtPower;
        public DataTable dtTb;
        public DataTable dtPwrGen;
        public static double totalPowerGen = 0;
        private int pwrUsageTotal = 558338404;
        private int pwrUsageProportion = 66000;

        public double LinIntp(double velo, DataTable dtTb)
        // Perform Linear Interpolation using Velocity-Power curve
        // Input : velocity (double), Turbine DataTable("V" -> "P")
        // Output : Interpolated (Estimation) Power at given vel.
        {
            object[] arrObj = dtTb.Select().Select(x => x["V"]).ToArray();
            double[] arrDouble = arrObj.Cast<double>().ToArray();

            int i;
            for (i = 0; i < arrDouble.Length - 1; i++)
            {
                if (arrDouble[i] <= velo && arrDouble[i + 1] >= velo)
                {
                    break;
                }
            }
            DataRow dr1 = dtTb.Rows.Find(arrDouble[i]);
            DataRow dr2 = dtTb.Rows.Find(arrDouble[i + 1]);
            double P1 = Double.Parse(dr1["P"].ToString());
            double P2 = Double.Parse(dr2["P"].ToString());

            double proportion = (velo - arrDouble[i]) / (arrDouble[i + 1] - arrDouble[i]);
            return Math.Round((proportion * P2 + (1 - proportion) * P1), 5);
        }

        public void VelocityToPower(ref DataTable dtWind, DataTable dtTb)
        {
            //Todo: Vel ->Pwr
            DataTable dtOutput = dtWind.Copy();
            dtOutput.Columns.Add(new DataColumn("CvtPwr", typeof(double)));
            foreach (DataRow dr in dtOutput.Rows)
            {
                dr["CvtPwr"] = LinIntp(Double.Parse(dr["Speed"].ToString()), dtTb);
            }
            dtWind = dtOutput.Copy();
        }
        public void ConvertGlobalToLocalUsage(DataTable dtPwr)
        {
            foreach (DataRow dr in dtPwr.Rows)
            {
                //dr["Power"] = Math.Round(Double.Parse(dr["Power"].ToString()) * pwrUsageProportion,3);
                double a = Double.Parse(dr["Power"].ToString()) * pwrUsageProportion / pwrUsageTotal;
                dr["Power"] = a;
                totalPowerGen += a;
            }
        }
        public void MergePwrgen(DataTable dtPwrGen2, DataTable dtPwr2)
        {
            dtPwrGen2.Columns.Add(new DataColumn("PwrConsump", typeof(double)));
            foreach (DataRow dr in dtPwrGen2.Rows)
            {
                object date = dr["Date"];
                DataRow powerRow = dtPwr2.Rows.Find(date);

                if (powerRow != null)
                {
                    dr["PwrConsump"] = powerRow["Power"];
                }
                else
                {
                    dr["PwrConsump"] = -1;
                }

            }
        }







        //Suppose that...
        // Converted power must exceed 0.5MWh otherwise -> Connect to local grid
        // if (true) {
        // if 0.1 pwrusage < pwrgen : then save 잉여전력 for pwrgen - 0.1pwrusage otherwise -> Connect to local grid
        public static DataTable dtTheory;
        public static double totalPwrGen=0;
        public Theory(DataTable dtCombined)
        {
            dtTheory = dtCombined.Copy();
        }
        public double Theory1(double pwrgen, double pwrconsump, double lowcut, double percentage)
        {
            if (pwrgen/1000 <= lowcut)
            {
                return 0;
            } else if (pwrgen/1000<=percentage * pwrconsump) //Pwrgen Unit : KWh
            {
                return 0;
            } else
            {
                return pwrconsump * percentage; //unit : MWh
            }
        }
        public void ApplyTheory()
        {
            dtTheory.Columns.Add(new DataColumn("SurplusElec", typeof(double)));
            foreach (DataRow dr in dtTheory.Rows)
            {
                if (Double.Parse(dr["PwrConsump"].ToString())==-1)
                {
                    dr["SurplusElec"] = 0;
                    continue;
                }

                double a = Theory1(Double.Parse(dr["CvtPwr"].ToString()), Double.Parse(dr["PwrConsump"].ToString()), 0.05, 0.1);
                dr["SurplusElec"] = a;
                totalPwrGen += a;
            }
        }
    }
}
