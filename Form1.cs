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

namespace CAESimulation
{
    public partial class CAESimulation : Form
    {
        public CAESimulation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input ip = new Input();
            ip.LoadWind();
            ip.LoadPower();
            Turbine tb = new Turbine();
            tb.SelectModel();
            Calculation cc = new Calculation();
            cc.LoadDataTable(ip, tb);
            cc.ConvertGlobalToLocalUsage();
            DataTable dt = cc.VelocityToPower(ip.dtWind, tb.dtTb);
            cc.MergePwrgen();
            Theory th = new Theory(cc);
            th.ApplyTheory();
            dataGridView1.DataSource = Theory.dtTheory;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myModel = new PlotModel { Title = "Example 1" };
            var lineSeries = new LineSeries();
            getGZ(ref lineSeries);
            myModel.Series.Add(lineSeries);
            this.plotView1.Model = myModel;
        }
        private void getGZ(ref LineSeries a)
        {
            List<double> gzvals = ParseDT();
            if (gzvals == null)
            {
                MessageBox.Show("BargeShip을 생성하고 평형자세를 계산한 후에 GZ Curve를 구할 수 있습니다.", "NAC Term Project 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            double i = 0;
            foreach (double item in gzvals)
            {
                a.Points.Add(new DataPoint(i, item));
                i ++; // i : 1 hour
            }
        }
        private List<double> ParseDT()
        {
            object[] arrObj = Theory.dtTheory.Select().Select(x => x["SurplusElec"]).ToArray();
            double[] arrDouble = arrObj.Cast<double>().ToArray();
            List<double> arrList = arrDouble.ToList<double>();
            return arrList;
        }
    }
}
