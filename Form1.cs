using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using OxyPlot.Axes;
using System.IO;

namespace CAESimulation
{
    public partial class CAESimulation : Form
    {
        public int times = 0;
        public CAESimulation()
        {
            InitializeComponent();
        }

        public string windfiledir;
        public static string turbinefiledir;
        public string metoceanfiledir;
        public string energyfiledir;
        public string tempInitialDir = "C:\\Users\\hyung\\source\\repos\\Celenort\\CAESimulation\\bin\\Debug";
        private static string libturbinefilepath = "Wind Turbines.csv";
        public static DateTime datestrt;
        public static DateTime dateend;
        public static DataTable turbines;


        private void rst_loadGraph_Click(object sender, EventArgs e)
        {
            object[] arrObjspeed = dtCombined.Select().Select(x => x["Speed"]).ToArray();
            object[] arrObjpower = dtCombined.Select().Select(x => x["Power"]).ToArray();
            object[] arrObjsigwave = dtCombined.Select().Select(x => x["SigWave"]).ToArray();

            var myModel = new PlotModel { Title = "Wind Veolcity" };
            var lineSeries = new LineSeries();
            double[] arrDouble = arrObjspeed.Cast<double>().ToArray();
            List<double> arrList = arrDouble.ToList<double>();
            if (arrList == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double i = 0;
            foreach (double item in arrList)
            {
                lineSeries.Points.Add(new DataPoint(i, item));
                i++; // i : 1 hour
                times = int.Parse(i.ToString());
            }
            myModel.Series.Add(lineSeries);
            DateTimeAxis xAxis = new DateTimeAxis();
            xAxis.Position = AxisPosition.Bottom;
            xAxis.IsZoomEnabled = false;

            //Define the y axis
            LinearAxis yAxis = new LinearAxis();
            yAxis.Position = AxisPosition.Left;
            //Disable the axis zoom
            yAxis.IsZoomEnabled = false;

            //Add the Axes to the graph
            myModel.Axes.Add(xAxis);
            myModel.Axes.Add(yAxis);
            this.rst_windvel.Model = myModel;

            var myModel2 = new PlotModel { Title = "Power Used" };
            var lineSeries2 = new LineSeries();
            double[] arrDouble2 = arrObjpower.Cast<double>().ToArray();
            List<double> arrList2 = arrDouble2.ToList<double>();
            if (arrList2 == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double j = 0;
            foreach (double item in arrList2)
            {
                lineSeries2.Points.Add(new DataPoint(j, item));
                j++; // i : 1 hour
            }
            myModel2.Series.Add(lineSeries2);
            DateTimeAxis xAxis2 = new DateTimeAxis();
            xAxis2.Position = AxisPosition.Bottom;
            xAxis2.IsZoomEnabled = false;

            //Define the y axis
            LinearAxis yAxis2 = new LinearAxis();
            yAxis2.Position = AxisPosition.Left;
            //Disable the axis zoom
            yAxis2.IsZoomEnabled = false;
            //Add the Axes to the graph
            myModel2.Axes.Add(xAxis2);
            myModel2.Axes.Add(yAxis2);
            this.rst_elec.Model = myModel2;


            var myModel3 = new PlotModel { Title = "Power Generated" };
            var lineSeries3 = new LineSeries();
            double[] arrDouble3 = arrObjsigwave.Cast<double>().ToArray();
            List<double> arrList3 = arrDouble3.ToList<double>();
            if (arrList3 == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double k = 0;
            foreach (double item in arrList3)
            {
                lineSeries3.Points.Add(new DataPoint(k, item));
                k++; // i : 1 hour
            }
            myModel3.Series.Add(lineSeries3);
            DateTimeAxis xAxis3 = new DateTimeAxis();
            xAxis3.Position = AxisPosition.Bottom;
            xAxis3.IsZoomEnabled = false;

            //Define the y axis
            LinearAxis yAxis3 = new LinearAxis();
            yAxis3.Position = AxisPosition.Left;
            //Disable the axis zoom
            yAxis3.IsZoomEnabled = false;
            //Add the Axes to the graph
            myModel3.Axes.Add(xAxis3);
            myModel3.Axes.Add(yAxis3);
            this.rst_wavemax.Model = myModel3;


            Theory th = new Theory(dtCombined);
            th.ConvertGlobalToLocalUsage(dtCombined);
            th.VelocityToPower(ref dtCombined, dtTb);
            th.MergePwrgen(dtCombined, dtPower);
            th.ApplyTheory();
            object[] arrObj = Theory.dtTheory.Select().Select(x => x["SurplusElec"]).ToArray();
            var myModel4 = new PlotModel { Title = "Surplus" };
            var lineSeries4 = new LineSeries();
            double[] arrDouble4 = arrObj.Cast<double>().ToArray();
            List<double> arrList4 = arrDouble4.ToList<double>();
            if (arrList4 == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double l = 0;
            foreach (double item in arrList4)
            {
                lineSeries4.Points.Add(new DataPoint(l, item));
                l++; // i : 1 hour
            }
            myModel4.Series.Add(lineSeries4);
            DateTimeAxis xAxis4 = new DateTimeAxis();
            xAxis4.Position = AxisPosition.Bottom;
            xAxis4.IsZoomEnabled = false;

            //Define the y axis
            LinearAxis yAxis4 = new LinearAxis();
            yAxis4.Position = AxisPosition.Left;
            //Disable the axis zoom
            yAxis4.IsZoomEnabled = false;
            //Add the Axes to the graph
            myModel4.Axes.Add(xAxis4);
            myModel4.Axes.Add(yAxis4);
            this.rst_pwrgen.Model = myModel4;




            textBox1.Text = Math.Round(Theory.totalPowerGen, 3).ToString();
            textBox2.Text = Math.Round(Theory.totalPwrGen, 3).ToString();
            textBox3.Text = Math.Round((Theory.totalPwrGen / times), 3).ToString();
        }
    }
}
