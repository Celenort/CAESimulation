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
            Init();
        }
        public void Init()
        {
            textBox4.Text = Loss.inwake.ToString();
            textBox5.Text = Loss.exwake.ToString();
            textBox9.Text = Loss.turbine.ToString();
            textBox8.Text = Loss.plantbal.ToString();
            textBox7.Text = Loss.grid.ToString();
            textBox12.Text = Loss.suboptper.ToString();
            textBox11.Text = Loss.genericpower.ToString();
            textBox10.Text = Loss.sitespecpower.ToString();
            textBox6.Text = Loss.highwind.ToString();
            textBox16.Text = Loss.icing.ToString();
            textBox15.Text = Loss.degradation.ToString();
            textBox14.Text = Loss.environmental.ToString();
            textBox13.Text = Loss.exposurechange.ToString();

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
            Theory th = new Theory();
            dtCombined = th.ConvertGlobalToLocalUsage(dtCombined);
            dtCombined = th.VelocityToPower(dtCombined, dtTb);
            dtCombined = th.ApplyTheory(dtCombined);
            dtCombined = th.SurplustoH2(dtCombined, 0.5);
            object[] arrObjspeed = dtCombined.Select().Select(x => x["Speed"]).ToArray();
            object[] arrObjH2 = dtCombined.Select().Select(x => x["H2"]).ToArray();
            object[] arrObjPwr = dtCombined.Select().Select(x => x["CvtPwr"]).ToArray();
            object[] arrObjsurplus = dtCombined.Select().Select(x => x["SurplusElec"]).ToArray();


            var myModel = new PlotModel ();
            var lineSeries = new LineSeries();
            double[] arrDouble = arrObjspeed.Cast<double>().ToArray();
            List<double> arrList = arrDouble.ToList<double>();
            if (arrList == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime mindate = datemin;
            foreach (double item in arrList)
            {
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(mindate), item));
                mindate = mindate.AddHours(1);
            }
            myModel.Series.Add(lineSeries);
            DateTimeAxis xAxis = new DateTimeAxis();
            xAxis.Position = AxisPosition.Bottom;
            xAxis.IsZoomEnabled = false;
            xAxis.Minimum = DateTimeAxis.ToDouble(datemin);
            xAxis.Maximum = DateTimeAxis.ToDouble(datemax);
            //Define the y axis
            LinearAxis yAxis = new LinearAxis();
            yAxis.Position = AxisPosition.Left;
            //Disable the axis zoom
            yAxis.IsZoomEnabled = false;
            yAxis.Title = "m/s";

            //Add the Axes to the graph
            myModel.Axes.Add(xAxis);
            myModel.Axes.Add(yAxis);
            this.rst_windvel.Model = myModel;

            var myModel2 = new PlotModel();
            var lineSeries2 = new LineSeries();
            double[] arrDouble2 = arrObjH2.Cast<double>().ToArray();
            List<double> arrList2 = arrDouble2.ToList<double>();
            if (arrList2 == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dt2 = datemin;
            foreach (double item in arrList2)
            {
                lineSeries2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt2), item));
                dt2 = dt2.AddHours(1);
            }
            myModel2.Series.Add(lineSeries2);
            DateTimeAxis xAxis2 = new DateTimeAxis();
            xAxis2.Position = AxisPosition.Bottom;
            xAxis2.IsZoomEnabled = false;
            xAxis2.Minimum = DateTimeAxis.ToDouble(datemin);
            xAxis2.Maximum = DateTimeAxis.ToDouble(datemax);
            //Define the y axis
            LinearAxis yAxis2 = new LinearAxis();
            yAxis2.Position = AxisPosition.Left;
            yAxis2.Title = "kg";
            //Disable the axis zoom
            yAxis2.IsZoomEnabled = false;
            //Add the Axes to the graph
            myModel2.Axes.Add(xAxis2);
            myModel2.Axes.Add(yAxis2);
            this.rst_elec.Model = myModel2;


            var myModel3 = new PlotModel();
            var lineSeries3 = new LineSeries();
            double[] arrDouble3 = arrObjsurplus.Cast<double>().ToArray();
            List<double> arrList3 = arrDouble3.ToList<double>();
            if (arrList3 == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime mindate2 = datemin;
            foreach (double item in arrList3)
            {
                lineSeries3.Points.Add(new DataPoint(DateTimeAxis.ToDouble(mindate2), item));
                mindate2 = mindate2.AddHours(1);
            }
            myModel3.Series.Add(lineSeries3);
            DateTimeAxis xAxis3 = new DateTimeAxis();
            xAxis3.Position = AxisPosition.Bottom;
            xAxis3.IsZoomEnabled = false;
            xAxis3.Minimum = DateTimeAxis.ToDouble(datemin);
            xAxis3.Maximum = DateTimeAxis.ToDouble(datemax);

            //Define the y axis
            LinearAxis yAxis3 = new LinearAxis();
            yAxis3.Position = AxisPosition.Left;
            //Disable the axis zoom
            yAxis3.IsZoomEnabled = false;
            yAxis3.Title = "kW";
            //Add the Axes to the graph
            myModel3.Axes.Add(xAxis3);
            myModel3.Axes.Add(yAxis3);
            this.rst_wavemax.Model = myModel3;



            var myModel4 = new PlotModel();
            var lineSeries4 = new LineSeries();
            double[] arrDouble4 = arrObjPwr.Cast<double>().ToArray();
            List<double> arrList4 = arrDouble4.ToList<double>();
            if (arrList4 == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dtt = datemin;
            foreach (double item in arrList4)
            {
                lineSeries4.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dtt), item));
                dtt = dtt.AddHours(1);
            }
            myModel4.Series.Add(lineSeries4);
            DateTimeAxis xAxis4 = new DateTimeAxis();
            xAxis4.Position = AxisPosition.Bottom;
            xAxis4.IsZoomEnabled = false;
            xAxis4.Minimum = DateTimeAxis.ToDouble(datemin);
            xAxis4.Maximum = DateTimeAxis.ToDouble(datemax);

            //Define the y axis
            LinearAxis yAxis4 = new LinearAxis();
            yAxis4.Position = AxisPosition.Left;
            //Disable the axis zoom
            yAxis4.IsZoomEnabled = false;
            yAxis4.Title = "kW";
            //Add the Axes to the graph
            myModel4.Axes.Add(xAxis4);
            myModel4.Axes.Add(yAxis4);
            this.rst_pwrgen.Model = myModel4;




            textBox1.Text = Math.Round(Theory.totalPowerGen, 3).ToString();
            textBox2.Text = Math.Round(Theory.totalPwrGen, 3).ToString();
            textBox3.Text = Math.Round((Theory.totalPwrGen / time), 3).ToString();
        }

        private void rst_dtl_Click(object sender, EventArgs e)
        {
            Resultdiag newform = new Resultdiag(dtCombined, dtTb);
            newform.ShowDialog();
        }


        private void mo_show_Click(object sender, EventArgs e)
        {
            object[] arrObj = dtCombined.Select().Select(x => x["SigWave"]).ToArray();

            var myModel2 = new PlotModel();
            var lineSeries2 = new LineSeries { Title = "Significant Wave"};
            double[] arrDouble2 = arrObj.Cast<double>().ToArray();
            List<double> arrList2 = arrDouble2.ToList<double>();
            if (arrList2 == null)
            {
                MessageBox.Show("No data loaded", "CAESimulation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dt2 = datemin;
            foreach (double item in arrList2)
            {
                lineSeries2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt2), item));
                dt2 = dt2.AddHours(1);
            }
            myModel2.Series.Add(lineSeries2);
            DateTimeAxis xAxis2 = new DateTimeAxis();
            xAxis2.Position = AxisPosition.Bottom;
            xAxis2.IsZoomEnabled = false;
            xAxis2.Minimum = DateTimeAxis.ToDouble(datemin);
            xAxis2.Maximum = DateTimeAxis.ToDouble(datemax);
            //Define the y axis
            LinearAxis yAxis2 = new LinearAxis();
            yAxis2.Position = AxisPosition.Left;
            yAxis2.Title = "m";
            //Disable the axis zoom
            yAxis2.IsZoomEnabled = false;
            //Add the Axes to the graph
            myModel2.Axes.Add(xAxis2);
            myModel2.Axes.Add(yAxis2);
            this.mo_wave.Model = myModel2;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
