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
    class Turbine
    {
        public DataTable dtTb = new DataTable();
        const string filePath = "Doosan_WinDS3000.txt";
        public double maxPower;
        public void SelectModel()
        {
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            dtTb.Columns.Add(new DataColumn("V", typeof(double)));
            dtTb.Columns.Add(new DataColumn("P", typeof(double)));
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
                    dr["V"] = double.Parse(oneline[0]);
                    dr["P"] = double.Parse(oneline[1]);
                    if (mp< double.Parse(oneline[1]))
                    {
                        mp = double.Parse(oneline[1]);
                    }
                    sr.Read();
                    dtTb.Rows.Add(dr);
                }
            }
            maxPower = mp;
        }

    }
}
