
namespace CAESimulation
{
    partial class CAESimulation
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Files = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sourcebrowsebtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.turbinebrowsebtn = new System.Windows.Forms.Button();
            this.marinebrowsebtn = new System.Windows.Forms.Button();
            this.elecbrowsebtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.Turbine = new System.Windows.Forms.TabPage();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.Losses = new System.Windows.Forms.TabPage();
            this.Uncertainties = new System.Windows.Forms.TabPage();
            this.Tides = new System.Windows.Forms.TabPage();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            this.Result = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Files.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Turbine.SuspendLayout();
            this.Tides.SuspendLayout();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Files);
            this.TabControl.Controls.Add(this.Turbine);
            this.TabControl.Controls.Add(this.Losses);
            this.TabControl.Controls.Add(this.Uncertainties);
            this.TabControl.Controls.Add(this.Tides);
            this.TabControl.Controls.Add(this.Result);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.HotTrack = true;
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1010, 701);
            this.TabControl.TabIndex = 10;
            // 
            // Files
            // 
            this.Files.Controls.Add(this.groupBox2);
            this.Files.Controls.Add(this.groupBox1);
            this.Files.Location = new System.Drawing.Point(4, 25);
            this.Files.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Files.Name = "Files";
            this.Files.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Files.Size = new System.Drawing.Size(1002, 672);
            this.Files.TabIndex = 0;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(24, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(667, 352);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Select Date";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(127, 90);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "From-To";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Enabled = false;
            this.monthCalendar2.Location = new System.Drawing.Point(398, 90);
            this.monthCalendar2.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowToday = false;
            this.monthCalendar2.ShowTodayCircle = false;
            this.monthCalendar2.TabIndex = 13;
            this.monthCalendar2.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Calender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "End";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(398, 309);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(251, 25);
            this.textBox9.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 25);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(128, 309);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(245, 25);
            this.textBox8.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AllowDrop = true;
            this.dateTimePicker2.Location = new System.Drawing.Point(398, 49);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 25);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sourcebrowsebtn);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.turbinebrowsebtn);
            this.groupBox1.Controls.Add(this.marinebrowsebtn);
            this.groupBox1.Controls.Add(this.elecbrowsebtn);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(947, 217);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // sourcebrowsebtn
            // 
            this.sourcebrowsebtn.Enabled = false;
            this.sourcebrowsebtn.Location = new System.Drawing.Point(797, 25);
            this.sourcebrowsebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sourcebrowsebtn.Name = "sourcebrowsebtn";
            this.sourcebrowsebtn.Size = new System.Drawing.Size(86, 26);
            this.sourcebrowsebtn.TabIndex = 4;
            this.sourcebrowsebtn.Text = "Browse";
            this.sourcebrowsebtn.UseVisualStyleBackColor = true;
            this.sourcebrowsebtn.Click += new System.EventHandler(this.sourcebrowse_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(231, 25);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(554, 25);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(231, 59);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(554, 25);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(231, 92);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(554, 25);
            this.textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(231, 126);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(554, 25);
            this.textBox7.TabIndex = 3;
            // 
            // turbinebrowsebtn
            // 
            this.turbinebrowsebtn.Enabled = false;
            this.turbinebrowsebtn.Location = new System.Drawing.Point(797, 59);
            this.turbinebrowsebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turbinebrowsebtn.Name = "turbinebrowsebtn";
            this.turbinebrowsebtn.Size = new System.Drawing.Size(86, 26);
            this.turbinebrowsebtn.TabIndex = 5;
            this.turbinebrowsebtn.Text = "Browse";
            this.turbinebrowsebtn.UseVisualStyleBackColor = true;
            this.turbinebrowsebtn.Click += new System.EventHandler(this.turbinebrowsebtn_Click);
            // 
            // marinebrowsebtn
            // 
            this.marinebrowsebtn.Enabled = false;
            this.marinebrowsebtn.Location = new System.Drawing.Point(797, 92);
            this.marinebrowsebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marinebrowsebtn.Name = "marinebrowsebtn";
            this.marinebrowsebtn.Size = new System.Drawing.Size(86, 26);
            this.marinebrowsebtn.TabIndex = 6;
            this.marinebrowsebtn.Text = "Browse";
            this.marinebrowsebtn.UseVisualStyleBackColor = true;
            this.marinebrowsebtn.Click += new System.EventHandler(this.marinebrowsebtn_Click);
            // 
            // elecbrowsebtn
            // 
            this.elecbrowsebtn.Enabled = false;
            this.elecbrowsebtn.Location = new System.Drawing.Point(797, 126);
            this.elecbrowsebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elecbrowsebtn.Name = "elecbrowsebtn";
            this.elecbrowsebtn.Size = new System.Drawing.Size(86, 26);
            this.elecbrowsebtn.TabIndex = 7;
            this.elecbrowsebtn.Text = "Browse";
            this.elecbrowsebtn.UseVisualStyleBackColor = true;
            this.elecbrowsebtn.Click += new System.EventHandler(this.elecbrowsebtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 28);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Wind source file (*.txt)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 60);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(206, 19);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Custom turbine data (*.txt)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 94);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(153, 19);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Wave data (*.csv)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 128);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(177, 19);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Electricity data (*.csv)";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Turbine
            // 
            this.Turbine.Controls.Add(this.plotView2);
            this.Turbine.Location = new System.Drawing.Point(4, 25);
            this.Turbine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Turbine.Name = "Turbine";
            this.Turbine.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Turbine.Size = new System.Drawing.Size(1002, 672);
            this.Turbine.TabIndex = 1;
            this.Turbine.Text = "Turbine";
            this.Turbine.UseVisualStyleBackColor = true;
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(333, 24);
            this.plotView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(645, 362);
            this.plotView2.TabIndex = 0;
            this.plotView2.Text = "turbinecurve";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Losses
            // 
            this.Losses.Location = new System.Drawing.Point(4, 25);
            this.Losses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Losses.Name = "Losses";
            this.Losses.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Losses.Size = new System.Drawing.Size(1002, 672);
            this.Losses.TabIndex = 2;
            this.Losses.Text = "Losses";
            this.Losses.UseVisualStyleBackColor = true;
            // 
            // Uncertainties
            // 
            this.Uncertainties.Location = new System.Drawing.Point(4, 25);
            this.Uncertainties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Uncertainties.Name = "Uncertainties";
            this.Uncertainties.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Uncertainties.Size = new System.Drawing.Size(1002, 672);
            this.Uncertainties.TabIndex = 3;
            this.Uncertainties.Text = "Uncertainties";
            this.Uncertainties.UseVisualStyleBackColor = true;
            // 
            // Tides
            // 
            this.Tides.Controls.Add(this.plotView3);
            this.Tides.Location = new System.Drawing.Point(4, 25);
            this.Tides.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tides.Name = "Tides";
            this.Tides.Size = new System.Drawing.Size(1002, 672);
            this.Tides.TabIndex = 4;
            this.Tides.Text = "Tides";
            this.Tides.UseVisualStyleBackColor = true;
            // 
            // plotView3
            // 
            this.plotView3.Location = new System.Drawing.Point(9, 14);
            this.plotView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plotView3.Name = "plotView3";
            this.plotView3.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView3.Size = new System.Drawing.Size(983, 209);
            this.plotView3.TabIndex = 4;
            this.plotView3.Text = "tidepreview";
            this.plotView3.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView3.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView3.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Result
            // 
            this.Result.Controls.Add(this.label3);
            this.Result.Controls.Add(this.textBox3);
            this.Result.Controls.Add(this.textBox2);
            this.Result.Controls.Add(this.label2);
            this.Result.Controls.Add(this.button2);
            this.Result.Controls.Add(this.textBox1);
            this.Result.Controls.Add(this.label1);
            this.Result.Controls.Add(this.dataGridView1);
            this.Result.Controls.Add(this.plotView1);
            this.Result.Location = new System.Drawing.Point(4, 25);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1002, 672);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "시간당 평균 전력";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(810, 436);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(567, 438);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "H2 생산에 사용된 전력";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 438);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "LoadGraph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 438);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "총 전력생산량";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(983, 165);
            this.dataGridView1.TabIndex = 4;
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(9, 14);
            this.plotView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(983, 209);
            this.plotView1.TabIndex = 3;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "LoadData";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CAESimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 701);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CAESimulation";
            this.Text = "CAESimulation";
            this.TabControl.ResumeLayout(false);
            this.Files.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Turbine.ResumeLayout(false);
            this.Tides.ResumeLayout(false);
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.TabPage Turbine;
        private System.Windows.Forms.TabPage Losses;
        private System.Windows.Forms.TabPage Uncertainties;
        private System.Windows.Forms.TabPage Tides;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.Button elecbrowsebtn;
        private System.Windows.Forms.Button marinebrowsebtn;
        private System.Windows.Forms.Button turbinebrowsebtn;
        private System.Windows.Forms.Button sourcebrowsebtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

