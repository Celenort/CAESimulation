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
        public string turbinefiledir;
        public string tidefiledir;
        public string energyfiledir;
        public string tempInitialDir = "C:\\Users\\hyung\\source\\repos\\Celenort\\CAESimulation\\bin\\Debug";

        private void button1_Click(object sender, EventArgs e)
        {
            //Todo : Delete bttn1

            Input ip = new Input(windfiledir, tidefiledir, energyfiledir);
            ip.LoadWind();
            ip.LoadPower();
            Turbine tb = new Turbine(turbinefiledir);
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
            textBox1.Text = Math.Round(Calculation.totalPowerGen,3).ToString();
            textBox2.Text = Math.Round(Theory.totalPwrGen,3).ToString();
            textBox3.Text = Math.Round((Theory.totalPwrGen / times),3).ToString();
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
                times = int.Parse(i.ToString());
            }
        }
        private List<double> ParseDT()
        {
            object[] arrObj = Theory.dtTheory.Select().Select(x => x["SurplusElec"]).ToArray();
            double[] arrDouble = arrObj.Cast<double>().ToArray();
            List<double> arrList = arrDouble.ToList<double>();
            return arrList;
        }



        private void sourcebrowse_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = tempInitialDir;
                openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    textBox4.Text = filePath;
                    windfiledir = filePath;
                }
            }

        }

        private void turbinebrowsebtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = tempInitialDir;
                openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    textBox5.Text = filePath;
                    turbinefiledir = filePath;
                }
            }
        }

        private void marinebrowsebtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = tempInitialDir;
                openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    textBox6.Text = filePath;
                    tidefiledir = filePath;
                }
            }
        }

        private void elecbrowsebtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = tempInitialDir;
                openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    textBox7.Text = filePath;
                    energyfiledir = filePath;
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Enabled = true;
                sourcebrowsebtn.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                sourcebrowsebtn.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox5.Enabled = true;
                turbinebrowsebtn.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                turbinebrowsebtn.Enabled = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox6.Enabled = true;
                marinebrowsebtn.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
                marinebrowsebtn.Enabled = false;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox7.Enabled = true;
                elecbrowsebtn.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                elecbrowsebtn.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar2.SelectionStart = dateTimePicker1.Value;
        }
    }
}
