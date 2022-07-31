
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
            this.Input = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.input_previewdatagridview = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.input_labelselectdate = new System.Windows.Forms.Label();
            this.input_monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.input_labelfromto = new System.Windows.Forms.Label();
            this.input_monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.input_labelcalender = new System.Windows.Forms.Label();
            this.input_labelstrt = new System.Windows.Forms.Label();
            this.input_labelend = new System.Windows.Forms.Label();
            this.input_totxtbox = new System.Windows.Forms.TextBox();
            this.input_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.input_fromtxtbox = new System.Windows.Forms.TextBox();
            this.input_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_preview = new System.Windows.Forms.Button();
            this.input_apply = new System.Windows.Forms.Button();
            this.input_browse1 = new System.Windows.Forms.Button();
            this.input_dirtxtbox1 = new System.Windows.Forms.TextBox();
            this.input_dirtxtbox2 = new System.Windows.Forms.TextBox();
            this.input_dirtxtbox3 = new System.Windows.Forms.TextBox();
            this.input_dirtxtbox4 = new System.Windows.Forms.TextBox();
            this.input_browse2 = new System.Windows.Forms.Button();
            this.input_browse3 = new System.Windows.Forms.Button();
            this.input_browse4 = new System.Windows.Forms.Button();
            this.input_checkbox1 = new System.Windows.Forms.CheckBox();
            this.input_checkbox2 = new System.Windows.Forms.CheckBox();
            this.input_checkbox3 = new System.Windows.Forms.CheckBox();
            this.input_checkbox4 = new System.Windows.Forms.CheckBox();
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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.TabControl.SuspendLayout();
            this.Input.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_previewdatagridview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Turbine.SuspendLayout();
            this.Tides.SuspendLayout();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Input);
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
            this.TabControl.Size = new System.Drawing.Size(1182, 753);
            this.TabControl.TabIndex = 10;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.groupBox3);
            this.Input.Controls.Add(this.groupBox2);
            this.Input.Controls.Add(this.groupBox1);
            this.Input.Location = new System.Drawing.Point(4, 25);
            this.Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input.Size = new System.Drawing.Size(1174, 724);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.input_previewdatagridview);
            this.groupBox3.Location = new System.Drawing.Point(663, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 652);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // input_previewdatagridview
            // 
            this.input_previewdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input_previewdatagridview.Location = new System.Drawing.Point(6, 19);
            this.input_previewdatagridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_previewdatagridview.Name = "input_previewdatagridview";
            this.input_previewdatagridview.RowHeadersWidth = 51;
            this.input_previewdatagridview.RowTemplate.Height = 23;
            this.input_previewdatagridview.Size = new System.Drawing.Size(497, 633);
            this.input_previewdatagridview.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.input_labelselectdate);
            this.groupBox2.Controls.Add(this.input_monthCalendar1);
            this.groupBox2.Controls.Add(this.input_labelfromto);
            this.groupBox2.Controls.Add(this.input_monthCalendar2);
            this.groupBox2.Controls.Add(this.input_labelcalender);
            this.groupBox2.Controls.Add(this.input_labelstrt);
            this.groupBox2.Controls.Add(this.input_labelend);
            this.groupBox2.Controls.Add(this.input_totxtbox);
            this.groupBox2.Controls.Add(this.input_dateTimePicker1);
            this.groupBox2.Controls.Add(this.input_fromtxtbox);
            this.groupBox2.Controls.Add(this.input_dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(9, 317);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(648, 352);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // input_labelselectdate
            // 
            this.input_labelselectdate.AutoSize = true;
            this.input_labelselectdate.Location = new System.Drawing.Point(13, 56);
            this.input_labelselectdate.Name = "input_labelselectdate";
            this.input_labelselectdate.Size = new System.Drawing.Size(83, 15);
            this.input_labelselectdate.TabIndex = 20;
            this.input_labelselectdate.Text = "Select Date";
            // 
            // input_monthCalendar1
            // 
            this.input_monthCalendar1.Enabled = false;
            this.input_monthCalendar1.Location = new System.Drawing.Point(102, 90);
            this.input_monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.input_monthCalendar1.MaxSelectionCount = 1;
            this.input_monthCalendar1.Name = "input_monthCalendar1";
            this.input_monthCalendar1.ShowToday = false;
            this.input_monthCalendar1.ShowTodayCircle = false;
            this.input_monthCalendar1.TabIndex = 12;
            this.input_monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // input_labelfromto
            // 
            this.input_labelfromto.AutoSize = true;
            this.input_labelfromto.Location = new System.Drawing.Point(13, 312);
            this.input_labelfromto.Name = "input_labelfromto";
            this.input_labelfromto.Size = new System.Drawing.Size(64, 15);
            this.input_labelfromto.TabIndex = 22;
            this.input_labelfromto.Text = "From-To";
            // 
            // input_monthCalendar2
            // 
            this.input_monthCalendar2.Enabled = false;
            this.input_monthCalendar2.Location = new System.Drawing.Point(373, 90);
            this.input_monthCalendar2.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.input_monthCalendar2.MaxSelectionCount = 1;
            this.input_monthCalendar2.Name = "input_monthCalendar2";
            this.input_monthCalendar2.ShowToday = false;
            this.input_monthCalendar2.ShowTodayCircle = false;
            this.input_monthCalendar2.TabIndex = 13;
            this.input_monthCalendar2.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // input_labelcalender
            // 
            this.input_labelcalender.AutoSize = true;
            this.input_labelcalender.Location = new System.Drawing.Point(13, 186);
            this.input_labelcalender.Name = "input_labelcalender";
            this.input_labelcalender.Size = new System.Drawing.Size(64, 15);
            this.input_labelcalender.TabIndex = 21;
            this.input_labelcalender.Text = "Calender";
            // 
            // input_labelstrt
            // 
            this.input_labelstrt.AutoSize = true;
            this.input_labelstrt.Location = new System.Drawing.Point(100, 22);
            this.input_labelstrt.Name = "input_labelstrt";
            this.input_labelstrt.Size = new System.Drawing.Size(37, 15);
            this.input_labelstrt.TabIndex = 14;
            this.input_labelstrt.Text = "Start";
            // 
            // input_labelend
            // 
            this.input_labelend.AutoSize = true;
            this.input_labelend.Location = new System.Drawing.Point(370, 22);
            this.input_labelend.Name = "input_labelend";
            this.input_labelend.Size = new System.Drawing.Size(32, 15);
            this.input_labelend.TabIndex = 15;
            this.input_labelend.Text = "End";
            // 
            // input_totxtbox
            // 
            this.input_totxtbox.Location = new System.Drawing.Point(373, 309);
            this.input_totxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_totxtbox.Name = "input_totxtbox";
            this.input_totxtbox.Size = new System.Drawing.Size(251, 25);
            this.input_totxtbox.TabIndex = 19;
            // 
            // input_dateTimePicker1
            // 
            this.input_dateTimePicker1.AllowDrop = true;
            this.input_dateTimePicker1.Location = new System.Drawing.Point(102, 49);
            this.input_dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_dateTimePicker1.Name = "input_dateTimePicker1";
            this.input_dateTimePicker1.Size = new System.Drawing.Size(247, 25);
            this.input_dateTimePicker1.TabIndex = 16;
            this.input_dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // input_fromtxtbox
            // 
            this.input_fromtxtbox.Location = new System.Drawing.Point(103, 309);
            this.input_fromtxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_fromtxtbox.Name = "input_fromtxtbox";
            this.input_fromtxtbox.Size = new System.Drawing.Size(245, 25);
            this.input_fromtxtbox.TabIndex = 18;
            // 
            // input_dateTimePicker2
            // 
            this.input_dateTimePicker2.AllowDrop = true;
            this.input_dateTimePicker2.Location = new System.Drawing.Point(373, 49);
            this.input_dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_dateTimePicker2.Name = "input_dateTimePicker2";
            this.input_dateTimePicker2.Size = new System.Drawing.Size(251, 25);
            this.input_dateTimePicker2.TabIndex = 17;
            this.input_dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_preview);
            this.groupBox1.Controls.Add(this.input_apply);
            this.groupBox1.Controls.Add(this.input_browse1);
            this.groupBox1.Controls.Add(this.input_dirtxtbox1);
            this.groupBox1.Controls.Add(this.input_dirtxtbox2);
            this.groupBox1.Controls.Add(this.input_dirtxtbox3);
            this.groupBox1.Controls.Add(this.input_dirtxtbox4);
            this.groupBox1.Controls.Add(this.input_browse2);
            this.groupBox1.Controls.Add(this.input_browse3);
            this.groupBox1.Controls.Add(this.input_browse4);
            this.groupBox1.Controls.Add(this.input_checkbox1);
            this.groupBox1.Controls.Add(this.input_checkbox2);
            this.groupBox1.Controls.Add(this.input_checkbox3);
            this.groupBox1.Controls.Add(this.input_checkbox4);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(639, 301);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // input_preview
            // 
            this.input_preview.Location = new System.Drawing.Point(518, 248);
            this.input_preview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_preview.Name = "input_preview";
            this.input_preview.Size = new System.Drawing.Size(86, 29);
            this.input_preview.TabIndex = 26;
            this.input_preview.Text = "Preview";
            this.input_preview.UseVisualStyleBackColor = true;
            this.input_preview.Click += new System.EventHandler(this.button3_Click);
            // 
            // input_apply
            // 
            this.input_apply.Location = new System.Drawing.Point(415, 248);
            this.input_apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_apply.Name = "input_apply";
            this.input_apply.Size = new System.Drawing.Size(91, 29);
            this.input_apply.TabIndex = 25;
            this.input_apply.Text = "Apply";
            this.input_apply.UseVisualStyleBackColor = true;
            this.input_apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_browse1
            // 
            this.input_browse1.Enabled = false;
            this.input_browse1.Location = new System.Drawing.Point(518, 25);
            this.input_browse1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_browse1.Name = "input_browse1";
            this.input_browse1.Size = new System.Drawing.Size(86, 26);
            this.input_browse1.TabIndex = 4;
            this.input_browse1.Text = "Browse";
            this.input_browse1.UseVisualStyleBackColor = true;
            this.input_browse1.Click += new System.EventHandler(this.sourcebrowse_Click);
            // 
            // input_dirtxtbox1
            // 
            this.input_dirtxtbox1.Enabled = false;
            this.input_dirtxtbox1.Location = new System.Drawing.Point(231, 25);
            this.input_dirtxtbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_dirtxtbox1.Name = "input_dirtxtbox1";
            this.input_dirtxtbox1.ReadOnly = true;
            this.input_dirtxtbox1.Size = new System.Drawing.Size(275, 25);
            this.input_dirtxtbox1.TabIndex = 0;
            // 
            // input_dirtxtbox2
            // 
            this.input_dirtxtbox2.Enabled = false;
            this.input_dirtxtbox2.Location = new System.Drawing.Point(231, 82);
            this.input_dirtxtbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_dirtxtbox2.Name = "input_dirtxtbox2";
            this.input_dirtxtbox2.ReadOnly = true;
            this.input_dirtxtbox2.Size = new System.Drawing.Size(275, 25);
            this.input_dirtxtbox2.TabIndex = 1;
            // 
            // input_dirtxtbox3
            // 
            this.input_dirtxtbox3.Enabled = false;
            this.input_dirtxtbox3.Location = new System.Drawing.Point(231, 141);
            this.input_dirtxtbox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_dirtxtbox3.Name = "input_dirtxtbox3";
            this.input_dirtxtbox3.ReadOnly = true;
            this.input_dirtxtbox3.Size = new System.Drawing.Size(275, 25);
            this.input_dirtxtbox3.TabIndex = 2;
            // 
            // input_dirtxtbox4
            // 
            this.input_dirtxtbox4.Enabled = false;
            this.input_dirtxtbox4.Location = new System.Drawing.Point(231, 202);
            this.input_dirtxtbox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_dirtxtbox4.Name = "input_dirtxtbox4";
            this.input_dirtxtbox4.ReadOnly = true;
            this.input_dirtxtbox4.Size = new System.Drawing.Size(275, 25);
            this.input_dirtxtbox4.TabIndex = 3;
            // 
            // input_browse2
            // 
            this.input_browse2.Enabled = false;
            this.input_browse2.Location = new System.Drawing.Point(518, 82);
            this.input_browse2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_browse2.Name = "input_browse2";
            this.input_browse2.Size = new System.Drawing.Size(86, 26);
            this.input_browse2.TabIndex = 5;
            this.input_browse2.Text = "Browse";
            this.input_browse2.UseVisualStyleBackColor = true;
            this.input_browse2.Click += new System.EventHandler(this.turbinebrowsebtn_Click);
            // 
            // input_browse3
            // 
            this.input_browse3.Enabled = false;
            this.input_browse3.Location = new System.Drawing.Point(518, 141);
            this.input_browse3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_browse3.Name = "input_browse3";
            this.input_browse3.Size = new System.Drawing.Size(86, 26);
            this.input_browse3.TabIndex = 6;
            this.input_browse3.Text = "Browse";
            this.input_browse3.UseVisualStyleBackColor = true;
            this.input_browse3.Click += new System.EventHandler(this.marinebrowsebtn_Click);
            // 
            // input_browse4
            // 
            this.input_browse4.Enabled = false;
            this.input_browse4.Location = new System.Drawing.Point(518, 202);
            this.input_browse4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_browse4.Name = "input_browse4";
            this.input_browse4.Size = new System.Drawing.Size(86, 26);
            this.input_browse4.TabIndex = 7;
            this.input_browse4.Text = "Browse";
            this.input_browse4.UseVisualStyleBackColor = true;
            this.input_browse4.Click += new System.EventHandler(this.elecbrowsebtn_Click);
            // 
            // input_checkbox1
            // 
            this.input_checkbox1.AutoSize = true;
            this.input_checkbox1.Location = new System.Drawing.Point(15, 28);
            this.input_checkbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_checkbox1.Name = "input_checkbox1";
            this.input_checkbox1.Size = new System.Drawing.Size(181, 19);
            this.input_checkbox1.TabIndex = 8;
            this.input_checkbox1.Text = "Wind source file (*.txt)";
            this.input_checkbox1.UseVisualStyleBackColor = true;
            this.input_checkbox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // input_checkbox2
            // 
            this.input_checkbox2.AutoSize = true;
            this.input_checkbox2.Location = new System.Drawing.Point(15, 83);
            this.input_checkbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_checkbox2.Name = "input_checkbox2";
            this.input_checkbox2.Size = new System.Drawing.Size(206, 19);
            this.input_checkbox2.TabIndex = 9;
            this.input_checkbox2.Text = "Custom turbine data (*.txt)";
            this.input_checkbox2.UseVisualStyleBackColor = true;
            this.input_checkbox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // input_checkbox3
            // 
            this.input_checkbox3.AutoSize = true;
            this.input_checkbox3.Location = new System.Drawing.Point(15, 141);
            this.input_checkbox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_checkbox3.Name = "input_checkbox3";
            this.input_checkbox3.Size = new System.Drawing.Size(153, 19);
            this.input_checkbox3.TabIndex = 10;
            this.input_checkbox3.Text = "Wave data (*.csv)";
            this.input_checkbox3.UseVisualStyleBackColor = true;
            this.input_checkbox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // input_checkbox4
            // 
            this.input_checkbox4.AutoSize = true;
            this.input_checkbox4.Location = new System.Drawing.Point(15, 204);
            this.input_checkbox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_checkbox4.Name = "input_checkbox4";
            this.input_checkbox4.Size = new System.Drawing.Size(177, 19);
            this.input_checkbox4.TabIndex = 11;
            this.input_checkbox4.Text = "Electricity data (*.csv)";
            this.input_checkbox4.UseVisualStyleBackColor = true;
            this.input_checkbox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Turbine
            // 
            this.Turbine.Controls.Add(this.plotView2);
            this.Turbine.Location = new System.Drawing.Point(4, 25);
            this.Turbine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Turbine.Name = "Turbine";
            this.Turbine.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Turbine.Size = new System.Drawing.Size(1174, 724);
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
            this.Losses.Size = new System.Drawing.Size(1174, 724);
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
            this.Uncertainties.Size = new System.Drawing.Size(1174, 724);
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
            this.Tides.Size = new System.Drawing.Size(1174, 724);
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
            this.Result.Controls.Add(this.plotView1);
            this.Result.Location = new System.Drawing.Point(4, 25);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1174, 724);
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
            // CAESimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CAESimulation";
            this.Text = "CAESimulation";
            this.TabControl.ResumeLayout(false);
            this.Input.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input_previewdatagridview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Turbine.ResumeLayout(false);
            this.Tides.ResumeLayout(false);
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Input;
        private System.Windows.Forms.TabPage Turbine;
        private System.Windows.Forms.TabPage Losses;
        private System.Windows.Forms.TabPage Uncertainties;
        private System.Windows.Forms.TabPage Tides;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.Button input_browse4;
        private System.Windows.Forms.Button input_browse3;
        private System.Windows.Forms.Button input_browse2;
        private System.Windows.Forms.Button input_browse1;
        private System.Windows.Forms.TextBox input_dirtxtbox4;
        private System.Windows.Forms.TextBox input_dirtxtbox3;
        private System.Windows.Forms.TextBox input_dirtxtbox2;
        private System.Windows.Forms.TextBox input_dirtxtbox1;
        private System.Windows.Forms.CheckBox input_checkbox4;
        private System.Windows.Forms.CheckBox input_checkbox3;
        private System.Windows.Forms.CheckBox input_checkbox2;
        private System.Windows.Forms.CheckBox input_checkbox1;
        private System.Windows.Forms.DateTimePicker input_dateTimePicker1;
        private System.Windows.Forms.Label input_labelend;
        private System.Windows.Forms.Label input_labelstrt;
        private System.Windows.Forms.MonthCalendar input_monthCalendar2;
        private System.Windows.Forms.MonthCalendar input_monthCalendar1;
        private System.Windows.Forms.Label input_labelfromto;
        private System.Windows.Forms.Label input_labelcalender;
        private System.Windows.Forms.Label input_labelselectdate;
        private System.Windows.Forms.TextBox input_totxtbox;
        private System.Windows.Forms.TextBox input_fromtxtbox;
        private System.Windows.Forms.DateTimePicker input_dateTimePicker2;
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
        private System.Windows.Forms.Button input_apply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView input_previewdatagridview;
        private System.Windows.Forms.Button input_preview;
    }
}

