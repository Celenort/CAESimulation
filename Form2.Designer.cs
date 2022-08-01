namespace CAESimulation
{
    partial class Resultdiag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rst_elec = new OxyPlot.WindowsForms.PlotView();
            this.rst_wavemax = new OxyPlot.WindowsForms.PlotView();
            this.rst_pwrgen = new OxyPlot.WindowsForms.PlotView();
            this.rst_windvel = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // rst_elec
            // 
            this.rst_elec.Location = new System.Drawing.Point(114, 478);
            this.rst_elec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_elec.Name = "rst_elec";
            this.rst_elec.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_elec.Size = new System.Drawing.Size(1154, 160);
            this.rst_elec.TabIndex = 24;
            this.rst_elec.Text = "plotView5";
            this.rst_elec.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_elec.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_elec.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rst_wavemax
            // 
            this.rst_wavemax.Location = new System.Drawing.Point(114, 314);
            this.rst_wavemax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_wavemax.Name = "rst_wavemax";
            this.rst_wavemax.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_wavemax.Size = new System.Drawing.Size(1154, 160);
            this.rst_wavemax.TabIndex = 23;
            this.rst_wavemax.Text = "plotView5";
            this.rst_wavemax.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_wavemax.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_wavemax.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rst_pwrgen
            // 
            this.rst_pwrgen.Location = new System.Drawing.Point(114, 642);
            this.rst_pwrgen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_pwrgen.Name = "rst_pwrgen";
            this.rst_pwrgen.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_pwrgen.Size = new System.Drawing.Size(1154, 160);
            this.rst_pwrgen.TabIndex = 22;
            this.rst_pwrgen.Text = "plotView4";
            this.rst_pwrgen.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_pwrgen.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_pwrgen.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rst_windvel
            // 
            this.rst_windvel.Location = new System.Drawing.Point(115, 150);
            this.rst_windvel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rst_windvel.Name = "rst_windvel";
            this.rst_windvel.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.rst_windvel.Size = new System.Drawing.Size(1154, 160);
            this.rst_windvel.TabIndex = 21;
            this.rst_windvel.Text = "plotView1";
            this.rst_windvel.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.rst_windvel.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rst_windvel.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Resultdiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 953);
            this.Controls.Add(this.rst_elec);
            this.Controls.Add(this.rst_wavemax);
            this.Controls.Add(this.rst_pwrgen);
            this.Controls.Add(this.rst_windvel);
            this.Name = "Resultdiag";
            this.Text = "CAESim_result";
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView rst_elec;
        private OxyPlot.WindowsForms.PlotView rst_wavemax;
        private OxyPlot.WindowsForms.PlotView rst_pwrgen;
        private OxyPlot.WindowsForms.PlotView rst_windvel;
    }
}