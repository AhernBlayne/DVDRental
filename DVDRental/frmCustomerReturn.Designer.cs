namespace DVDsys
{
	partial class FrmCustomerReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerReturn));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.grpReturn = new System.Windows.Forms.GroupBox();
            this.lblLate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.cboMovies = new System.Windows.Forms.ComboBox();
            this.btnReturnDvd = new System.Windows.Forms.Button();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.grpValidation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboCounties = new System.Windows.Forms.ComboBox();
            this.txtPin2 = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblcust_ID = new System.Windows.Forms.Label();
            this.txtCustID2 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.grpReturn.SuspendLayout();
            this.grpValidation.SuspendLayout();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 25);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(42, 22);
            this.menu.Text = "menu";
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 22);
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // grpReturn
            // 
            this.grpReturn.Controls.Add(this.label9);
            this.grpReturn.Controls.Add(this.lblLate);
            this.grpReturn.Controls.Add(this.txtPrice);
            this.grpReturn.Controls.Add(this.label7);
            this.grpReturn.Controls.Add(this.label5);
            this.grpReturn.Controls.Add(this.label4);
            this.grpReturn.Controls.Add(this.label3);
            this.grpReturn.Controls.Add(this.dtpRentDate);
            this.grpReturn.Controls.Add(this.cboMovies);
            this.grpReturn.Controls.Add(this.btnReturnDvd);
            this.grpReturn.Controls.Add(this.dtpReturnDate);
            this.grpReturn.Location = new System.Drawing.Point(285, 67);
            this.grpReturn.Name = "grpReturn";
            this.grpReturn.Size = new System.Drawing.Size(397, 278);
            this.grpReturn.TabIndex = 92;
            this.grpReturn.TabStop = false;
            this.grpReturn.Text = "Return!";
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Location = new System.Drawing.Point(203, 131);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(31, 13);
            this.lblLate.TabIndex = 101;
            this.lblLate.Text = "Late!";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtPrice.Location = new System.Drawing.Point(122, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Payment Owed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Rent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Currently Renting";
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.CustomFormat = "dd.MMM.yy";
            this.dtpRentDate.Enabled = false;
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentDate.Location = new System.Drawing.Point(122, 84);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(75, 20);
            this.dtpRentDate.TabIndex = 30;
            // 
            // cboMovies
            // 
            this.cboMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.cboMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovies.FormattingEnabled = true;
            this.cboMovies.Location = new System.Drawing.Point(122, 35);
            this.cboMovies.Name = "cboMovies";
            this.cboMovies.Size = new System.Drawing.Size(235, 21);
            this.cboMovies.TabIndex = 65;
            this.cboMovies.SelectedIndexChanged += new System.EventHandler(this.cboMovies_SelectedIndexChanged_1);
            // 
            // btnReturnDvd
            // 
            this.btnReturnDvd.Location = new System.Drawing.Point(122, 229);
            this.btnReturnDvd.Name = "btnReturnDvd";
            this.btnReturnDvd.Size = new System.Drawing.Size(115, 43);
            this.btnReturnDvd.TabIndex = 21;
            this.btnReturnDvd.Text = "Return Dvd";
            this.btnReturnDvd.UseVisualStyleBackColor = true;
            this.btnReturnDvd.Click += new System.EventHandler(this.btnReturnDvd_Click_1);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "dd.MMM.yy";
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(122, 125);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(75, 20);
            this.dtpReturnDate.TabIndex = 31;
            // 
            // grpValidation
            // 
            this.grpValidation.Controls.Add(this.label2);
            this.grpValidation.Controls.Add(this.label1);
            this.grpValidation.Controls.Add(this.btnSignIn);
            this.grpValidation.Controls.Add(this.txtCustID);
            this.grpValidation.Controls.Add(this.txtPin);
            this.grpValidation.Location = new System.Drawing.Point(6, 67);
            this.grpValidation.Name = "grpValidation";
            this.grpValidation.Size = new System.Drawing.Size(153, 180);
            this.grpValidation.TabIndex = 91;
            this.grpValidation.TabStop = false;
            this.grpValidation.Text = "Sign In!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Pin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Cust ID";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(63, 131);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 88;
            this.btnSignIn.Text = "Sign In!";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click_1);
            // 
            // txtCustID
            // 
            this.txtCustID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtCustID.Location = new System.Drawing.Point(63, 45);
            this.txtCustID.MaxLength = 3;
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(26, 20);
            this.txtCustID.TabIndex = 87;
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtPin.Location = new System.Drawing.Point(63, 91);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(31, 20);
            this.txtPin.TabIndex = 86;
            // 
            // grpMember
            // 
            this.grpMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.grpMember.Controls.Add(this.pictureBox1);
            this.grpMember.Controls.Add(this.cboCounties);
            this.grpMember.Controls.Add(this.txtPin2);
            this.grpMember.Controls.Add(this.lblPin);
            this.grpMember.Controls.Add(this.lblPhoneNumber);
            this.grpMember.Controls.Add(this.lblCounty);
            this.grpMember.Controls.Add(this.txtPhoneNumber);
            this.grpMember.Controls.Add(this.txtTown);
            this.grpMember.Controls.Add(this.lblTown);
            this.grpMember.Controls.Add(this.lblLastName);
            this.grpMember.Controls.Add(this.txtLastName);
            this.grpMember.Controls.Add(this.lblcust_ID);
            this.grpMember.Controls.Add(this.txtCustID2);
            this.grpMember.Controls.Add(this.txtAddress);
            this.grpMember.Controls.Add(this.txtFirstName);
            this.grpMember.Controls.Add(this.lblAddress);
            this.grpMember.Controls.Add(this.lblFirstName);
            this.grpMember.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMember.ForeColor = System.Drawing.Color.Black;
            this.grpMember.Location = new System.Drawing.Point(6, 67);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(273, 338);
            this.grpMember.TabIndex = 102;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVDRental.Properties.Resources.iconfinder_user_2561496__2_;
            this.pictureBox1.Location = new System.Drawing.Point(108, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // cboCounties
            // 
            this.cboCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounties.Enabled = false;
            this.cboCounties.FormattingEnabled = true;
            this.cboCounties.Location = new System.Drawing.Point(109, 249);
            this.cboCounties.Name = "cboCounties";
            this.cboCounties.Size = new System.Drawing.Size(159, 23);
            this.cboCounties.TabIndex = 104;
            // 
            // txtPin2
            // 
            this.txtPin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtPin2.Enabled = false;
            this.txtPin2.Location = new System.Drawing.Point(109, 307);
            this.txtPin2.MaxLength = 4;
            this.txtPin2.Name = "txtPin2";
            this.txtPin2.Size = new System.Drawing.Size(31, 23);
            this.txtPin2.TabIndex = 103;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(11, 314);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(26, 16);
            this.lblPin.TabIndex = 102;
            this.lblPin.Text = "Pin";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(11, 285);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(93, 16);
            this.lblPhoneNumber.TabIndex = 101;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(11, 256);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(49, 16);
            this.lblCounty.TabIndex = 100;
            this.lblCounty.Text = "County";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(109, 278);
            this.txtPhoneNumber.MaxLength = 15;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(159, 23);
            this.txtPhoneNumber.TabIndex = 99;
            // 
            // txtTown
            // 
            this.txtTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtTown.Enabled = false;
            this.txtTown.Location = new System.Drawing.Point(109, 220);
            this.txtTown.MaxLength = 25;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(159, 23);
            this.txtTown.TabIndex = 97;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(11, 227);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(41, 16);
            this.lblTown.TabIndex = 96;
            this.lblTown.Text = "Town";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(11, 164);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 16);
            this.lblLastName.TabIndex = 95;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(108, 157);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 23);
            this.txtLastName.TabIndex = 94;
            // 
            // lblcust_ID
            // 
            this.lblcust_ID.AutoSize = true;
            this.lblcust_ID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_ID.Location = new System.Drawing.Point(11, 106);
            this.lblcust_ID.Name = "lblcust_ID";
            this.lblcust_ID.Size = new System.Drawing.Size(82, 16);
            this.lblcust_ID.TabIndex = 93;
            this.lblcust_ID.Text = "Customer ID";
            // 
            // txtCustID2
            // 
            this.txtCustID2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtCustID2.Enabled = false;
            this.txtCustID2.Location = new System.Drawing.Point(109, 99);
            this.txtCustID2.MaxLength = 3;
            this.txtCustID2.Name = "txtCustID2";
            this.txtCustID2.Size = new System.Drawing.Size(31, 23);
            this.txtCustID2.TabIndex = 92;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(108, 190);
            this.txtAddress.MaxLength = 25;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 23);
            this.txtAddress.TabIndex = 89;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(108, 128);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 23);
            this.txtFirstName.TabIndex = 88;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(11, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 16);
            this.lblAddress.TabIndex = 87;
            this.lblAddress.Text = "Address";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(11, 135);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 16);
            this.lblFirstName.TabIndex = 86;
            this.lblFirstName.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 107;
            this.label9.Text = "€";
            // 
            // FrmCustomerReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.grpReturn);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCustomerReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerReturn";
            this.Load += new System.EventHandler(this.FrmCustomerReturn_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpReturn.ResumeLayout(false);
            this.grpReturn.PerformLayout();
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton menu;
		private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.GroupBox grpReturn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.ComboBox cboMovies;
        private System.Windows.Forms.Button btnReturnDvd;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.GroupBox grpValidation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboCounties;
        private System.Windows.Forms.TextBox txtPin2;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblcust_ID;
        private System.Windows.Forms.TextBox txtCustID2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label9;
    }
}