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
    public partial class frmAdminDeleteMember : Form
    {
        Member myMember = new Member();
        public frmAdminDeleteMember()
        {
            InitializeComponent();
        }

        private void FrmAdminDeleteMember_Load(object sender, EventArgs e)
        {

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

        public void CleanForm()
        {
            txtNameSearch.Clear();

            txtcustID.Clear();

            txtFirstName.Clear();

            txtLastName.Clear();

            txtAddress.Clear();

            txtTown.Clear();

            cboCounties.SelectedIndex = 0;

            txtPin.Clear();

            txtPhoneNumber.Clear();

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

            // display movies 
            if (ds.Tables["MEM"].Rows.Count > 0)
            {
                grpMembers.Visible = true;
            }

        }
        public void DetailsForViewing()
        {

            String id = cboMembers.SelectedItem.ToString().Substring(0, 3);

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

        public void RemoveMember()
        {
            String latest = cboMembers.SelectedItem.ToString().Substring(0, 2);

            myMember.UpdateMemberR(Convert.ToInt32(latest));

            MessageBox.Show("You have removed a member from the database!", "Member removed Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CleanForm();

        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            RemoveMember();

            frmAdminDeleteMember removeMember = new frmAdminDeleteMember();

            removeMember.Show();

            this.Close();
        }

        private void cboMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display details for editing

            DetailsForViewing();
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
            else
            {
                MessageBox.Show("That member does not exist in our database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                grpMember.Visible = false;

                grpMembers.Visible = false;
            }


        }
    }
}