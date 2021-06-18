using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDsys
{
    public partial class FrmAdminUpdateMember : Form
    {
        Member myMember = new Member();
        public FrmAdminUpdateMember()
        {
            InitializeComponent();
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

        public Boolean validation()
        {
            bool valid = true;
            if (!Regex.IsMatch(txtFirstName.Text, @"^[\s*a-zA-Z]+$"))
            {
                MessageBox.Show("First name must only contain letters!", "Invalid First Name!");
                valid = false;

            }
            else if (Convert.ToString(txtFirstName.Text).Equals(""))
            {
                MessageBox.Show("First name must not be blank!", "Invalid First Name!");
                valid = false;

            }
            else if (!Regex.IsMatch(txtLastName.Text, @"^[\s*a-zA-Z]+$"))
            {
                MessageBox.Show("Last name must contain letters!", "Invalid Last Name!");
                valid = false;

            }
            else if (Convert.ToString(txtLastName.Text).Equals(""))
            {
                MessageBox.Show("Last name must not be blank!", "Invalid Last Name!");
                valid = false;
            }
            else if (Convert.ToString(txtAddress.Text).Equals(""))
            {
                MessageBox.Show("Address must not be blank!", "Invalid Address!");
                valid = false;
            }
            else if (!Regex.IsMatch(Convert.ToString(txtAddress.Text), @"^[\s*a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Address must not be blank and only contain letters and numbers!", "Invalid Address!");
                valid = false;
            }
            else if (Convert.ToString(txtTown.Text).Equals(""))
            {
                MessageBox.Show("Town must not be blank!", "Invalid Town!");
                valid = false;

            }
            else if (!Regex.IsMatch(Convert.ToString(txtTown.Text), @"^[\s*a-zA-Z]+$") || Regex.IsMatch(Convert.ToString(txtTown.Text), @"^ (?:\d |[,\.])+$"))
            {
                MessageBox.Show("Town must contain letters!", "Invalid Town!");
                valid = false;

            }
            else if (Convert.ToString(txtPin.Text).Length != 4)
            {
                MessageBox.Show("Pin must be 4 characters long! ", "Invalid Pin!");
                valid = false;

            }
            else if (Convert.ToString(txtPin.Text) == "")
            {
                MessageBox.Show("Pin must also not be blank!", "Invalid Pin!");
                valid = false;

            }
            else if (!Regex.IsMatch(Convert.ToString(txtPin.Text), @"^[0-9]+$"))
            {
                MessageBox.Show("Pint must contain numbers!", "Invalid Pin!");
                valid = false;

            }
            else if (Convert.ToString(txtPhoneNumber.Text).Length != 10)
            {
                MessageBox.Show("Mobile Number must be 10 characters long!", "Invalid Phone Number!");
                valid = false;

            }
            else if (Convert.ToString(txtPhoneNumber.Text).Equals(""))
            {
                MessageBox.Show("Mobile Number cannot be blank!", "Invalid Phone Number!");
                valid = false;

            }
            else if (!Regex.IsMatch(Convert.ToString(txtPhoneNumber.Text), @"^[0-9]+$"))
            {
                MessageBox.Show("Mobile Number must contain numbers!!", "Invalid Phone Number!");
                valid = false;
            }
            else if (cboMembers.SelectedIndex == -1)
            {
                MessageBox.Show("you must select a member", "Invalid Member!");
                valid = false;
            }
            return valid;

        }

        public void CleanForm()
        {

            txtNameSearch.Clear();

            txtcustID.Clear();

            txtFirstName.Clear();

            txtLastName.Clear();

            txtAddress.Clear();

            txtTown.Clear();

            cboCounties.SelectedIndex = -1;

            txtPin.Clear();

            txtPhoneNumber.Clear();

            txtcustID.Clear();

            cboMembers.Items.Clear();

            grpMember.Visible = false;

            grpMembers.Visible = false;

        }

        private void cboMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display details for editing

            DetailsForViewing();
        }
        private void MatchMember()
        {
            cboMembers.Items.Clear();

            DataSet ds = Member.GetSummaryMembers(txtNameSearch.Text);

            for (int i = 0; i < ds.Tables["MEM"].Rows.Count; i++)
                cboMembers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadRight(4, ' ') + " " + ds.Tables[0].Rows[i][1].ToString().PadRight(4, ' '));

            // display members 
            grpMembers.Visible = true;

        }
        public void DetailsForViewing()
        {

            String id = cboMembers.SelectedItem.ToString().Substring(0, 2);

            //create an instance of DVD and call a method to instantiate it's instance variables

            myMember.GetAMember(Convert.ToInt32(id));

            //move values from instance variables to form controls

            txtcustID.Text = myMember.GetCustID().ToString("000");

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

            txtPin.Text = myMember.GetPin().ToString();

            //display the DVD for updating

            grpMember.Visible = true;

        }

        public void UpdateMember()
        {
            String latest = cboMembers.SelectedItem.ToString().Substring(0, 3);

            Member myMember = new Member();

            DateTime now = DateTime.Now;

            myMember.SetDateOfRegistration(String.Format("{0:dd/MM/yy}", now));

            myMember.SetFirstName(Convert.ToString(txtFirstName.Text));

            myMember.SetLastName(Convert.ToString(txtLastName.Text));

            myMember.SetCustID(Convert.ToInt32(latest));

            myMember.SetAddress(Convert.ToString(txtAddress.Text));

            myMember.SetCountyCode(cboCounties.SelectedItem.ToString().Substring(0, 2));

            myMember.SetTown(Convert.ToString(txtTown.Text));

            myMember.SetPin(txtPin.Text);

            myMember.SetStatus("A");

            myMember.SetPhoneNumber(txtPhoneNumber.Text);

            myMember.UpdateMember();

            MessageBox.Show("You have updated a member in the database!", "Member updated Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CleanForm();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // find all members with matching first name

            if (txtNameSearch.Text != "" && myMember.CheckMember(txtNameSearch.Text) == true)
            {
                MatchMember();

                grpMember.Visible = true;

                grpMembers.Visible = true;


            }
            else { 

                MessageBox.Show("That member does not exist in our database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                grpMember.Visible = false;

                grpMembers.Visible = false;

                CleanForm();
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                UpdateMember();

                FrmAdminUpdateMember updateMember = new FrmAdminUpdateMember();

                updateMember.Show();

                this.Close();
            }
        }

        private void FrmAdminUpdateMember_Load(object sender, EventArgs e)
        {
            Utility.LoadCounties(cboCounties);
        }
    }
}