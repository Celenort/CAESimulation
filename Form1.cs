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
        public string metoceanfiledir;
        public string energyfiledir;
        public string tempInitialDir = "C:\\Users\\hyung\\source\\repos\\Celenort\\CAESimulation\\bin\\Debug";



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
                    input_dirtxtbox1.Text = filePath;
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
                    input_dirtxtbox2.Text = filePath;
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
                    input_dirtxtbox3.Text = filePath;
                    metoceanfiledir = filePath;
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
                    input_dirtxtbox4.Text = filePath;
                    energyfiledir = filePath;
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (input_checkbox1.Checked)
            {
                input_dirtxtbox1.Enabled = true;
                input_browse1.Enabled = true;
            }
            else
            {
                input_dirtxtbox1.Enabled = false;
                input_browse1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (input_checkbox2.Checked)
            {
                input_dirtxtbox2.Enabled = true;
                input_browse2.Enabled = true;
            }
            else
            {
                input_dirtxtbox2.Enabled = false;
                input_browse2.Enabled = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (input_checkbox3.Checked)
            {
                input_dirtxtbox3.Enabled = true;
                input_browse3.Enabled = true;
            }
            else
            {
                input_dirtxtbox3.Enabled = false;
                input_browse3.Enabled = false;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (input_checkbox4.Checked)
            {
                input_dirtxtbox4.Enabled = true;
                input_browse4.Enabled = true;
            }
            else
            {
                input_dirtxtbox4.Enabled = false;
                input_browse4.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            input_monthCalendar1.SelectionStart = input_dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            input_monthCalendar2.SelectionStart = input_dateTimePicker1.Value;
        }

    }
}
