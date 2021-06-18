namespace DVDsys
{
	partial class frmRevenueReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenueReport));
            this.chtReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TxtEnterYear = new System.Windows.Forms.TextBox();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.chtReport)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chtReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtReport.Legends.Add(legend1);
            this.chtReport.Location = new System.Drawing.Point(182, 28);
            this.chtReport.Name = "chtReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtReport.Series.Add(series1);
            this.chtReport.Size = new System.Drawing.Size(576, 407);
            this.chtReport.TabIndex = 0;
            this.chtReport.Text = "chart1";
            // 
            // TxtEnterYear
            // 
            this.TxtEnterYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEnterYear.Enabled = false;
            this.TxtEnterYear.Location = new System.Drawing.Point(55, 115);
            this.TxtEnterYear.Name = "TxtEnterYear";
            this.TxtEnterYear.ReadOnly = true;
            this.TxtEnterYear.Size = new System.Drawing.Size(100, 13);
            this.TxtEnterYear.TabIndex = 2;
            this.TxtEnterYear.Text = "Enter Year";
            // 
            // cboSelectYear
            // 
            this.cboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectYear.FormattingEnabled = true;
            this.cboSelectYear.Location = new System.Drawing.Point(55, 134);
            this.cboSelectYear.Name = "cboSelectYear";
            this.cboSelectYear.Size = new System.Drawing.Size(121, 21);
            this.cboSelectYear.TabIndex = 3;
            this.cboSelectYear.SelectedIndexChanged += new System.EventHandler(this.CboSelectYear_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(42, 22);
            this.menu.Text = "menu";
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // exit
            // 
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 22);
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // frmRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboSelectYear);
            this.Controls.Add(this.TxtEnterYear);
            this.Controls.Add(this.chtReport);
            this.Name = "frmRevenueReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmRevenueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtReport)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chtReport;
		private System.Windows.Forms.TextBox TxtEnterYear;
		private System.Windows.Forms.ComboBox cboSelectYear;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton menu;
		private System.Windows.Forms.ToolStripButton exit;
	}
}