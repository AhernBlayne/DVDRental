namespace DVDsys
{
	partial class FrmCustomerRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerRent));
            this.btnRentDvd = new System.Windows.Forms.Button();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.cboMovies = new System.Windows.Forms.ComboBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.grpValidation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.grpRent = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbodays = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1.SuspendLayout();
            this.grpValidation.SuspendLayout();
            this.grpRent.SuspendLayout();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRentDvd
            // 
            this.btnRentDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.btnRentDvd.Location = new System.Drawing.Point(210, 227);
            this.btnRentDvd.Name = "btnRentDvd";
            this.btnRentDvd.Size = new System.Drawing.Size(91, 43);
            this.btnRentDvd.TabIndex = 21;
            this.btnRentDvd.Text = "Rent Dvd!";
            this.btnRentDvd.UseVisualStyleBackColor = false;
            this.btnRentDvd.Click += new System.EventHandler(this.BtnRentDvd_Click);
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.CustomFormat = "dd.MMM.yy";
            this.dtpRentDate.Enabled = false;
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentDate.Location = new System.Drawing.Point(104, 134);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(75, 22);
            this.dtpRentDate.TabIndex = 30;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "dd.MMM.yy";
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(104, 175);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(75, 22);
            this.dtpReturnDate.TabIndex = 31;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.Black;
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(40, 22);
            this.menu.Text = "menu";
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 22);
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // cboMovies
            // 
            this.cboMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovies.FormattingEnabled = true;
            this.cboMovies.Location = new System.Drawing.Point(104, 40);
            this.cboMovies.Name = "cboMovies";
            this.cboMovies.Size = new System.Drawing.Size(197, 23);
            this.cboMovies.TabIndex = 65;
            this.cboMovies.SelectedIndexChanged += new System.EventHandler(this.cboMovies_SelectedIndexChanged);
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtPin.Location = new System.Drawing.Point(69, 89);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(31, 22);
            this.txtPin.TabIndex = 86;
            // 
            // grpValidation
            // 
            this.grpValidation.Controls.Add(this.label2);
            this.grpValidation.Controls.Add(this.label1);
            this.grpValidation.Controls.Add(this.btnSignIn);
            this.grpValidation.Controls.Add(this.txtCustID);
            this.grpValidation.Controls.Add(this.txtPin);
            this.grpValidation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpValidation.ForeColor = System.Drawing.Color.Black;
            this.grpValidation.Location = new System.Drawing.Point(12, 62);
            this.grpValidation.Name = "grpValidation";
            this.grpValidation.Size = new System.Drawing.Size(166, 180);
            this.grpValidation.TabIndex = 87;
            this.grpValidation.TabStop = false;
            this.grpValidation.Text = "Sign In!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 90;
            this.label2.Text = "Pin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 89;
            this.label1.Text = "Cust ID";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(69, 130);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 88;
            this.btnSignIn.Text = "Sign In!";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtCustID.Location = new System.Drawing.Point(69, 47);
            this.txtCustID.MaxLength = 3;
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(26, 22);
            this.txtCustID.TabIndex = 87;
            // 
            // grpRent
            // 
            this.grpRent.Controls.Add(this.label10);
            this.grpRent.Controls.Add(this.label9);
            this.grpRent.Controls.Add(this.label8);
            this.grpRent.Controls.Add(this.txtTotal);
            this.grpRent.Controls.Add(this.btnRemoveFromCart);
            this.grpRent.Controls.Add(this.lblCart);
            this.grpRent.Controls.Add(this.btnAdd);
            this.grpRent.Controls.Add(this.lstCart);
            this.grpRent.Controls.Add(this.txtPrice);
            this.grpRent.Controls.Add(this.label7);
            this.grpRent.Controls.Add(this.label6);
            this.grpRent.Controls.Add(this.cbodays);
            this.grpRent.Controls.Add(this.label5);
            this.grpRent.Controls.Add(this.label4);
            this.grpRent.Controls.Add(this.label3);
            this.grpRent.Controls.Add(this.dtpRentDate);
            this.grpRent.Controls.Add(this.cboMovies);
            this.grpRent.Controls.Add(this.btnRentDvd);
            this.grpRent.Controls.Add(this.dtpReturnDate);
            this.grpRent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRent.ForeColor = System.Drawing.Color.Black;
            this.grpRent.Location = new System.Drawing.Point(309, 62);
            this.grpRent.Name = "grpRent";
            this.grpRent.Size = new System.Drawing.Size(647, 353);
            this.grpRent.TabIndex = 88;
            this.grpRent.TabStop = false;
            this.grpRent.Text = "Rent!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 15);
            this.label10.TabIndex = 107;
            this.label10.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 106;
            this.label9.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 103;
            this.label8.Text = "Total Price";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(342, 146);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(30, 22);
            this.txtTotal.TabIndex = 102;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(398, 227);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(85, 43);
            this.btnRemoveFromCart.TabIndex = 101;
            this.btnRemoveFromCart.Text = "Remove From Cart!";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click_1);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(322, 33);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(98, 15);
            this.lblCart.TabIndex = 90;
            this.lblCart.Tag = "";
            this.lblCart.Text = "Shopping Basket";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.btnAdd.Location = new System.Drawing.Point(307, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 43);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add To Cart!";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 15;
            this.lstCart.Location = new System.Drawing.Point(325, 60);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(269, 49);
            this.lstCart.TabIndex = 89;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(121, 218);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(30, 22);
            this.txtPrice.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 99;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Days to Rent";
            // 
            // cbodays
            // 
            this.cbodays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbodays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodays.FormattingEnabled = true;
            this.cbodays.Items.AddRange(new object[] {
            "1"});
            this.cbodays.Location = new System.Drawing.Point(104, 76);
            this.cbodays.Name = "cbodays";
            this.cbodays.Size = new System.Drawing.Size(47, 23);
            this.cbodays.TabIndex = 97;
            this.cbodays.SelectedIndexChanged += new System.EventHandler(this.cbodays_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(693, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 96;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtTitleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtTitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleSearch.Location = new System.Drawing.Point(473, 33);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(214, 23);
            this.txtTitleSearch.TabIndex = 95;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblTitle.Location = new System.Drawing.Point(320, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 16);
            this.lblTitle.TabIndex = 94;
            this.lblTitle.Text = "Enter Title (or part of...)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 92;
            this.label4.Text = "Rent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 91;
            this.label3.Text = "DVD";
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
            this.grpMember.Location = new System.Drawing.Point(12, 62);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(273, 338);
            this.grpMember.TabIndex = 89;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // FrmCustomerRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1064, 441);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.grpRent);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitleSearch);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FrmCustomerRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerRent";
            this.Load += new System.EventHandler(this.FrmCustomerRent_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            this.grpRent.ResumeLayout(false);
            this.grpRent.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnRentDvd;
		private System.Windows.Forms.DateTimePicker dtpRentDate;
		private System.Windows.Forms.DateTimePicker dtpReturnDate;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton menu;
		private System.Windows.Forms.ToolStripButton exit;
		private System.Windows.Forms.ComboBox cboMovies;
		private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.GroupBox grpValidation;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.GroupBox grpRent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbodays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpMember;
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}