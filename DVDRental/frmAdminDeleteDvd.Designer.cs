namespace DVDRental
{
    partial class frmAdminDeleteDvd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDeleteDvd));
            this.btnDeleteDvd = new System.Windows.Forms.Button();
            this.txtDeleteDvd = new System.Windows.Forms.TextBox();
            this.dvd = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.grdRemoveDvd = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveDvd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteDvd
            // 
            this.btnDeleteDvd.Location = new System.Drawing.Point(158, 216);
            this.btnDeleteDvd.Name = "btnDeleteDvd";
            this.btnDeleteDvd.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDvd.TabIndex = 9;
            this.btnDeleteDvd.Text = "Delete DVD";
            this.btnDeleteDvd.UseVisualStyleBackColor = true;
            this.btnDeleteDvd.Click += new System.EventHandler(this.btnDeleteDvd_Click);
            // 
            // txtDeleteDvd
            // 
            this.txtDeleteDvd.Location = new System.Drawing.Point(158, 135);
            this.txtDeleteDvd.Name = "txtDeleteDvd";
            this.txtDeleteDvd.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteDvd.TabIndex = 7;
            // 
            // dvd
            // 
            this.dvd.BackColor = System.Drawing.SystemColors.Control;
            this.dvd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvd.Location = new System.Drawing.Point(103, 138);
            this.dvd.Name = "dvd";
            this.dvd.Size = new System.Drawing.Size(100, 13);
            this.dvd.TabIndex = 5;
            this.dvd.Text = "DVD Id";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(42, 22);
            this.menu.Text = "menu";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // exit
            // 
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 22);
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // grdRemoveDvd
            // 
            this.grdRemoveDvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRemoveDvd.Location = new System.Drawing.Point(348, 44);
            this.grdRemoveDvd.Name = "grdRemoveDvd";
            this.grdRemoveDvd.RowHeadersWidth = 51;
            this.grdRemoveDvd.Size = new System.Drawing.Size(414, 261);
            this.grdRemoveDvd.TabIndex = 26;
            this.grdRemoveDvd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRemoveDvd_CellContentClick_1);
            // 
            // frmAdminDeleteDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdRemoveDvd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDeleteDvd);
            this.Controls.Add(this.txtDeleteDvd);
            this.Controls.Add(this.dvd);
            this.Name = "frmAdminDeleteDvd";
            this.Text = "frmAdminDeleteDvd";
            this.Load += new System.EventHandler(this.frmAdminDeleteDvd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveDvd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteDvd;
        private System.Windows.Forms.TextBox txtDeleteDvd;
        private System.Windows.Forms.TextBox dvd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menu;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.DataGridView grdRemoveDvd;
    }
}