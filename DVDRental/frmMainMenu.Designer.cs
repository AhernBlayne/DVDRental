namespace DVDsys
{
    partial class FrmDvd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDvd));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuMembers = new System.Windows.Forms.ToolStripDropDownButton();
            this.addMembertoolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMembertoolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMembertoolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDVD = new System.Windows.Forms.ToolStripDropDownButton();
            this.addDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.rentDvdtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDvdtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRevenuetoolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMembers,
            this.mnuDVD,
            this.toolStripDropDownButton1,
            this.viewRevenuetoolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuMembers
            // 
            this.mnuMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.mnuMembers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMembertoolStripMenuItem7,
            this.updateMembertoolStripMenuItem8,
            this.removeMembertoolStripMenuItem9});
            this.mnuMembers.ForeColor = System.Drawing.Color.Black;
            this.mnuMembers.Image = ((System.Drawing.Image)(resources.GetObject("mnuMembers.Image")));
            this.mnuMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(70, 22);
            this.mnuMembers.Text = "Members";
            this.mnuMembers.Click += new System.EventHandler(this.mnuMembers_Click);
            // 
            // addMembertoolStripMenuItem7
            // 
            this.addMembertoolStripMenuItem7.Name = "addMembertoolStripMenuItem7";
            this.addMembertoolStripMenuItem7.Size = new System.Drawing.Size(160, 22);
            this.addMembertoolStripMenuItem7.Text = "Add Member";
            this.addMembertoolStripMenuItem7.Click += new System.EventHandler(this.addMembertoolStripMenuItem7_Click);
            // 
            // updateMembertoolStripMenuItem8
            // 
            this.updateMembertoolStripMenuItem8.Name = "updateMembertoolStripMenuItem8";
            this.updateMembertoolStripMenuItem8.Size = new System.Drawing.Size(160, 22);
            this.updateMembertoolStripMenuItem8.Text = "Update Member";
            this.updateMembertoolStripMenuItem8.Click += new System.EventHandler(this.updateMembertoolStripMenuItem8_Click);
            // 
            // removeMembertoolStripMenuItem9
            // 
            this.removeMembertoolStripMenuItem9.Name = "removeMembertoolStripMenuItem9";
            this.removeMembertoolStripMenuItem9.Size = new System.Drawing.Size(160, 22);
            this.removeMembertoolStripMenuItem9.Text = "remove Member";
            this.removeMembertoolStripMenuItem9.Click += new System.EventHandler(this.removeMembertoolStripMenuItem9_Click);
            // 
            // mnuDVD
            // 
            this.mnuDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.mnuDVD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuDVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDVDToolStripMenuItem,
            this.updateDVDToolStripMenuItem,
            this.removeDVDToolStripMenuItem});
            this.mnuDVD.Image = ((System.Drawing.Image)(resources.GetObject("mnuDVD.Image")));
            this.mnuDVD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuDVD.Name = "mnuDVD";
            this.mnuDVD.Size = new System.Drawing.Size(46, 22);
            this.mnuDVD.Text = "DVD";
            // 
            // addDVDToolStripMenuItem
            // 
            this.addDVDToolStripMenuItem.Name = "addDVDToolStripMenuItem";
            this.addDVDToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addDVDToolStripMenuItem.Text = "Add DVD";
            this.addDVDToolStripMenuItem.Click += new System.EventHandler(this.addDVDToolStripMenuItem_Click);
            // 
            // updateDVDToolStripMenuItem
            // 
            this.updateDVDToolStripMenuItem.Name = "updateDVDToolStripMenuItem";
            this.updateDVDToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.updateDVDToolStripMenuItem.Text = "Update DVD";
            this.updateDVDToolStripMenuItem.Click += new System.EventHandler(this.updateDVDToolStripMenuItem_Click);
            // 
            // removeDVDToolStripMenuItem
            // 
            this.removeDVDToolStripMenuItem.Name = "removeDVDToolStripMenuItem";
            this.removeDVDToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.removeDVDToolStripMenuItem.Text = "remove DVD";
            this.removeDVDToolStripMenuItem.Click += new System.EventHandler(this.removeDVDToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentDvdtoolStripMenuItem1,
            this.returnDvdtoolStripMenuItem2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(90, 22);
            this.toolStripDropDownButton1.Text = "Transactions";
            // 
            // rentDvdtoolStripMenuItem1
            // 
            this.rentDvdtoolStripMenuItem1.Name = "rentDvdtoolStripMenuItem1";
            this.rentDvdtoolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.rentDvdtoolStripMenuItem1.Text = "Rent DVD";
            this.rentDvdtoolStripMenuItem1.Click += new System.EventHandler(this.rentDvdtoolStripMenuItem1_Click);
            // 
            // returnDvdtoolStripMenuItem2
            // 
            this.returnDvdtoolStripMenuItem2.Name = "returnDvdtoolStripMenuItem2";
            this.returnDvdtoolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.returnDvdtoolStripMenuItem2.Text = "Return DVD";
            this.returnDvdtoolStripMenuItem2.Click += new System.EventHandler(this.returnDvdtoolStripMenuItem2_Click);
            // 
            // viewRevenuetoolStripDropDownButton3
            // 
            this.viewRevenuetoolStripDropDownButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.viewRevenuetoolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewRevenuetoolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.viewCustomerChartToolStripMenuItem});
            this.viewRevenuetoolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("viewRevenuetoolStripDropDownButton3.Image")));
            this.viewRevenuetoolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewRevenuetoolStripDropDownButton3.Name = "viewRevenuetoolStripDropDownButton3";
            this.viewRevenuetoolStripDropDownButton3.Size = new System.Drawing.Size(62, 22);
            this.viewRevenuetoolStripDropDownButton3.Text = "Reports";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem13.Text = "view revenue chart";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // viewCustomerChartToolStripMenuItem
            // 
            this.viewCustomerChartToolStripMenuItem.Name = "viewCustomerChartToolStripMenuItem";
            this.viewCustomerChartToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewCustomerChartToolStripMenuItem.Text = "View Customer Chart";
            this.viewCustomerChartToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerChartToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(673, 369);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDvd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVDRental";
            this.Load += new System.EventHandler(this.FrmDvd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripDropDownButton mnuDVD;
		private System.Windows.Forms.ToolStripMenuItem addDVDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateDVDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem addMembertoolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem updateMembertoolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem removeMembertoolStripMenuItem9;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem rentDvdtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnDvdtoolStripMenuItem2;
        private System.Windows.Forms.ToolStripDropDownButton viewRevenuetoolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerChartToolStripMenuItem;
    }
}

