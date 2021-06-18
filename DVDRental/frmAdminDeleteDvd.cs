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
    public partial class FrmAdminDeleteDvd : Form
    {
        DVD myDVD = new DVD();

        public FrmAdminDeleteDvd()
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

        private void FrmAdminDeleteDvd_Load(object sender, EventArgs e)
        {
            Category.LoadCategories(cboCategories);

            AgeRating.LoadAgeRatings(cboAgeRatings);

            Utility.LoadGenres(cboGenres);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // find all movies with matching title 

            if (txtTitleSearch.Text != "" && myDVD.CheckDVD(txtTitleSearch.Text) == true)
            {
                MatchMovies();

                grpMovies.Visible = true;

                grpDVD.Visible = true;


            }
            else
            {
                MessageBox.Show("That DVD does not exist in our database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                grpMovies.Visible = false;

                grpDVD.Visible = false;

                CleanForm();
            }



        }

        private void CboMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailsForViewing();
        }
        private void MatchMovies()
        {
            cboMovies.Items.Clear();

            DataSet ds = DVD.GetSummaryDVDs(txtTitleSearch.Text);

            for (int i = 0; i < ds.Tables["DVD"].Rows.Count; i++)
                cboMovies.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadRight(4, ' ') + " " + ds.Tables[0].Rows[i][5].ToString().PadRight(4, ' '));

            // display movies 
            grpMovies.Visible = true;

        }
        public void DetailsForViewing()
        {

            String id = cboMovies.SelectedItem.ToString().Substring(0, 2);

            //create an instance of DVD and call a method to instantiate it's instance variables

            myDVD.GetDvd(Convert.ToInt32(id));

            int count = cboCategories.Items.Count;

            int count2 = cboAgeRatings.Items.Count;

            cboCategories.SelectedIndex = 0;

            cboAgeRatings.SelectedIndex = 0;

            cboGenres.SelectedIndex = 0;

            while (myDVD.GetCat_Code().ToString().Trim() != cboCategories.SelectedItem.ToString().Substring(0, 2).Trim())
            {
                cboCategories.SelectedIndex++;

            }

            while (myDVD.GetAr_Code().ToString().Trim() != cboAgeRatings.SelectedItem.ToString().Substring(0, 4).Trim())
            {
                cboAgeRatings.SelectedIndex++;

            }

            while (myDVD.getGenre_Code().ToString().Trim() != cboGenres.SelectedItem.ToString().Substring(0, 2).Trim())
            {
                cboGenres.SelectedIndex++;

            }

            //move values from instance variables to form controls

            txtdvdID.Text = myDVD.GetDvd_ID().ToString("000");

            txtRunningTime.Text = myDVD.GetRunning_Time().ToString();

            txtTitle.Text = myDVD.GetTitle().ToString();

            txtDirector.Text = myDVD.GetDirector().ToString();

            //display the DVD for updating

            grpDVD.Visible = true;

        }
        public void RemoveDVD()
        {
            DVD myDvd = new DVD();

            myDvd.SetDvd_ID(Convert.ToInt32(txtdvdID.Text));

            myDvd.UpdateDvdR(myDvd.GetDvd_ID());

            MessageBox.Show("You have Removed DVD " + myDvd.GetDvd_ID() + " from the database!", "DVD Removed Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI.

            CleanForm();

        }

        public void CleanForm()
        {

            txtTitle.Clear();

            txtDirector.Clear();

            txtRunningTime.Clear();

            cboCategories.Items.Clear();

            cboAgeRatings.Items.Clear();

            grpDVD.Visible = false;

            grpMovies.Visible = false;

        }

        private void btnRemoveDvd_Click(object sender, EventArgs e)
        {
            RemoveDVD();

            FrmAdminDeleteDvd deleteDvd = new FrmAdminDeleteDvd();

            deleteDvd.Show();

            this.Close();
        }
    }
}