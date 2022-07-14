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
    class Input
    {
        public DataTable dtWind = new DataTable();
        const string filePath = "ERA_5_Lat33.500000_Long126.000000_100m.txt";
        public void LoadFiles() // Loading files, Temporary
        {
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            dtWind.Columns.Add(new DataColumn("Date", typeof(string)));
            dtWind.Columns.Add(new DataColumn("Speed", typeof(double)));
            dtWind.Columns.Add(new DataColumn("Direction", typeof(double)));
            dtWind.Columns.Add(new DataColumn("Temperature", typeof(double)));
            dtWind.Columns.Add(new DataColumn("Pressure", typeof(double)));

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
    }
}
