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
    public partial class CAESimulation : Form
    {
        public static DataTable dtWind;
        public static DataTable dtPower;
        public static DataTable dtOcean;
        public static DataTable dtElec;
        public static DataTable dtTb;
        public static DataTable dtCombined; // 결국은 Input data로 이걸 사용하게 됨.
        public static DateTime datemin;
        public static DateTime datemax;
        public static int time;
        private void input_apply_Click(object sender, EventArgs e)
        {
            //Todo : Delete bttn1

            Input ip = new Input(windfiledir, metoceanfiledir, energyfiledir);
            ip.LoadWind();
            dtWind = ip.dtWind;
            ip.LoadPower();
            dtPower = ip.dtPower;
            ip.LoadMetOcean();
            dtOcean = ip.dtOcean;
            dtCombined=MergeDatas(dtWind, dtPower, dtOcean);
            groupBox2.Visible = true;
            string startDate = dtCombined.Rows[0]["Date"].ToString();
            string endDate = dtCombined.Rows[dtCombined.Rows.Count - 1]["Date"].ToString();
            DateTime dt1 = DateTime.ParseExact(startDate, "yyyy-MM-ddTHH:mm:ss",
                                System.Globalization.CultureInfo.InvariantCulture);
            datemin = dt1;
            DateTime dt2 = DateTime.ParseExact(endDate, "yyyy-MM-ddTHH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture);
            datemax = dt2;
            input_dateTimePicker1.Value = dt1;
            input_dateTimePicker2.Value = dt2;


            //Turbine tb = new Turbine(turbinefiledir);
            //tb.SelectModel();
            //dtTb = tb.dtTb;
            //Calculation cc = new Calculation();
            //cc.LoadDataTable(ip, tb);
            //cc.ConvertGlobalToLocalUsage();
            //DataTable dt2 = cc.VelocityToPower(ip.dtWind, tb.dtTb);
            //cc.MergePwrgen();
            //Theory th = new Theory(cc);
            //th.ApplyTheory();
        }

        private void input_preview_Click(object sender, EventArgs e)
        {
            string datestrt = input_dateTimePicker1.Value.ToString("s");
            string dateend = input_dateTimePicker2.Value.ToString("s");
            DataRow drstrt = dtCombined.Rows.Find(datestrt);
            DataRow drend = dtCombined.Rows.Find(dateend);
            int idxstrt = dtCombined.Rows.IndexOf(drstrt);
            int idxend = dtCombined.Rows.IndexOf(drend);
            DataTable result = dtCombined.Clone();
            for (int i = idxstrt;i<=idxend;i++)
            {
                result.ImportRow(dtCombined.Rows[i]);
            }
            input_previewdatagridview.DataSource = result;
        }
        private void input_buttonfinalaply_Click(object sender, EventArgs e)
        {
            string datestrt = input_dateTimePicker1.Value.ToString("s");
            string dateend = input_dateTimePicker2.Value.ToString("s");
            DataRow drstrt = dtCombined.Rows.Find(datestrt);
            DataRow drend = dtCombined.Rows.Find(dateend);
            int idxstrt = dtCombined.Rows.IndexOf(drstrt);
            int idxend = dtCombined.Rows.IndexOf(drend);
            DataTable result = dtCombined.Clone();
            for (int i = idxstrt; i <= idxend; i++)
            {
                result.ImportRow(dtCombined.Rows[i]);
            }
            dtCombined = result;
        }
        public DataTable MergeDatas(DataTable dtWind, DataTable dtPower, DataTable dtOcean)
        {
            DataTable result = dtWind.Copy();
            result.Columns.Add(new DataColumn("Power", typeof(double))); // PWR
            result.Columns.Add(new DataColumn("SeaWaterTemp", typeof(double))); //Ocean
            result.Columns.Add(new DataColumn("MaxWave", typeof(double)));
            result.Columns.Add(new DataColumn("SigWave", typeof(double)));
            result.Columns.Add(new DataColumn("AvgWave", typeof(double)));
            result.Columns.Add(new DataColumn("WavePeriod", typeof(double)));

            foreach (DataRow dr in result.Rows)
            {
                object date = dr["Date"];
                DataRow powerRow = dtPower.Rows.Find(date);
                DataRow waveRow = dtOcean.Rows.Find(date);

                if (powerRow != null)
                {
                    dr["Power"] = powerRow["Power"];
                }
                else
                {
                    dr["Power"] = -1;
                }
                if (waveRow != null)
                {
                    dr["SeaWaterTemp"] = waveRow["SeaWaterTemp"];
                    dr["MaxWave"] = waveRow["MaxWave"];
                    dr["SigWave"] = waveRow["SigWave"];
                    dr["AvgWave"] = waveRow["AvgWave"];
                    dr["WavePeriod"] = waveRow["WavePeriod"];
                } else
                {
                    dr["SeaWaterTemp"] = -100;
                    dr["MaxWave"] = -1;
                    dr["SigWave"] = -1;
                    dr["AvgWave"] = -1;
                    dr["WavePeriod"] = -1;
                }
            }
            return result;
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
            if (DateTime.Compare(input_dateTimePicker1.Value, datemin) < 0 || DateTime.Compare(input_dateTimePicker1.Value, datemax) > 0)
            {
                MessageBox.Show("Selected date is not included in the data");
                input_dateTimePicker1.Value = datemin;
            }
            else if (DateTime.Compare(input_dateTimePicker1.Value, input_dateTimePicker2.Value) > 0)
            {
                MessageBox.Show("Selected date cannot be later than the End date");
                input_dateTimePicker1.Value = datemin;
            }
            input_monthCalendar1.SelectionStart = input_dateTimePicker1.Value;
            datestrt = input_dateTimePicker1.Value;
            input_fromtxtbox.Text = Math.Round((dateend - datestrt).TotalDays, 0).ToString();
            input_totxtbox.Text = (dateend - datestrt).TotalHours.ToString();
            time = int.Parse((dateend - datestrt).TotalHours.ToString());

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(input_dateTimePicker2.Value, datemin) < 0 || DateTime.Compare(input_dateTimePicker2.Value, datemax) > 0)
            {
                MessageBox.Show("Selected date is not included in the data");
                input_dateTimePicker2.Value = datemax;
            }
            else if (DateTime.Compare(input_dateTimePicker1.Value, input_dateTimePicker2.Value) > 0)
            {
                MessageBox.Show("Selected date cannot be later than the End date");
                input_dateTimePicker2.Value = datemax;
            }
            input_monthCalendar2.SelectionStart = input_dateTimePicker1.Value;
            dateend = input_dateTimePicker2.Value;
            input_fromtxtbox.Text = Math.Round((dateend - datestrt).TotalDays, 0).ToString();
            input_totxtbox.Text = (dateend - datestrt).TotalHours.ToString();

        }


    }


    class Input
    {
        public DataTable dtWind = new DataTable();
        public DataTable dtPower = new DataTable();
        public DataTable dtOcean = new DataTable();
        Dictionary<int, string> hourdict;
        public string filePathWind = "ERA_5_Lat33.500000_Long126.000000_100m.txt";
        public string filePathPower = "한국전력거래소_시간별 전력수요량_20211231.csv";
        public string filePathOcean = "MARINE_CWBUOY_22464_HR_2021_2021_2022.csv";

        public Input(string wind, string ocean, string energy)
        {
            filePathWind = wind;
            filePathPower = energy;
            filePathOcean = ocean;

            hourdict = new Dictionary<int, string>();
            for (int i =0;i<25;i++)
            {
                if (i<10)
                {
                    hourdict.Add(i, "0" + i.ToString());
                }
                //else if (i==24) // 이걸 바꾸는 순간 다음날로 Date를 이동시켜야하는 문제점 발생.
                //{
                //    hourdict.Add(i, "00");
                //}
                else
                {
                    hourdict.Add(i,i.ToString());
                }
            }
        }


        public void LoadWind() // Loading files, Temporary
        {
            StreamReader sr = new StreamReader(filePathWind);
            string line = "";
            dtWind.Columns.Add(new DataColumn("Date", typeof(string)));
            dtWind.Columns.Add(new DataColumn("Speed", typeof(double)));
            dtWind.Columns.Add(new DataColumn("Direction", typeof(double)));
            dtWind.Columns.Add(new DataColumn("Temperature", typeof(double)));
            dtWind.Columns.Add(new DataColumn("Pressure", typeof(double)));


            DataColumn[] dtkey = new DataColumn[1];
            dtkey[0] = dtWind.Columns["Date"];
            dtWind.PrimaryKey = dtkey;

            int i = 0;
            while (!sr.EndOfStream) {

                if (i<=12)
                {
                    line = sr.ReadLine();
                    i++;
                    continue;
                }
                else
                {
                    var sb = new StringBuilder();

                    DataRow dr = dtWind.NewRow();
                    string[] oneline = new string[5];
                    for(int j =0;j<5;j++)
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
                    dr["Date"] = oneline[0];
                    dr["Speed"] = double.Parse(oneline[1]);
                    dr["Direction"] = double.Parse(oneline[2]);
                    dr["Temperature"] = double.Parse(oneline[3]);
                    dr["Pressure"] = double.Parse(oneline[4]);
                    sr.Read();
                    dtWind.Rows.Add(dr);
                }
            }
        }
        public void LoadPower() // Loading files, Temporary
        {
            dtPower.Columns.Add(new DataColumn("Date", typeof(string)));
            dtPower.Columns.Add(new DataColumn("Power", typeof(double)));


            DataColumn[] dtkey = new DataColumn[1];
            dtkey[0] = dtPower.Columns["Date"];
            dtPower.PrimaryKey = dtkey;

            FileStream fs = File.OpenRead(filePathPower);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine(); // 1st line pass
            string[] sitems;
            while(!sr.EndOfStream)
            {
                s = sr.ReadLine();
                sitems = s.Split(',');
                string date = sitems[0];
                for (int i =1;i<25;i++)
                {
                    DataRow dr = dtPower.NewRow();
                    if (i==24)
                    {
                        dr["Date"] = DissectDateTime(date + "T" + hourdict[i] + ":00:00");
                        dr["Power"] = sitems[i];
                        dtPower.Rows.Add(dr);
                        break;
                    }
                    dr["Date"] = date + "T" + hourdict[i]+":00:00";
                    dr["Power"] = sitems[i];
                    dtPower.Rows.Add(dr);
                }
            }
            sr.Close();
            fs.Close();
        }
        public void LoadMetOcean() // Loading files, Temporary
        {
            dtOcean.Columns.Add(new DataColumn("Date", typeof(string)));
            dtOcean.Columns.Add(new DataColumn("SeaWaterTemp", typeof(double)));
            dtOcean.Columns.Add(new DataColumn("MaxWave", typeof(double)));
            dtOcean.Columns.Add(new DataColumn("SigWave", typeof(double)));
            dtOcean.Columns.Add(new DataColumn("AvgWave", typeof(double)));
            dtOcean.Columns.Add(new DataColumn("WavePeriod", typeof(double)));

            DataColumn[] dtkey = new DataColumn[1];
            dtkey[0] = dtOcean.Columns["Date"];
            dtOcean.PrimaryKey = dtkey;

            FileStream fs = File.OpenRead(filePathOcean);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine(); // 1st line pass
            string[] sitems;
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                sitems = s.Split(',');
                string datetime = DissectDateTime2(sitems[1]);
                DataRow dr = dtOcean.NewRow();
                if (sitems[2]=="")
                {
                    sitems[2] = "-100"; // Not measured
                }
                if (sitems[3]=="")
                {
                    continue;
                }
                dr["SeaWaterTemp"] = sitems[2];
                dr["MaxWave"] = sitems[3];
                dr["SigWave"] = sitems[4];
                dr["AvgWave"] = sitems[5];
                dr["WavePeriod"] = sitems[6];
                dr["Date"] = datetime; //Todo
                dtOcean.Rows.Add(dr);
            }
            sr.Close();
            fs.Close();
        }
        public string DissectDateTime(string date) // 0 to 23
            //used at LoadPower
        {
            char[] dateAsChar = date.ToCharArray();

            dateAsChar[11] = '0';
            dateAsChar[12] = '0'; // make "24" -> "00"

            string newDate = new string(dateAsChar);
            DateTime dtTime = DateTime.ParseExact(newDate, "yyyy-MM-ddTHH:mm:ss",
                                            System.Globalization.CultureInfo.InvariantCulture);
            dtTime = dtTime.AddDays(1);

            return (dtTime.ToString("yyyy-MM-ddTHH:mm:ss"));
        }
        public string DissectDateTime2(string date) // for metocean
        {
            string datetime = date.Substring(0, 10)+"T"+ date.Substring(11, 2)+":00:00";
            return datetime;
        }
    }
}
