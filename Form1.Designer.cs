
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
            this.input_buttonfinalaply = new System.Windows.Forms.Button();
            this.input_preview = new System.Windows.Forms.Button();
            this.input_labelnumhours = new System.Windows.Forms.Label();
            this.input_labelselectdate = new System.Windows.Forms.Label();
            this.input_monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.input_labelnumdays = new System.Windows.Forms.Label();
            this.input_monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.input_labelcalender = new System.Windows.Forms.Label();
            this.input_labelstrt = new System.Windows.Forms.Label();
            this.input_labelend = new System.Windows.Forms.Label();
            this.input_totxtbox = new System.Windows.Forms.TextBox();
            this.input_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.input_fromtxtbox = new System.Windows.Forms.TextBox();
            this.input_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbn_txtiec = new System.Windows.Forms.TextBox();
            this.tbn_txtrd = new System.Windows.Forms.TextBox();
            this.tbn_txtkw = new System.Windows.Forms.TextBox();
            this.tbn_iec = new System.Windows.Forms.Label();
            this.tbn_rotor = new System.Windows.Forms.Label();
            this.tbn_power = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbn_radio2 = new System.Windows.Forms.RadioButton();
            this.tbn_radio1 = new System.Windows.Forms.RadioButton();
            this.tbn_selectbtn = new System.Windows.Forms.Button();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.Arrangement = new System.Windows.Forms.TabPage();
            this.Losses = new System.Windows.Forms.TabPage();
            this.Uncertainties = new System.Windows.Forms.TabPage();
            this.Metocean = new System.Windows.Forms.TabPage();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            this.Result = new System.Windows.Forms.TabPage();
            this.rst_elec = new OxyPlot.WindowsForms.PlotView();
            this.rst_wavemax = new OxyPlot.WindowsForms.PlotView();
            this.rst_pwrgen = new OxyPlot.WindowsForms.PlotView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rst_loadGraph = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rst_windvel = new OxyPlot.WindowsForms.PlotView();
            this.TabControl.SuspendLayout();
            this.Input.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_previewdatagridview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Turbine.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Metocean.SuspendLayout();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Input);
            this.TabControl.Controls.Add(this.Turbine);
            this.TabControl.Controls.Add(this.Arrangement);
            this.TabControl.Controls.Add(this.Losses);
            this.TabControl.Controls.Add(this.Uncertainties);
            this.TabControl.Controls.Add(this.Metocean);
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
            this.TabControl.Size = new System.Drawing.Size(1182, 752);
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
            this.Input.Size = new System.Drawing.Size(1174, 723);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.input_previewdatagridview);
            this.groupBox3.Location = new System.Drawing.Point(663, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(503, 694);
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
            this.input_previewdatagridview.Size = new System.Drawing.Size(497, 669);
            this.input_previewdatagridview.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.input_buttonfinalaply);
            this.groupBox2.Controls.Add(this.input_preview);
            this.groupBox2.Controls.Add(this.input_labelnumhours);
            this.groupBox2.Controls.Add(this.input_labelselectdate);
            this.groupBox2.Controls.Add(this.input_monthCalendar1);
            this.groupBox2.Controls.Add(this.input_labelnumdays);
            this.groupBox2.Controls.Add(this.input_monthCalendar2);
            this.groupBox2.Controls.Add(this.input_labelcalender);
            this.groupBox2.Controls.Add(this.input_labelstrt);
            this.groupBox2.Controls.Add(this.input_labelend);
            this.groupBox2.Controls.Add(this.input_totxtbox);
            this.groupBox2.Controls.Add(this.input_dateTimePicker1);
            this.groupBox2.Controls.Add(this.input_fromtxtbox);
            this.groupBox2.Controls.Add(this.input_dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(9, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(648, 388);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            this.groupBox2.Visible = false;
            // 
            // input_buttonfinalaply
            // 
            this.input_buttonfinalaply.Location = new System.Drawing.Point(539, 342);
            this.input_buttonfinalaply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_buttonfinalaply.Name = "input_buttonfinalaply";
            this.input_buttonfinalaply.Size = new System.Drawing.Size(86, 29);
            this.input_buttonfinalaply.TabIndex = 27;
            this.input_buttonfinalaply.Text = "Apply";
            this.input_buttonfinalaply.UseVisualStyleBackColor = true;
            this.input_buttonfinalaply.Click += new System.EventHandler(this.input_buttonfinalaply_Click);
            // 
            // input_preview
            // 
            this.input_preview.Location = new System.Drawing.Point(447, 342);
            this.input_preview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_preview.Name = "input_preview";
            this.input_preview.Size = new System.Drawing.Size(86, 29);
            this.input_preview.TabIndex = 26;
            this.input_preview.Text = "Preview";
            this.input_preview.UseVisualStyleBackColor = true;
            this.input_preview.Click += new System.EventHandler(this.input_preview_Click);
            // 
            // input_labelnumhours
            // 
            this.input_labelnumhours.AutoSize = true;
            this.input_labelnumhours.Location = new System.Drawing.Point(13, 349);
            this.input_labelnumhours.Name = "input_labelnumhours";
            this.input_labelnumhours.Size = new System.Drawing.Size(116, 15);
            this.input_labelnumhours.TabIndex = 23;
            this.input_labelnumhours.Text = "Number of Datas";
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
            // input_labelnumdays
            // 
            this.input_labelnumdays.AutoSize = true;
            this.input_labelnumdays.Location = new System.Drawing.Point(13, 312);
            this.input_labelnumdays.Name = "input_labelnumdays";
            this.input_labelnumdays.Size = new System.Drawing.Size(112, 15);
            this.input_labelnumdays.TabIndex = 22;
            this.input_labelnumdays.Text = "Number of Days";
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
            this.input_labelstrt.Location = new System.Drawing.Point(101, 22);
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
            this.input_totxtbox.Location = new System.Drawing.Point(134, 345);
            this.input_totxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_totxtbox.Name = "input_totxtbox";
            this.input_totxtbox.ReadOnly = true;
            this.input_totxtbox.Size = new System.Drawing.Size(215, 25);
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
            this.input_fromtxtbox.Location = new System.Drawing.Point(134, 309);
            this.input_fromtxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_fromtxtbox.Name = "input_fromtxtbox";
            this.input_fromtxtbox.ReadOnly = true;
            this.input_fromtxtbox.Size = new System.Drawing.Size(215, 25);
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
            // input_apply
            // 
            this.input_apply.Location = new System.Drawing.Point(512, 249);
            this.input_apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_apply.Name = "input_apply";
            this.input_apply.Size = new System.Drawing.Size(91, 29);
            this.input_apply.TabIndex = 25;
            this.input_apply.Text = "Apply";
            this.input_apply.UseVisualStyleBackColor = true;
            this.input_apply.Click += new System.EventHandler(this.input_apply_Click);
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
            this.input_checkbox2.Location = new System.Drawing.Point(15, 82);
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
            this.Turbine.Controls.Add(this.groupBox5);
            this.Turbine.Controls.Add(this.groupBox4);
            this.Turbine.Controls.Add(this.tbn_selectbtn);
            this.Turbine.Controls.Add(this.plotView2);
            this.Turbine.Location = new System.Drawing.Point(4, 25);
            this.Turbine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Turbine.Name = "Turbine";
            this.Turbine.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Turbine.Size = new System.Drawing.Size(1174, 723);
            this.Turbine.TabIndex = 1;
            this.Turbine.Text = "Turbine";
            this.Turbine.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbn_txtiec);
            this.groupBox5.Controls.Add(this.tbn_txtrd);
            this.groupBox5.Controls.Add(this.tbn_txtkw);
            this.groupBox5.Controls.Add(this.tbn_iec);
            this.groupBox5.Controls.Add(this.tbn_rotor);
            this.groupBox5.Controls.Add(this.tbn_power);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(23, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 208);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Predefined turbines";
            // 
            // tbn_txtiec
            // 
            this.tbn_txtiec.Location = new System.Drawing.Point(190, 160);
            this.tbn_txtiec.Name = "tbn_txtiec";
            this.tbn_txtiec.ReadOnly = true;
            this.tbn_txtiec.Size = new System.Drawing.Size(250, 25);
            this.tbn_txtiec.TabIndex = 9;
            // 
            // tbn_txtrd
            // 
            this.tbn_txtrd.Location = new System.Drawing.Point(190, 124);
            this.tbn_txtrd.Name = "tbn_txtrd";
            this.tbn_txtrd.ReadOnly = true;
            this.tbn_txtrd.Size = new System.Drawing.Size(250, 25);
            this.tbn_txtrd.TabIndex = 8;
            // 
            // tbn_txtkw
            // 
            this.tbn_txtkw.Location = new System.Drawing.Point(190, 85);
            this.tbn_txtkw.Name = "tbn_txtkw";
            this.tbn_txtkw.ReadOnly = true;
            this.tbn_txtkw.Size = new System.Drawing.Size(250, 25);
            this.tbn_txtkw.TabIndex = 7;
            // 
            // tbn_iec
            // 
            this.tbn_iec.AutoSize = true;
            this.tbn_iec.Location = new System.Drawing.Point(22, 163);
            this.tbn_iec.Name = "tbn_iec";
            this.tbn_iec.Size = new System.Drawing.Size(156, 15);
            this.tbn_iec.TabIndex = 6;
            this.tbn_iec.Text = "IEC Wind Speed Class";
            // 
            // tbn_rotor
            // 
            this.tbn_rotor.AutoSize = true;
            this.tbn_rotor.Location = new System.Drawing.Point(22, 124);
            this.tbn_rotor.Name = "tbn_rotor";
            this.tbn_rotor.Size = new System.Drawing.Size(102, 15);
            this.tbn_rotor.TabIndex = 5;
            this.tbn_rotor.Text = "Rotor diameter";
            // 
            // tbn_power
            // 
            this.tbn_power.AutoSize = true;
            this.tbn_power.Location = new System.Drawing.Point(22, 85);
            this.tbn_power.Name = "tbn_power";
            this.tbn_power.Size = new System.Drawing.Size(75, 15);
            this.tbn_power.TabIndex = 4;
            this.tbn_power.Text = "KW Rating";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(418, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbn_radio2);
            this.groupBox4.Controls.Add(this.tbn_radio1);
            this.groupBox4.Location = new System.Drawing.Point(23, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 129);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Turbine";
            // 
            // tbn_radio2
            // 
            this.tbn_radio2.AutoSize = true;
            this.tbn_radio2.Location = new System.Drawing.Point(36, 76);
            this.tbn_radio2.Name = "tbn_radio2";
            this.tbn_radio2.Size = new System.Drawing.Size(256, 19);
            this.tbn_radio2.TabIndex = 1;
            this.tbn_radio2.TabStop = true;
            this.tbn_radio2.Text = "Load custom turbine from Input tab";
            this.tbn_radio2.UseVisualStyleBackColor = true;
            this.tbn_radio2.CheckedChanged += new System.EventHandler(this.tbn_radio2_CheckedChanged);
            // 
            // tbn_radio1
            // 
            this.tbn_radio1.AutoSize = true;
            this.tbn_radio1.Location = new System.Drawing.Point(36, 38);
            this.tbn_radio1.Name = "tbn_radio1";
            this.tbn_radio1.Size = new System.Drawing.Size(206, 19);
            this.tbn_radio1.TabIndex = 0;
            this.tbn_radio1.TabStop = true;
            this.tbn_radio1.Text = "Select a turbine from library";
            this.tbn_radio1.UseVisualStyleBackColor = true;
            this.tbn_radio1.CheckedChanged += new System.EventHandler(this.tbn_radio1_CheckedChanged);
            // 
            // tbn_selectbtn
            // 
            this.tbn_selectbtn.Location = new System.Drawing.Point(1063, 675);
            this.tbn_selectbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbn_selectbtn.Name = "tbn_selectbtn";
            this.tbn_selectbtn.Size = new System.Drawing.Size(86, 29);
            this.tbn_selectbtn.TabIndex = 2;
            this.tbn_selectbtn.Text = "Select";
            this.tbn_selectbtn.UseVisualStyleBackColor = true;
            this.tbn_selectbtn.Click += new System.EventHandler(this.tbn_selectbtn_Click);
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(504, 24);
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
            // Arrangement
            // 
            this.Arrangement.Location = new System.Drawing.Point(4, 25);
            this.Arrangement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Arrangement.Name = "Arrangement";
            this.Arrangement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Arrangement.Size = new System.Drawing.Size(1174, 723);
            this.Arrangement.TabIndex = 6;
            this.Arrangement.Text = "Arrangement";
            this.Arrangement.UseVisualStyleBackColor = true;
            // 
            // Losses
            // 
            this.Losses.Location = new System.Drawing.Point(4, 25);
            this.Losses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Losses.Name = "Losses";
            this.Losses.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Losses.Size = new System.Drawing.Size(1174, 723);
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
            this.Uncertainties.Size = new System.Drawing.Size(1174, 723);
            this.Uncertainties.TabIndex = 3;
            this.Uncertainties.Text = "Uncertainties";
            this.Uncertainties.UseVisualStyleBackColor = true;
            // 
            // Metocean
            // 
            this.Metocean.Controls.Add(this.plotView3);
            this.Metocean.Location = new System.Drawing.Point(4, 25);
            this.Metocean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Metocean.Name = "Metocean";
            this.Metocean.Size = new System.Drawing.Size(1174, 723);
            this.Metocean.TabIndex = 4;
            this.Metocean.Text = "Metocean";
            this.Metocean.UseVisualStyleBackColor = true;
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
            this.Result.Controls.Add(this.rst_elec);
            this.Result.Controls.Add(this.rst_wavemax);
            this.Result.Controls.Add(this.rst_pwrgen);
            this.Result.Controls.Add(this.label3);
            this.Result.Controls.Add(this.textBox3);
            this.Result.Controls.Add(this.textBox2);
            this.Result.Controls.Add(this.label2);
            this.Result.Controls.Add(this.rst_loadGraph);
            this.Result.Controls.Add(this.textBox1);
            this.Result.Controls.Add(this.label1);
            this.Result.Controls.Add(this.rst_windvel);
            this.Result.Location = new System.Drawing.Point(4, 25);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1174, 723);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            // 
            // rst_elec
            // 
            this.rst_elec.Location = new System.Drawing.Point(8, 508);
            this.rst_elec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_elec.Name = "rst_elec";
            this.rst_elec.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_elec.Size = new System.Drawing.Size(1154, 160);
            this.rst_elec.TabIndex = 20;
            this.rst_elec.Text = "plotView5";
            this.rst_elec.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_elec.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_elec.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rst_wavemax
            // 
            this.rst_wavemax.Location = new System.Drawing.Point(9, 344);
            this.rst_wavemax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_wavemax.Name = "rst_wavemax";
            this.rst_wavemax.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_wavemax.Size = new System.Drawing.Size(1154, 160);
            this.rst_wavemax.TabIndex = 19;
            this.rst_wavemax.Text = "plotView5";
            this.rst_wavemax.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_wavemax.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_wavemax.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rst_pwrgen
            // 
            this.rst_pwrgen.Location = new System.Drawing.Point(9, 179);
            this.rst_pwrgen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_pwrgen.Name = "rst_pwrgen";
            this.rst_pwrgen.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_pwrgen.Size = new System.Drawing.Size(1154, 160);
            this.rst_pwrgen.TabIndex = 18;
            this.rst_pwrgen.Text = "plotView4";
            this.rst_pwrgen.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_pwrgen.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_pwrgen.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 685);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "시간당 평균 전력";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(810, 681);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(567, 682);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "H2 생산에 사용된 전력";
            // 
            // rst_loadGraph
            // 
            this.rst_loadGraph.Location = new System.Drawing.Point(9, 682);
            this.rst_loadGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_loadGraph.Name = "rst_loadGraph";
            this.rst_loadGraph.Size = new System.Drawing.Size(91, 29);
            this.rst_loadGraph.TabIndex = 11;
            this.rst_loadGraph.Text = "LoadGraph";
            this.rst_loadGraph.UseVisualStyleBackColor = true;
            this.rst_loadGraph.Click += new System.EventHandler(this.rst_loadGraph_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 682);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 685);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "총 전력생산량";
            // 
            // rst_windvel
            // 
            this.rst_windvel.Location = new System.Drawing.Point(9, 14);
            this.rst_windvel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_windvel.Name = "rst_windvel";
            this.rst_windvel.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_windvel.Size = new System.Drawing.Size(1154, 160);
            this.rst_windvel.TabIndex = 3;
            this.rst_windvel.Text = "plotView1";
            this.rst_windvel.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_windvel.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_windvel.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // CAESimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 752);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Metocean.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Metocean;
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
        private System.Windows.Forms.Label input_labelnumdays;
        private System.Windows.Forms.Label input_labelcalender;
        private System.Windows.Forms.Label input_labelselectdate;
        private System.Windows.Forms.TextBox input_totxtbox;
        private System.Windows.Forms.TextBox input_fromtxtbox;
        private System.Windows.Forms.DateTimePicker input_dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private OxyPlot.WindowsForms.PlotView rst_windvel;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rst_loadGraph;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button input_apply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView input_previewdatagridview;
        private System.Windows.Forms.Button input_preview;
        private System.Windows.Forms.TabPage Arrangement;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button tbn_selectbtn;
        private OxyPlot.WindowsForms.PlotView rst_wavemax;
        private OxyPlot.WindowsForms.PlotView rst_pwrgen;
        private System.Windows.Forms.Label input_labelnumhours;
        private System.Windows.Forms.Button input_buttonfinalaply;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton tbn_radio2;
        private System.Windows.Forms.RadioButton tbn_radio1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbn_txtiec;
        private System.Windows.Forms.TextBox tbn_txtrd;
        private System.Windows.Forms.TextBox tbn_txtkw;
        private System.Windows.Forms.Label tbn_iec;
        private System.Windows.Forms.Label tbn_rotor;
        private System.Windows.Forms.Label tbn_power;
        private OxyPlot.WindowsForms.PlotView rst_elec;
    }
}

