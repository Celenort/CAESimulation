
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Files = new System.Windows.Forms.TabPage();
            this.Turbine = new System.Windows.Forms.TabPage();
            this.Losses = new System.Windows.Forms.TabPage();
            this.Uncertainties = new System.Windows.Forms.TabPage();
            this.Tides = new System.Windows.Forms.TabPage();
            this.Result = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.sourcebrowse = new System.Windows.Forms.Button();
            this.turbinebrowsebtn = new System.Windows.Forms.Button();
            this.marinebrowsebtn = new System.Windows.Forms.Button();
            this.elecbrowsebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.Files.SuspendLayout();
            this.Uncertainties.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(368, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "LoadData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(821, 148);
            this.plotView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(153, 235);
            this.plotView1.TabIndex = 2;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "LoadGraph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "총 전력생산량";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 462);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(88, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "H2 생산에 사용된 전력";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(658, 462);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(88, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(871, 461);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(88, 21);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "시간당 평균 전력";
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
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1184, 761);
            this.TabControl.TabIndex = 10;
            // 
            // Files
            // 
            this.Files.Controls.Add(this.label7);
            this.Files.Controls.Add(this.label6);
            this.Files.Controls.Add(this.label5);
            this.Files.Controls.Add(this.label4);
            this.Files.Controls.Add(this.elecbrowsebtn);
            this.Files.Controls.Add(this.marinebrowsebtn);
            this.Files.Controls.Add(this.turbinebrowsebtn);
            this.Files.Controls.Add(this.sourcebrowse);
            this.Files.Controls.Add(this.textBox7);
            this.Files.Controls.Add(this.textBox6);
            this.Files.Controls.Add(this.textBox5);
            this.Files.Controls.Add(this.textBox4);
            this.Files.Location = new System.Drawing.Point(4, 22);
            this.Files.Name = "Files";
            this.Files.Padding = new System.Windows.Forms.Padding(3);
            this.Files.Size = new System.Drawing.Size(1176, 735);
            this.Files.TabIndex = 0;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            // 
            // Turbine
            // 
            this.Turbine.Location = new System.Drawing.Point(4, 22);
            this.Turbine.Name = "Turbine";
            this.Turbine.Padding = new System.Windows.Forms.Padding(3);
            this.Turbine.Size = new System.Drawing.Size(1176, 735);
            this.Turbine.TabIndex = 1;
            this.Turbine.Text = "Turbine";
            this.Turbine.UseVisualStyleBackColor = true;
            // 
            // Losses
            // 
            this.Losses.Location = new System.Drawing.Point(4, 22);
            this.Losses.Name = "Losses";
            this.Losses.Padding = new System.Windows.Forms.Padding(3);
            this.Losses.Size = new System.Drawing.Size(1176, 735);
            this.Losses.TabIndex = 2;
            this.Losses.Text = "Losses";
            this.Losses.UseVisualStyleBackColor = true;
            // 
            // Uncertainties
            // 
            this.Uncertainties.Controls.Add(this.plotView1);
            this.Uncertainties.Controls.Add(this.label3);
            this.Uncertainties.Controls.Add(this.dataGridView1);
            this.Uncertainties.Controls.Add(this.textBox3);
            this.Uncertainties.Controls.Add(this.textBox2);
            this.Uncertainties.Controls.Add(this.button1);
            this.Uncertainties.Controls.Add(this.label2);
            this.Uncertainties.Controls.Add(this.button2);
            this.Uncertainties.Controls.Add(this.textBox1);
            this.Uncertainties.Controls.Add(this.label1);
            this.Uncertainties.Location = new System.Drawing.Point(4, 22);
            this.Uncertainties.Name = "Uncertainties";
            this.Uncertainties.Padding = new System.Windows.Forms.Padding(3);
            this.Uncertainties.Size = new System.Drawing.Size(1176, 735);
            this.Uncertainties.TabIndex = 3;
            this.Uncertainties.Text = "Uncertainties";
            this.Uncertainties.UseVisualStyleBackColor = true;
            // 
            // Tides
            // 
            this.Tides.Location = new System.Drawing.Point(4, 22);
            this.Tides.Name = "Tides";
            this.Tides.Size = new System.Drawing.Size(1176, 735);
            this.Tides.TabIndex = 4;
            this.Tides.Text = "Tides";
            this.Tides.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(4, 22);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1176, 735);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(272, 21);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(272, 21);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 88);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(272, 21);
            this.textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(132, 115);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(272, 21);
            this.textBox7.TabIndex = 3;
            // 
            // sourcebrowse
            // 
            this.sourcebrowse.Location = new System.Drawing.Point(411, 34);
            this.sourcebrowse.Name = "sourcebrowse";
            this.sourcebrowse.Size = new System.Drawing.Size(75, 21);
            this.sourcebrowse.TabIndex = 4;
            this.sourcebrowse.Text = "Browse";
            this.sourcebrowse.UseVisualStyleBackColor = true;
            // 
            // turbinebrowsebtn
            // 
            this.turbinebrowsebtn.Location = new System.Drawing.Point(411, 61);
            this.turbinebrowsebtn.Name = "turbinebrowsebtn";
            this.turbinebrowsebtn.Size = new System.Drawing.Size(75, 21);
            this.turbinebrowsebtn.TabIndex = 5;
            this.turbinebrowsebtn.Text = "Browse";
            this.turbinebrowsebtn.UseVisualStyleBackColor = true;
            // 
            // marinebrowsebtn
            // 
            this.marinebrowsebtn.Location = new System.Drawing.Point(411, 88);
            this.marinebrowsebtn.Name = "marinebrowsebtn";
            this.marinebrowsebtn.Size = new System.Drawing.Size(75, 21);
            this.marinebrowsebtn.TabIndex = 6;
            this.marinebrowsebtn.Text = "Browse";
            this.marinebrowsebtn.UseVisualStyleBackColor = true;
            // 
            // elecbrowsebtn
            // 
            this.elecbrowsebtn.Location = new System.Drawing.Point(411, 115);
            this.elecbrowsebtn.Name = "elecbrowsebtn";
            this.elecbrowsebtn.Size = new System.Drawing.Size(75, 21);
            this.elecbrowsebtn.TabIndex = 7;
            this.elecbrowsebtn.Text = "Browse";
            this.elecbrowsebtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // CAESimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.TabControl);
            this.Name = "CAESimulation";
            this.Text = "CAESimulation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.Files.ResumeLayout(false);
            this.Files.PerformLayout();
            this.Uncertainties.ResumeLayout(false);
            this.Uncertainties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.TabPage Turbine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Losses;
        private System.Windows.Forms.TabPage Uncertainties;
        private System.Windows.Forms.TabPage Tides;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button elecbrowsebtn;
        private System.Windows.Forms.Button marinebrowsebtn;
        private System.Windows.Forms.Button turbinebrowsebtn;
        private System.Windows.Forms.Button sourcebrowse;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}

