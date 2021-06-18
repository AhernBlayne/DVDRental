namespace DVDRental
{
    partial class frmAdminUpdateDvd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUpdateDvd));
            this.btnUpdateDvd = new System.Windows.Forms.Button();
            this.txtUpdateDvdcat = new System.Windows.Forms.TextBox();
            this.txtUpdateDvd = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.txtNewDvdName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.grdUpdateDvd = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateDvd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateDvd
            // 
            this.btnUpdateDvd.Location = new System.Drawing.Point(169, 243);
            this.btnUpdateDvd.Name = "btnUpdateDvd";
            this.btnUpdateDvd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDvd.TabIndex = 9;
            this.btnUpdateDvd.Text = "Update";
            this.btnUpdateDvd.UseVisualStyleBackColor = true;
            this.btnUpdateDvd.Click += new System.EventHandler(this.btnUpdateDvd_Click);
            // 
            // txtUpdateDvdcat
            // 
            this.txtUpdateDvdcat.Location = new System.Drawing.Point(169, 163);
            this.txtUpdateDvdcat.Name = "txtUpdateDvdcat";
            this.txtUpdateDvdcat.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDvdcat.TabIndex = 8;
            // 
            // txtUpdateDvd
            // 
            this.txtUpdateDvd.Location = new System.Drawing.Point(169, 52);
            this.txtUpdateDvd.Name = "txtUpdateDvd";
            this.txtUpdateDvd.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDvd.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(84, 163);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 13);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.Text = "New DVD id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(63, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "DVD id To Update";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(169, 189);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePrice.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Location = new System.Drawing.Point(93, 192);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(70, 13);
            this.maskedTextBox2.TabIndex = 11;
            this.maskedTextBox2.Text = "DVD Status";
            // 
            // txtNewDvdName
            // 
            this.txtNewDvdName.Location = new System.Drawing.Point(169, 129);
            this.txtNewDvdName.Name = "txtNewDvdName";
            this.txtNewDvdName.Size = new System.Drawing.Size(100, 20);
            this.txtNewDvdName.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(84, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 13);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "New DVD Name";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 14;
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
            // grdUpdateDvd
            // 
            this.grdUpdateDvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateDvd.Location = new System.Drawing.Point(352, 52);
            this.grdUpdateDvd.Name = "grdUpdateDvd";
            this.grdUpdateDvd.RowHeadersWidth = 51;
            this.grdUpdateDvd.Size = new System.Drawing.Size(414, 261);
            this.grdUpdateDvd.TabIndex = 27;
            this.grdUpdateDvd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateDvd_CellContentClick);
            // 
            // frmAdminUpdateDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdUpdateDvd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtNewDvdName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.txtUpdatePrice);
            this.Controls.Add(this.btnUpdateDvd);
            this.Controls.Add(this.txtUpdateDvdcat);
            this.Controls.Add(this.txtUpdateDvd);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmAdminUpdateDvd";
            this.Text = "frmAdminUpdateDvd";
            this.Load += new System.EventHandler(this.frmAdminUpdateDvd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateDvd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateDvd;
        private System.Windows.Forms.TextBox txtUpdateDvdcat;
        private System.Windows.Forms.TextBox txtUpdateDvd;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox txtNewDvdName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menu;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.DataGridView grdUpdateDvd;
    }
}