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
        //Suppose that...
        // Converted power must exceed 0.5MWh otherwise -> Connect to local grid
        // if (true) {
        // if 0.1 pwrusage < pwrgen : then save 잉여전력 for pwrgen - 0.1pwrusage otherwise -> Connect to local grid
        public static DataTable dtTheory;
        public Theory(Calculation cc)
        {
            dtTheory = cc.dtPwrGen.Copy();
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

                dr["SurplusElec"] = Theory1(Double.Parse(dr["CvtPwr"].ToString()), Double.Parse(dr["PwrConsump"].ToString()), 0.05, 0.1);
            }
        }
    }
}
