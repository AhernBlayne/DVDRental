namespace DVDsys
{
	partial class FrmAdminAddMember
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
            System.Windows.Forms.Button btnAddMember;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminAddMember));
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.cboCounties = new System.Windows.Forms.ComboBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblcust_ID = new System.Windows.Forms.Label();
            this.txtcustID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            btnAddMember = new System.Windows.Forms.Button();
            this.grpMember.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            btnAddMember.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(127)))), ((int)(((byte)(104)))));
            btnAddMember.ForeColor = System.Drawing.Color.Black;
            btnAddMember.Location = new System.Drawing.Point(89, 280);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new System.Drawing.Size(193, 48);
            btnAddMember.TabIndex = 9;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click_1);
            // 
            // grpMember
            // 
            this.grpMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.grpMember.Controls.Add(this.cboCounties);
            this.grpMember.Controls.Add(this.txtPin);
            this.grpMember.Controls.Add(this.lblPin);
            this.grpMember.Controls.Add(this.lblPhoneNumber);
            this.grpMember.Controls.Add(this.lblCounty);
            this.grpMember.Controls.Add(this.txtPhoneNumber);
            this.grpMember.Controls.Add(this.txtTown);
            this.grpMember.Controls.Add(this.lblTown);
            this.grpMember.Controls.Add(this.lblLastName);
            this.grpMember.Controls.Add(this.txtLastName);
            this.grpMember.Controls.Add(this.lblcust_ID);
            this.grpMember.Controls.Add(this.txtcustID);
            this.grpMember.Controls.Add(this.txtAddress);
            this.grpMember.Controls.Add(this.txtFirstName);
            this.grpMember.Controls.Add(this.lblAddress);
            this.grpMember.Controls.Add(this.lblFirstName);
            this.grpMember.Controls.Add(btnAddMember);
            this.grpMember.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMember.ForeColor = System.Drawing.Color.Black;
            this.grpMember.Location = new System.Drawing.Point(197, 41);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(367, 368);
            this.grpMember.TabIndex = 41;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Add Member";
            // 
            // cboCounties
            // 
            this.cboCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounties.FormattingEnabled = true;
            this.cboCounties.Location = new System.Drawing.Point(117, 171);
            this.cboCounties.Name = "cboCounties";
            this.cboCounties.Size = new System.Drawing.Size(174, 23);
            this.cboCounties.TabIndex = 6;
            this.cboCounties.SelectedIndexChanged += new System.EventHandler(this.cboCounties_SelectedIndexChanged);
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtPin.Location = new System.Drawing.Point(118, 229);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(31, 23);
            this.txtPin.TabIndex = 8;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(20, 236);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(26, 16);
            this.lblPin.TabIndex = 102;
            this.lblPin.Text = "Pin";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 207);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(93, 16);
            this.lblPhoneNumber.TabIndex = 101;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(20, 178);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(49, 16);
            this.lblCounty.TabIndex = 100;
            this.lblCounty.Text = "County";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(118, 200);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(69, 23);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtTown
            // 
            this.txtTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtTown.Location = new System.Drawing.Point(118, 142);
            this.txtTown.MaxLength = 25;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(173, 23);
            this.txtTown.TabIndex = 5;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(20, 149);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(41, 16);
            this.lblTown.TabIndex = 96;
            this.lblTown.Text = "Town";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(20, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 16);
            this.lblLastName.TabIndex = 95;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtLastName.Location = new System.Drawing.Point(117, 79);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // lblcust_ID
            // 
            this.lblcust_ID.AutoSize = true;
            this.lblcust_ID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_ID.Location = new System.Drawing.Point(20, 28);
            this.lblcust_ID.Name = "lblcust_ID";
            this.lblcust_ID.Size = new System.Drawing.Size(82, 16);
            this.lblcust_ID.TabIndex = 93;
            this.lblcust_ID.Text = "Customer ID";
            // 
            // txtcustID
            // 
            this.txtcustID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtcustID.Enabled = false;
            this.txtcustID.Location = new System.Drawing.Point(118, 21);
            this.txtcustID.MaxLength = 3;
            this.txtcustID.Name = "txtcustID";
            this.txtcustID.Size = new System.Drawing.Size(31, 23);
            this.txtcustID.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtAddress.Location = new System.Drawing.Point(117, 112);
            this.txtAddress.MaxLength = 25;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 23);
            this.txtAddress.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtFirstName.Location = new System.Drawing.Point(117, 50);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 119);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 16);
            this.lblAddress.TabIndex = 87;
            this.lblAddress.Text = "Address";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(20, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 16);
            this.lblFirstName.TabIndex = 86;
            this.lblFirstName.Text = "First Name";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.menu.ForeColor = System.Drawing.Color.Black;
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(43, 22);
            this.menu.Text = "menu";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 22);
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // FrmAdminAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAdminAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVDsys-AddMember";
            this.Load += new System.EventHandler(this.FrmAdminAddMember_Load);
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Label lblcust_ID;
        private System.Windows.Forms.TextBox txtcustID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menu;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.ComboBox cboCounties;
    }
}