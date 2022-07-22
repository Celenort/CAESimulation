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
        static double inwake=0.00;
        static double exwake =1.10;
        static double ftwake =0.00;
       
        
        double totalwakeloss = inwake + exwake + ftwake;


        //availability losses(%단위)
        static double turbine =3.58;
        static double plantbal =0.50;
        static double grid =1.50;


        double totalavloss = turbine + plantbal + grid;

        //electrical losses(%단위)
        static double efficiency = 1.91;
        static double parasitic = 0.10;
        
        double totalelecloss = efficiency + parasitic;

        //turbine performance losses(%단위)
        static double suboptper = 1.10;
        static double genericpower = 1.70;
        static double sitespecpower = 0.81;
        static double highwind = 0.40;

        double totalturbineloss = suboptper + genericpower + sitespecpower + highwind;

        //environmental losses(%단위)
        static double icing = 0.21;
        static double degradation = 1.80;
        static double environmental = 0.40;
        static double exposurechange = 0.00;

        double totalenvloss = icing + degradation + environmental + exposurechange;

        //curtailment/operational strategies losses(%단위)
        static double loadcurt = 0.99;
        static double gridcurt = 0.84;
        static double envpermitcurt = 1.00;
        static double operstr = 0.00;
        
        double totalcurtoperstrloss = loadcurt + gridcurt + envpermitcurt + operstr;


        

       

    }
}
