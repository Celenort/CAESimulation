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
    class Loss
    {

        //wake losses(%단위)
        public static double inwake=0.00;
        public static double exwake =1.10;
        public static double ftwake =0.00;

        public double totalwakeloss = inwake + exwake + ftwake;

        //availability losses(%단위)
        public static double turbine =3.58;
        public static double plantbal =0.50;
        public static double grid =1.50;
        public double totalavloss = turbine + plantbal + grid;
        
        public static double suboptper = 1.10;
        public static double genericpower = 1.70;
        public static double sitespecpower = 0.81;
        public static double highwind = 0.40;
        public double totalturbineloss = suboptper + genericpower + sitespecpower + highwind;
        public static double icing = 0.21;
        public static double degradation = 1.80;
        public static double environmental = 0.40;
        public static double exposurechange = 0.00;
        public double totalenvloss = icing + degradation + environmental + exposurechange;

    }
}
