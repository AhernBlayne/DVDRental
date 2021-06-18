namespace DVDRental
{
    partial class frmDvd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDvd));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.addDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripDropDownButton();
            this.rentDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuCustomer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(-95, 28);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1120, 517);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDVDToolStripMenuItem,
            this.updateDVDToolStripMenuItem,
            this.deleteDVDToolStripMenuItem});
            this.mnuAdmin.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdmin.Image")));
            this.mnuAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(56, 22);
            this.mnuAdmin.Text = "Admin";
            // 
            // addDVDToolStripMenuItem
            // 
            this.addDVDToolStripMenuItem.Name = "addDVDToolStripMenuItem";
            this.addDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDVDToolStripMenuItem.Text = "Add DVD";
            this.addDVDToolStripMenuItem.Click += new System.EventHandler(this.addDVDToolStripMenuItem_Click);
            // 
            // updateDVDToolStripMenuItem
            // 
            this.updateDVDToolStripMenuItem.Name = "updateDVDToolStripMenuItem";
            this.updateDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateDVDToolStripMenuItem.Text = "Update DVD";
            this.updateDVDToolStripMenuItem.Click += new System.EventHandler(this.updateDVDToolStripMenuItem_Click);
            // 
            // deleteDVDToolStripMenuItem
            // 
            this.deleteDVDToolStripMenuItem.Name = "deleteDVDToolStripMenuItem";
            this.deleteDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteDVDToolStripMenuItem.Text = "Delete DVD";
            this.deleteDVDToolStripMenuItem.Click += new System.EventHandler(this.deleteDVDToolStripMenuItem_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentDVDToolStripMenuItem,
            this.returnDVDToolStripMenuItem});
            this.mnuCustomer.Image = ((System.Drawing.Image)(resources.GetObject("mnuCustomer.Image")));
            this.mnuCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(72, 22);
            this.mnuCustomer.Text = "Customer";
            // 
            // rentDVDToolStripMenuItem
            // 
            this.rentDVDToolStripMenuItem.Name = "rentDVDToolStripMenuItem";
            this.rentDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rentDVDToolStripMenuItem.Text = "Rent DVD";
            this.rentDVDToolStripMenuItem.Click += new System.EventHandler(this.rentDVDToolStripMenuItem_Click);
            // 
            // returnDVDToolStripMenuItem
            // 
            this.returnDVDToolStripMenuItem.Name = "returnDVDToolStripMenuItem";
            this.returnDVDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnDVDToolStripMenuItem.Text = "Return DVD";
            this.returnDVDToolStripMenuItem.Click += new System.EventHandler(this.returnDVDToolStripMenuItem_Click);
            // 
            // frmDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 571);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDvd";
            this.Text = "DVDRental";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ToolStripDropDownButton mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem addDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem rentDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnDVDToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

