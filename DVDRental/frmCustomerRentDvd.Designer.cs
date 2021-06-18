namespace DVDRental
{
    partial class frmCustomerRentDvd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRentDvd));
            this.btnRentDvd = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDVD = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtRentid = new System.Windows.Forms.TextBox();
            this.cboWeeks = new System.Windows.Forms.ComboBox();
            this.cboDVD = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRentDvd
            // 
            this.btnRentDvd.Location = new System.Drawing.Point(73, 321);
            this.btnRentDvd.Name = "btnRentDvd";
            this.btnRentDvd.Size = new System.Drawing.Size(132, 71);
            this.btnRentDvd.TabIndex = 14;
            this.btnRentDvd.Text = "Rent DVD";
            this.btnRentDvd.UseVisualStyleBackColor = true;
            this.btnRentDvd.Click += new System.EventHandler(this.btnRentDvd_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(61, 126);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 13);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.Text = "Duration Of Rent";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 15;
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
            // cboCat
            // 
            this.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(166, 88);
            this.cboCat.Margin = new System.Windows.Forms.Padding(2);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(125, 21);
            this.cboCat.TabIndex = 16;
            // 
            // txtCat
            // 
            this.txtCat.BackColor = System.Drawing.SystemColors.Control;
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCat.Location = new System.Drawing.Point(61, 91);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(100, 13);
            this.txtCat.TabIndex = 17;
            this.txtCat.Text = "DVD Catagory";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(303, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Forename";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(303, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Surname";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(303, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "Phone";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(303, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Address";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(385, 87);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 22;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(385, 126);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(385, 163);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 24;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(385, 193);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 25;
            // 
            // txtDVD
            // 
            this.txtDVD.BackColor = System.Drawing.SystemColors.Control;
            this.txtDVD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDVD.Location = new System.Drawing.Point(61, 163);
            this.txtDVD.Name = "txtDVD";
            this.txtDVD.Size = new System.Drawing.Size(100, 13);
            this.txtDVD.TabIndex = 30;
            this.txtDVD.Text = "DVD ";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(60, 242);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 31;
            this.textBox6.Text = "Rent ID";
            // 
            // txtRentid
            // 
            this.txtRentid.Location = new System.Drawing.Point(166, 242);
            this.txtRentid.Name = "txtRentid";
            this.txtRentid.Size = new System.Drawing.Size(39, 20);
            this.txtRentid.TabIndex = 32;
            // 
            // cboWeeks
            // 
            this.cboWeeks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeeks.FormattingEnabled = true;
            this.cboWeeks.Items.AddRange(new object[] {
            "1 week",
            "2 weeks",
            "3 weeks"});
            this.cboWeeks.Location = new System.Drawing.Point(166, 123);
            this.cboWeeks.Margin = new System.Windows.Forms.Padding(2);
            this.cboWeeks.Name = "cboWeeks";
            this.cboWeeks.Size = new System.Drawing.Size(125, 21);
            this.cboWeeks.TabIndex = 33;
            // 
            // cboDVD
            // 
            this.cboDVD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVD.FormattingEnabled = true;
            this.cboDVD.Location = new System.Drawing.Point(166, 163);
            this.cboDVD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDVD.Name = "cboDVD";
            this.cboDVD.Size = new System.Drawing.Size(125, 21);
            this.cboDVD.TabIndex = 34;
            // 
            // frmCustomerRentDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboDVD);
            this.Controls.Add(this.cboWeeks);
            this.Controls.Add(this.txtRentid);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtDVD);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnRentDvd);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "frmCustomerRentDvd";
            this.Text = "frmCustomerRentDvd";
            this.Load += new System.EventHandler(this.frmCustomerRentDvd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRentDvd;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menu;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDVD;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtRentid;
        private System.Windows.Forms.ComboBox cboWeeks;
        private System.Windows.Forms.ComboBox cboDVD;
    }
}