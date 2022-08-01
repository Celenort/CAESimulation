using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace CAESimulation
{
    public partial class CAESimulation : Form
    {
        private static bool isLibLoaded = false;
        private void tbn_radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (tbn_radio1.Checked)
            {
                if (!isLibLoaded)
                {
                    isLibLoaded = true;
                    LoadTurbineLib();
                    List<string> nameOfTurbines = new List<string>();
                    foreach (DataRow dr in turbines.Rows)
                    {
                        nameOfTurbines.Add(dr["Name"].ToString());
                    }
                    string[] strings = nameOfTurbines.ToArray();

                    comboBox1.Items.AddRange(strings);
                }
                groupBox5.Enabled = true;

            }
            else
            {
                groupBox5.Enabled = false;
            }
        }
        private void LoadTurbineLib()
        {
            DataTable turbineLib = new DataTable();
            turbineLib.Columns.Add(new DataColumn("Name", typeof(string)));
            turbineLib.Columns.Add(new DataColumn("KW Rating", typeof(double)));
            turbineLib.Columns.Add(new DataColumn("Rotor Diameter", typeof(double)));
            turbineLib.Columns.Add(new DataColumn("IEC Wind Speed Class", typeof(string)));
            turbineLib.Columns.Add(new DataColumn("Speed", typeof(double[])));
            turbineLib.Columns.Add(new DataColumn("Power", typeof(double[])));

            FileStream fs = File.OpenRead(libturbinefilepath);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine(); // 1st line pass
            s = sr.ReadLine(); // 1st line pass
            s = sr.ReadLine(); // 1st line pass // 3rd
            string[] sitems;
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                sitems = s.Split(',');
                DataRow dr = turbineLib.NewRow();

                dr["Name"] = sitems[0];
                dr["KW Rating"] = sitems[1];
                dr["Rotor Diameter"] = sitems[2];
                dr["IEC Wind Speed Class"] = sitems[3];
                double[] varray = Array.ConvertAll(sitems[4].Split('|'), Double.Parse);
                double[] parray = Array.ConvertAll(sitems[5].Split('|'), Double.Parse);
                dr["Speed"] = varray;
                dr["Power"] = parray;
                turbineLib.Rows.Add(dr);
            }
            sr.Close();
            fs.Close();
            turbines = turbineLib;
        }

        private void tbn_radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (tbn_radio2.Checked && turbinefiledir == null)
            {
                MessageBox.Show("Custom turbine file is not selected. Please Browse custom turbine file in Input tab.");
                tbn_radio2.Checked = false;
                return;
            }
            if (tbn_radio2.Checked)
            {
                Turbine tb = new Turbine(CAESimulation.turbinefiledir);
                tb.SelectModel();
                var myModel = new PlotModel { Title = "Custom Turbine" };
                var lineSeries = new LineSeries();
                double[] varrDouble = tb.varray;
                double[] parrDouble = tb.parray;
                for (int i = 0; i < varrDouble.Length; i++)
                {
                    lineSeries.Points.Add(new DataPoint(varrDouble[i], parrDouble[i]));
                }
                myModel.Series.Add(lineSeries);
                LinearAxis xAxis = new LinearAxis();
                xAxis.Position = AxisPosition.Bottom;
                xAxis.IsZoomEnabled = false;
                xAxis.Title = "Velocity(m/s)";

                //Define the y axis
                LinearAxis yAxis = new LinearAxis();
                yAxis.Position = AxisPosition.Left;
                //Disable the axis zoom
                yAxis.IsZoomEnabled = false;
                yAxis.Title = "Power(KW)";

                //Add the Axes to the graph
                myModel.Axes.Add(xAxis);
                myModel.Axes.Add(yAxis);
                this.plotView2.Model = myModel;
            }


        }
        private double[] varrdouble2;
        private double[] parrdouble2;
        private string tbname;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                var myModel = new PlotModel { Title = turbines.Rows[comboBox1.SelectedIndex]["Name"].ToString() };
                tbname = turbines.Rows[comboBox1.SelectedIndex]["Name"].ToString();
                var lineSeries = new LineSeries();
                double[] varrDouble = (double[])turbines.Rows[comboBox1.SelectedIndex]["Speed"];
                double[] parrDouble = (double[])turbines.Rows[comboBox1.SelectedIndex]["Power"];
                for (int i = 0; i < varrDouble.Length; i++)
                {
                    lineSeries.Points.Add(new DataPoint(varrDouble[i], parrDouble[i]));
                }
                myModel.Series.Add(lineSeries);
                LinearAxis xAxis = new LinearAxis();
                xAxis.Position = AxisPosition.Bottom;
                xAxis.IsZoomEnabled = false;
                xAxis.Title = "Velocity(m/s)";

                //Define the y axis
                LinearAxis yAxis = new LinearAxis();
                yAxis.Position = AxisPosition.Left;
                //Disable the axis zoom
                yAxis.IsZoomEnabled = false;
                yAxis.Title = "Power(KW)";

                //Add the Axes to the graph
                varrdouble2 = varrDouble;
                parrdouble2 = parrDouble;

                myModel.Axes.Add(xAxis);
                myModel.Axes.Add(yAxis);
                this.plotView2.Model = myModel;
                tbn_txtkw.Text = turbines.Rows[comboBox1.SelectedIndex]["KW Rating"].ToString();
                tbn_txtrd.Text = turbines.Rows[comboBox1.SelectedIndex]["Rotor Diameter"].ToString();
                tbn_txtiec.Text = turbines.Rows[comboBox1.SelectedIndex]["IEC Wind Speed Class"].ToString();
            }
        }
        private void tbn_selectbtn_Click(object sender, EventArgs e)
        {
            if (!tbn_radio1.Checked && !tbn_radio2.Checked)
            {
                MessageBox.Show("Please select turbine model to apply.");
                return;
            }
            if (tbn_radio1.Checked)
            {
                DataTable dttrb = new DataTable();
                dttrb.Columns.Add(new DataColumn("V", typeof(double)));
                dttrb.Columns.Add(new DataColumn("P", typeof(double)));
                DataColumn[] dtkey = new DataColumn[1];
                dtkey[0] = dttrb.Columns["V"];
                dttrb.PrimaryKey = dtkey;
                for (int i = 0;i<parrdouble2.Length;i++)
                {
                    DataRow dr = dttrb.NewRow();

                    dr["V"] = varrdouble2[i];
                    dr["P"] = parrdouble2[i];
                    dttrb.Rows.Add(dr);
                }
                dtTb = dttrb;


            } else if (tbn_radio2.Checked)
            {
                Turbine tb = new Turbine(turbinefiledir);
                tb.SelectModel();
                dtTb = tb.dtTb;
            }
        }
    }







    class Turbine
    {
        public Turbine(string turbinedir)
        {
            filePath = turbinedir;
        }

        public double[] varray = new double[100];
        public double[] parray = new double[100];

        public string filePath;
        public double maxPower;
        public DataTable dtTb = new DataTable();
        public void SelectModel()
        {
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            dtTb.Columns.Add(new DataColumn("V", typeof(double)));
            dtTb.Columns.Add(new DataColumn("P", typeof(double)));
            DataColumn[] dtkey = new DataColumn[1];
            dtkey[0] = dtTb.Columns["V"];
            dtTb.PrimaryKey = dtkey;
            int i = 0;
            double mp = 0;
            while (!sr.EndOfStream)
            {

                if (i <= 0)
                {
                    line = sr.ReadLine();
                    i++;
                    continue;
                }
                else
                {
                    var sb = new StringBuilder();
                    DataRow dr = dtTb.NewRow();

                    string[] oneline = new string[2];
                    for (int j = 0; j < 2; j++)
                    {
                        int onechar;
                        for (; ((onechar = sr.Read()) != 9);) //9 : Tab
                        {
                            if (onechar == '\r')
                            {
                                break;
                            }
                            sb.Append((char)onechar);
                        }
                        oneline[j] = sb.ToString();
                        sb.Clear();
                    }
                    varray[i]= double.Parse(oneline[0]);
                    parray[i] = double.Parse(oneline[1]);
                    dr["V"] = double.Parse(oneline[0]);
                    dr["P"] = double.Parse(oneline[1]);
                    if (mp< double.Parse(oneline[1]))
                    {
                        mp = double.Parse(oneline[1]);
                    }
                    sr.Read();
                    dtTb.Rows.Add(dr);
                    i++;
                }
            }
            maxPower = mp;
        }

    }
}
