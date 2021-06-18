namespace DVDsys
{
    partial class FrmAdminDeleteDvd
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
            System.Windows.Forms.Button btnRemoveDvd;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDeleteDvd));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpMovies = new System.Windows.Forms.GroupBox();
            this.grpDVD = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGenres = new System.Windows.Forms.ComboBox();
            this.cboAgeRatings = new System.Windows.Forms.ComboBox();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.lbldvd_id = new System.Windows.Forms.Label();
            this.txtdvdID = new System.Windows.Forms.TextBox();
            this.txtRunningTime = new System.Windows.Forms.TextBox();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboMovies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            btnRemoveDvd = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.grpMovies.SuspendLayout();
            this.grpDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveDvd
            // 
            btnRemoveDvd.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            btnRemoveDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            btnRemoveDvd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(127)))), ((int)(((byte)(104)))));
            btnRemoveDvd.ForeColor = System.Drawing.Color.Black;
            btnRemoveDvd.Location = new System.Drawing.Point(133, 256);
            btnRemoveDvd.Name = "btnRemoveDvd";
            btnRemoveDvd.Size = new System.Drawing.Size(193, 48);
            btnRemoveDvd.TabIndex = 7;
            btnRemoveDvd.Text = "Delete DVD";
            btnRemoveDvd.UseVisualStyleBackColor = false;
            btnRemoveDvd.Click += new System.EventHandler(this.btnRemoveDvd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 25);
            this.toolStrip1.TabIndex = 10;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Case Sensitive";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(389, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // grpMovies
            // 
            this.grpMovies.Controls.Add(this.grpDVD);
            this.grpMovies.Controls.Add(this.cboMovies);
            this.grpMovies.Controls.Add(this.label1);
            this.grpMovies.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.grpMovies.Location = new System.Drawing.Point(33, 95);
            this.grpMovies.Name = "grpMovies";
            this.grpMovies.Size = new System.Drawing.Size(1078, 507);
            this.grpMovies.TabIndex = 69;
            this.grpMovies.TabStop = false;
            this.grpMovies.Text = "Select movie";
            this.grpMovies.Visible = false;
            // 
            // grpDVD
            // 
            this.grpDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.grpDVD.Controls.Add(this.label5);
            this.grpDVD.Controls.Add(this.label2);
            this.grpDVD.Controls.Add(this.cboGenres);
            this.grpDVD.Controls.Add(this.cboAgeRatings);
            this.grpDVD.Controls.Add(this.cboCategories);
            this.grpDVD.Controls.Add(this.lbldvd_id);
            this.grpDVD.Controls.Add(this.txtdvdID);
            this.grpDVD.Controls.Add(this.txtRunningTime);
            this.grpDVD.Controls.Add(this.lblRunningTime);
            this.grpDVD.Controls.Add(this.txtDirector);
            this.grpDVD.Controls.Add(this.txtTitle);
            this.grpDVD.Controls.Add(this.lblDirector);
            this.grpDVD.Controls.Add(this.label4);
            this.grpDVD.Controls.Add(this.lblAgeRating);
            this.grpDVD.Controls.Add(this.lblCategory);
            this.grpDVD.Controls.Add(btnRemoveDvd);
            this.grpDVD.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDVD.ForeColor = System.Drawing.Color.Black;
            this.grpDVD.Location = new System.Drawing.Point(356, 69);
            this.grpDVD.Name = "grpDVD";
            this.grpDVD.Size = new System.Drawing.Size(367, 369);
            this.grpDVD.TabIndex = 64;
            this.grpDVD.TabStop = false;
            this.grpDVD.Text = "Remove DVD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Genre";
            // 
            // cboGenres
            // 
            this.cboGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.cboGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenres.Enabled = false;
            this.cboGenres.FormattingEnabled = true;
            this.cboGenres.Location = new System.Drawing.Point(110, 94);
            this.cboGenres.Name = "cboGenres";
            this.cboGenres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboGenres.Size = new System.Drawing.Size(112, 23);
            this.cboGenres.TabIndex = 3;
            // 
            // cboAgeRatings
            // 
            this.cboAgeRatings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.cboAgeRatings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeRatings.Enabled = false;
            this.cboAgeRatings.FormattingEnabled = true;
            this.cboAgeRatings.Location = new System.Drawing.Point(110, 123);
            this.cboAgeRatings.Name = "cboAgeRatings";
            this.cboAgeRatings.Size = new System.Drawing.Size(192, 23);
            this.cboAgeRatings.TabIndex = 4;
            // 
            // cboCategories
            // 
            this.cboCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategories.Enabled = false;
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(110, 65);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCategories.Size = new System.Drawing.Size(112, 23);
            this.cboCategories.TabIndex = 2;
            // 
            // lbldvd_id
            // 
            this.lbldvd_id.AutoSize = true;
            this.lbldvd_id.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldvd_id.Location = new System.Drawing.Point(23, 39);
            this.lbldvd_id.Name = "lbldvd_id";
            this.lbldvd_id.Size = new System.Drawing.Size(56, 16);
            this.lbldvd_id.TabIndex = 93;
            this.lbldvd_id.Text = "DVD ID";
            // 
            // txtdvdID
            // 
            this.txtdvdID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtdvdID.Enabled = false;
            this.txtdvdID.Location = new System.Drawing.Point(110, 36);
            this.txtdvdID.MaxLength = 35;
            this.txtdvdID.Name = "txtdvdID";
            this.txtdvdID.Size = new System.Drawing.Size(28, 23);
            this.txtdvdID.TabIndex = 92;
            this.txtdvdID.Tag = "1";
            // 
            // txtRunningTime
            // 
            this.txtRunningTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtRunningTime.Enabled = false;
            this.txtRunningTime.Location = new System.Drawing.Point(110, 210);
            this.txtRunningTime.MaxLength = 3;
            this.txtRunningTime.Name = "txtRunningTime";
            this.txtRunningTime.Size = new System.Drawing.Size(26, 23);
            this.txtRunningTime.TabIndex = 7;
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningTime.Location = new System.Drawing.Point(20, 213);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(88, 16);
            this.lblRunningTime.TabIndex = 90;
            this.lblRunningTime.Text = "Running Time";
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtDirector.Enabled = false;
            this.txtDirector.Location = new System.Drawing.Point(110, 181);
            this.txtDirector.MaxLength = 35;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(216, 23);
            this.txtDirector.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(110, 152);
            this.txtTitle.MaxLength = 35;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(216, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(20, 181);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(55, 16);
            this.lblDirector.TabIndex = 87;
            this.lblDirector.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Title";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeRating.Location = new System.Drawing.Point(20, 123);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(70, 16);
            this.lblAgeRating.TabIndex = 85;
            this.lblAgeRating.Text = "Age Rating";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(20, 65);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 16);
            this.lblCategory.TabIndex = 84;
            this.lblCategory.Text = "Category";
            // 
            // cboMovies
            // 
            this.cboMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.cboMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMovies.FormattingEnabled = true;
            this.cboMovies.Location = new System.Drawing.Point(92, 27);
            this.cboMovies.Name = "cboMovies";
            this.cboMovies.Size = new System.Drawing.Size(240, 24);
            this.cboMovies.TabIndex = 3;
            this.cboMovies.SelectedIndexChanged += new System.EventHandler(this.CboMovies_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Select Movie";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            this.txtTitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleSearch.Location = new System.Drawing.Point(151, 28);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(214, 23);
            this.txtTitleSearch.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblTitle.Location = new System.Drawing.Point(-2, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 16);
            this.lblTitle.TabIndex = 67;
            this.lblTitle.Text = "Enter Title (or part of...)";
            // 
            // FrmAdminDeleteDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1164, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpMovies);
            this.Controls.Add(this.txtTitleSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAdminDeleteDvd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Form";
            this.Load += new System.EventHandler(this.FrmAdminDeleteDvd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpMovies.ResumeLayout(false);
            this.grpMovies.PerformLayout();
            this.grpDVD.ResumeLayout(false);
            this.grpDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menu;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpMovies;
        private System.Windows.Forms.ComboBox cboMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDVD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGenres;
        private System.Windows.Forms.ComboBox cboAgeRatings;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.Label lbldvd_id;
        private System.Windows.Forms.TextBox txtdvdID;
        private System.Windows.Forms.TextBox txtRunningTime;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label5;
    }
}