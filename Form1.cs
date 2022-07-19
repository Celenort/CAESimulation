﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataTable dt = cc.VelocityToPower(ip.dtWind, tb.dtTb);

            dataGridView1.DataSource = dt;
        }
    }
}
