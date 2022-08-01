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
            for (i = 0; i < arrDouble.Length - 2; i++)
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



        public DataTable VelocityToPower(DataTable dtCombined, DataTable dtTb)
        {
            //Todo: Vel ->Pwr
            DataTable dtOutput = dtCombined.Copy();
            dtOutput.Columns.Add(new DataColumn("CvtPwr", typeof(double)));
            foreach (DataRow dr in dtOutput.Rows)
            {
                dr["CvtPwr"] = LinIntp(Double.Parse(dr["Speed"].ToString()), dtTb);
            }
            return dtOutput;
        }
        public DataTable ConvertGlobalToLocalUsage(DataTable dtCombined)
        {
            DataTable dtResult = dtCombined.Copy();

            foreach (DataRow dr in dtResult.Rows)
            {
                //dr["Power"] = Math.Round(Double.Parse(dr["Power"].ToString()) * pwrUsageProportion,3);
                double a = Double.Parse(dr["Power"].ToString()) * pwrUsageProportion / pwrUsageTotal;
                dr["Power"] = a;
                totalPowerGen += a;
            }
            return dtResult;
        }
        public DataTable SurplustoH2(DataTable dtCombined, double rate)
        {
            //Todo: Vel ->Pwr
            DataTable dtOutput = dtCombined.Copy();
            dtOutput.Columns.Add(new DataColumn("H2", typeof(double)));
            double totalamount = 0;
            foreach (DataRow dr in dtOutput.Rows)
            {
                totalamount += Double.Parse(dr["SurplusElec"].ToString());
                dr["H2"] =totalamount;
            }
            return dtOutput;
        }







        //Suppose that...
        // Converted power must exceed 0.5MWh otherwise -> Connect to local grid
        // if (true) {
        // if 0.1 pwrusage < pwrgen : then save 잉여전력 for pwrgen - 0.1pwrusage otherwise -> Connect to local grid
        public static double totalPwrGen=0;
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
        public DataTable ApplyTheory(DataTable dtCombined)
        {
            DataTable dtResult = dtCombined.Copy();
            dtResult.Columns.Add(new DataColumn("SurplusElec", typeof(double)));
            foreach (DataRow dr in dtResult.Rows)
            {

                double a = Theory1(Double.Parse(dr["CvtPwr"].ToString()), Double.Parse(dr["Power"].ToString()), 0.05, 0.1);
                dr["SurplusElec"] = a;
                totalPwrGen += a;
            }
            return dtResult;
        }
    }
}
