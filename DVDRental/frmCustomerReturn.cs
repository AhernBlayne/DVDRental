using DVDRental;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVDsys
{
    public partial class FrmCustomerReturn : Form
    {
        Transactions myTransaction = new Transactions();

        RentalItems myRentals = new RentalItems();

        DVD myDVD = new DVD();

        Category myCat = new Category();

        Member myMember = new Member();

        bool isLate = false;
        public FrmCustomerReturn()
        {
            InitializeComponent();
        }
        private void FrmCustomerReturn_Load(object sender, EventArgs e)
        {
            CleanForm();

            Utility.LoadCounties(cboCounties);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            FrmDvd mainMenu = new FrmDvd();

            mainMenu.Show();

            this.Close();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            validation();
        }

        private void btnReturnDvd_Click_1(object sender, EventArgs e)
        {
            ReturnDvd();

            FrmCustomerReturn returnDvd = new FrmCustomerReturn();

            returnDvd.Show();

            this.Close();
        }

        private void cboMovies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPrice.Clear();

            SetDates();

            SetPrice();
        }

        public void SetDates()
        {
            myRentals.GetRentalItems(Convert.ToInt32(cboMovies.SelectedItem.ToString().Substring(0, 2)));

            myTransaction.GetTransactions(Convert.ToInt32(txtCustID.Text));

            String id = cboMovies.SelectedItem.ToString().Substring(0, 2);

            myDVD.SetDvd_ID(Convert.ToInt32(id));

            myDVD.GetDvd(Convert.ToInt32(id));

            myCat.SetCat_Code(myDVD.GetCat_Code());

            myCat.GetCategory(myDVD.GetCat_Code());

            dtpRentDate.Value = myTransaction.GetRentDate();

            dtpReturnDate.Value = myTransaction.GetReturnDate();

        }
        public void SetPrice()
        {

            if (myRentals.LateCheck(myDVD.GetDvd_ID()) > 0)
            {
                lblLate.Visible = true;

                DateTime d1 = DateTime.Now;

                MessageBox.Show("This dvd is late. It should have been returned on " + myTransaction.GetReturnDate() + " But was returned on " + d1);

                TimeSpan t2 = d1 - myTransaction.GetRentDate();

                float totalDays = t2.Days;

                float total = myCat.getRate() * totalDays;

                txtPrice.Text = total.ToString("00.00");

                RentalItems r = new RentalItems();

                r.SetDvdID(myDVD.GetDvd_ID());

                r.SetReturnDate(dtpReturnDate.Value.AddDays(totalDays));

                r.SetFine(float.Parse(txtPrice.Text));

                isLate = true;

            }
            else
            {
                lblLate.Visible = false;
                txtPrice.Text = myCat.getRate().ToString("00.00");
            }
        }

        public void validation()
        {
            //validate information entered i.e make sure pin is numbers

            if (Convert.ToString(txtCustID.Text) == "")
            {
                MessageBox.Show("Cust ID cannot be blank!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(Convert.ToString(txtCustID.Text), @"^[0-9]+$"))
            {
                MessageBox.Show("Cust ID must contain numbers!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtCustID.Text) > Member.GetNextID())
            {
                MessageBox.Show("Cust ID Does not exist!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtCustID.Text) < 1)
            {
                MessageBox.Show("Cust ID Does not exist!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(txtPin.Text).Length != 4)
            {
                MessageBox.Show("Pin must be 4 characters long!", "Invalid Pin!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Convert.ToString(txtPin.Text) == "")
            {
                MessageBox.Show("Pin must also not be blank!", "Invalid Pin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(Convert.ToString(txtPin.Text), @"^[0-9]+$"))
            {
                MessageBox.Show("Pin must only contain numbers!", "Invalid Pin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                databaseValidation();

            }
        }
        public void databaseValidation()
        {

            if (myMember.ValidateMember(Convert.ToInt32(txtCustID.Text), txtPin.Text) == true)
            {

                MatchMovies();

                grpReturn.Visible = true;

                grpValidation.Visible = false;

                grpMember.Visible = true;

                DetailsForViewing();

            }
            else
            {
                MessageBox.Show("not Valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

        }

        private void MatchMovies()
        {
            cboMovies.Items.Clear();

            DataSet ds = DVD.GetSummaryTransactions(Convert.ToInt32(txtCustID.Text));

            for (int i = 0; i < ds.Tables["TRA"].Rows.Count; i++)
                cboMovies.Items.Add(" " + ds.Tables[0].Rows[i][0].ToString().PadRight(2, ' ') + "  Title:" + ds.Tables[0].Rows[i][1].ToString().PadRight(2, ' ') + "     " + ds.Tables[0].Rows[i][2].ToString().PadRight(2, ' ') + "  ");

        }
        public void ReturnDvd()

        {
            if (isLate == true)
            {
                myDVD.UpdateDvdA(Convert.ToInt32(cboMovies.SelectedItem.ToString().Substring(0, 2)));

                myTransaction.UpdateTransaction();

                MessageBox.Show("Return successful!", "");

                CleanForm();
            }
            else
            {
                myDVD.UpdateDvdA(Convert.ToInt32(cboMovies.SelectedItem.ToString().Substring(0, 2)));

                MessageBox.Show("Return successful!", "");

                CleanForm();
            }

        }
        public void CleanForm()
        {
            grpMember.Visible = false;

            grpReturn.Visible = false;

            txtCustID.Clear();

            txtPin.Clear();

            txtPrice.Clear();

            lblLate.Visible = false;

        }

        public void DetailsForViewing()
        {

            //create an instance of DVD and call a method to instantiate it's instance variables

            myMember.GetAMember(Convert.ToInt32(txtCustID.Text));

            //move values from instance variables to form controls

            txtCustID2.Text = myMember.GetCustID().ToString("000"); 

            txtFirstName.Text = myMember.GetFirstName().ToString();

            txtLastName.Text = myMember.GetLastName().ToString();

            txtAddress.Text = myMember.GetAddress().ToString();

            txtTown.Text = myMember.GetTown().ToString();

            cboCounties.SelectedIndex = 0;

            while (myMember.GetCountyCode().ToString() != cboCounties.SelectedItem.ToString().Substring(0, 2))
            {
                cboCounties.SelectedIndex = cboCounties.SelectedIndex + 1;

            }

            txtPhoneNumber.Text = myMember.GetPhoneNumber().ToString();

            txtPin2.Text = myMember.GetPin().ToString();

            //display the DVD for updating

            grpMember.Visible = true;

        }

    }
}