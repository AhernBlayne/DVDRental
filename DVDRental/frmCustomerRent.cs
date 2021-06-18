using DVDRental;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVDsys
{
    public partial class FrmCustomerRent : Form
    {
        DVD myDVD = new DVD();

        Category myCat = new Category();

        RentalItems[] rents = new RentalItems[3];

        int i = 0;

        int count = 0;

        int latest = Transactions.GetCountId();

        Member myMember = new Member();

        double total = 0.00;

        Transactions t = new Transactions();

        public FrmCustomerRent()
        {
            InitializeComponent();
        }

        private void FrmCustomerRent_Load(object sender, EventArgs e)
        {
            CleanForm();

            Utility.LoadCounties(cboCounties);
        }

        private void BtnRentDvd_Click(object sender, EventArgs e)
        {
            RentDvd();

            FrmCustomerRent rentDvd = new FrmCustomerRent();

            rentDvd.Show();

            this.Close();
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (validation())
                databaseValidation();
        }

        private void cbodays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovies.SelectedIndex == -1) {
                MessageBox.Show("Please select a movie!");
            }
            else
            {
                SetPrice();
            }

        }

        private void cboMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Clear();
            cbodays.SelectedIndex = -1;
            SetDvd();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            cboMovies.Items.Clear();
            txtPrice.Clear();
           
            if (txtTitleSearch.Text != "" && myDVD.CheckDVD(txtTitleSearch.Text) == true)
            {
                MatchMovies();

                grpRent.Visible = true;

                btnAdd.Visible = true;

                lblCart.Visible = true;
            }
            else { MessageBox.Show("That movie does not exist in our database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbodays.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a number of days to rent!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddToCart();
            }
        }

        public void RentDvd()
        {
            //https://stackoverflow.com/questions/22540855/calculate-difference-between-2-dates-from-datetimepicker where i learned to count the dates

            Transactions t = new Transactions();

            t.SetCustID(Convert.ToInt32(txtCustID.Text));
            t.SetRentalID(latest);
            t.SetRentDate(dtpRentDate.Value);
            t.SetReturnDate(dtpReturnDate.Value);
            t.SetTotal(float.Parse(txtTotal.Text));

            t.AddTransaction();

            for (int i = 0; i < count; i++)
            {

                rents[i].AddRentalItem();

                myDVD.SetDvd_ID(rents[i].GetDVDID());

                myDVD.UpdateDvdO();

            }
            CleanForm();

            MessageBox.Show("Rent successful!", "");

            lstCart.SelectedIndex = -1;
            for (int i = 0; i < count; i++)
            {
                if (lstCart.SelectedIndex == count)
                {
                    lstCart.SelectedIndex = count;
                    MessageBox.Show("You have rented " + count + " Dvds." + " Title: " + Convert.ToString(lstCart.SelectedItem) + " Rent Date: " + Convert.ToString(DateTime.Now.AddDays(1)) + " Return Date: " + Convert.ToString(rents[i].GetReturnDate()) + " Total: €" + Convert.ToString(DateTime.Now.AddDays(1)), " ");
                }
                else
                {
                    lstCart.SelectedIndex += 1;
                    MessageBox.Show("You have rented " + count + " Dvds." + " Title: " + Convert.ToString(lstCart.SelectedItem) + " Rent Date: " + Convert.ToString(DateTime.Now.AddDays(1)) + " Return Date: " + Convert.ToString(rents[i].GetReturnDate()) + " Total: €" + Convert.ToString(DateTime.Now.AddDays(1)), " ");
                }
            }
        }
        public void SetDvd()
        {
            String id = cboMovies.SelectedItem.ToString().Substring(0, 2);

            myDVD.SetDvd_ID(Convert.ToInt32(id));

            myDVD.GetDvd(Convert.ToInt32(id));
        }
        public void AddToCart()
        {
            lstCart.Visible = true;

            if (!lstCart.Items.Contains(myDVD.GetDvd_ID().ToString().PadRight(4, ' ') + myDVD.GetTitle().ToString()))
            {
                if (lstCart.Items.Count >= 3 && rents.Length >= 3)
                {
                    MessageBox.Show("Your cart is full!", "Full!");
                }
                else
                {
                    RentalItems r = new RentalItems();

                    Transactions t = new Transactions();

                    r.SetDvdID(myDVD.GetDvd_ID());

                    r.SetRentalID(latest);

                    r.SetFine(0);

                    r.SetReturnDate(dtpRentDate.Value.AddDays(1));

                    t.SetCustID(Convert.ToInt32(txtCustID.Text));

                    t.SetRentalID(latest);

                    t.SetRentDate(dtpRentDate.Value);

                    t.SetReturnDate(dtpRentDate.Value.AddDays(1));

                    rents[i] = r;

                    lstCart.Items.Add(myDVD.GetDvd_ID().ToString().PadRight(4, ' ') + myDVD.GetTitle().ToString());

                    total += (Convert.ToDouble(txtPrice.Text));

                    txtTotal.Text = total.ToString("0.00");

                    i++;

                    count++;

                    
                }

            }
            else
            {
                MessageBox.Show("Cannot rent the same dvd twice!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SetPrice()
        {
            if (cbodays.SelectedIndex == 0)
            {
                dtpReturnDate.Value = dtpRentDate.Value;

                dtpReturnDate.Value = dtpReturnDate.Value.AddDays(1);

                myCat.GetCategory(myDVD.GetCat_Code());

                txtPrice.Text = myCat.getRate().ToString("0.00");

            }

        }
        public void CleanForm()
        {

            btnSearch.Visible = false;

            txtTitleSearch.Visible = false;

            lblTitle.Visible = false;

            grpMember.Visible = false;

            grpRent.Visible = false;

            lstCart.Visible = false;

            btnAdd.Visible = false;

            lblCart.Visible = false;

            txtCustID.Clear();

            txtPin.Clear();

            txtPrice.Clear();

            txtTitleSearch.Clear();

        }
        private void MatchMovies()
        {
                cboMovies.Items.Clear();

                DataSet ds = DVD.GetSummaryDVDs(txtTitleSearch.Text);

                for (int i = 0; i < ds.Tables["DVD"].Rows.Count; i++)
                    cboMovies.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadRight(4, ' ') + " " + ds.Tables[0].Rows[i][5].ToString().PadRight(4, ' '));
            
        }

        public Boolean validation()
        {
            //validate information entered i.e make sure pin is numbers

            bool valid = true;

            if (Convert.ToString(txtCustID.Text) == "")
            {
                MessageBox.Show("Cust ID cannot be blank!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (!Regex.IsMatch(Convert.ToString(txtCustID.Text), @"^[0-9]+$"))
            {
                MessageBox.Show("Cust ID must contain numbers!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (Convert.ToInt32(txtCustID.Text) > Member.GetNextID())
            {
                MessageBox.Show("Cust ID Does not exist!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (Convert.ToInt32(txtCustID.Text) < 1)
            {
                MessageBox.Show("Cust ID Does not exist!", "Invalid ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (Convert.ToString(txtPin.Text).Length != 4)
            {
                MessageBox.Show("Pin must be 4 characters long!", "Invalid Pin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;

            }
            else if (Convert.ToString(txtPin.Text) == "")
            {
                MessageBox.Show("Pin must also not be blank!", "Invalid Pin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (!Regex.IsMatch(Convert.ToString(txtPin.Text), @"^[0-9]+$"))
            {
                MessageBox.Show("Pin must only contain numbers!", "Invalid Pin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;
        }

        private void btnRemoveFromCart_Click_1(object sender, EventArgs e)
        { 

            if (lstCart.SelectedIndex > -1)
            { 
               
                myDVD.GetDvd(Convert.ToInt32(lstCart.SelectedItem.ToString().Substring(0, 2)));

                int y = lstCart.SelectedIndex;

                lstCart.Items.RemoveAt(y);

                myCat.GetCategory(myDVD.GetCat_Code());

                total -= Convert.ToDouble(myCat.getRate());

                txtTotal.Text = total.ToString("0.00");

                i--;

                count--;

            }
            else
            {
                MessageBox.Show("cannot remove nothing from the basket!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void databaseValidation()
        {

            if (myMember.ValidateMember(Convert.ToInt32(txtCustID.Text), txtPin.Text) == true)
            {


                btnSearch.Visible = true;

                txtTitleSearch.Visible = true;

                lblTitle.Visible = true;

                grpValidation.Visible = false;

                grpMember.Visible = true;

                DetailsForViewing();

         

            }
            else
            {
                MessageBox.Show("not Valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

            
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}