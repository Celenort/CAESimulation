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
        private void input_apply_Click(object sender, EventArgs e)
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
        }

        private void input_preview_Click(object sender, EventArgs e)
        {
            input_previewdatagridview.DataSource = Theory.dtTheory;
        }
    }


    class Input
    {
        public DataTable dtWind = new DataTable();
        public DataTable dtPower = new DataTable();
        Dictionary<int, string> hourdict;
        public string filePathWind = "ERA_5_Lat33.500000_Long126.000000_100m.txt";
        public string filePathPower = "한국전력거래소_시간별 전력수요량_20211231.csv";

        public Input(string wind, string tide, string energy)
        {
            filePathWind = wind;
            filePathPower = energy;

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
                        dr["Date"] = Calculation.DissectDateTime(date + "T" + hourdict[i] + ":00:00");
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

    }
}
