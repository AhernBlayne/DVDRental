using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVDsys
{
    public partial class FrmAdminUpdateDvd : Form
    {
        DVD myDVD = new DVD();
        public FrmAdminUpdateDvd()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //when invoked the main menu is opened while the current window is closed.

            FrmDvd mainMenu = new FrmDvd();

            mainMenu.Show();

            this.Close();

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            // when invoked the system is exited.

            System.Windows.Forms.Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /* checks if dvd exists and if so then invoke matchmovies method and make group boxes visible 
            else display error message and make group boxes invisible then invoke cleanform method*/

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

        private void cboMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display details for editing on form.

            DetailsForViewing();

        }

        private void MatchMovies()
        {

            //clear combobox then create a dataset populated by the invoked gersummardvds method.
            //then load result into combobox through the for loop.
            //finally set the group box to visible.

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

            txtdvdID.Text = myDVD.GetDvd_ID().ToString("000");

            txtRunningTime.Text = myDVD.GetRunning_Time().ToString();

            txtTitle.Text = myDVD.GetTitle().ToString();

            txtDirector.Text = myDVD.GetDirector().ToString();

            grpDVD.Visible = true;

        }

        public void UpdateDVD()
        {
            //once invoked it updates the data in the database with the newly inserted data.

            DVD myDvd = new DVD();

            myDvd.SetDvd_ID(Convert.ToInt32(txtdvdID.Text));

            myDvd.SetCat_Code(cboCategories.SelectedItem.ToString().Substring(0, 2));

            myDvd.SetDirector(txtDirector.Text);

            myDvd.SetTitle(txtTitle.Text);

            myDvd.SetAr_Code(cboAgeRatings.SelectedItem.ToString().Substring(0, 4));

            myDvd.SetStatus("A");

            myDvd.SetRunning_Time(Convert.ToInt32(txtRunningTime.Text));

            myDvd.setGenre_Code(cboGenres.SelectedItem.ToString().Substring(0, 2));

            myDvd.UpdateDvd();

            MessageBox.Show("You have Updated DVD " + myDvd.GetDvd_ID() + " From the database!", "DVD Updated Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI 

            CleanForm();

        }

        public Boolean Validation()
        {
            bool valid = true;

            if (cboCategories.SelectedIndex == -1)
            {

                MessageBox.Show("Category cannot be blank!", "Invalid Category!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;
                cboCategories.Focus();

            }
            else if (cboAgeRatings.SelectedIndex == -1)
            {

                MessageBox.Show("Age Ratings cannot be blank", "Invalid Rating!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;

                cboAgeRatings.Focus();

            }
            else if (!Regex.IsMatch(txtTitle.Text, @"^[\s*a-zA-Z]+$"))
            {

                MessageBox.Show("Title must only contain letters! Please Seperate By spaces!", "Invalid Title!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;

                txtTitle.Clear();

                txtTitle.Focus();

            }
            else if (txtTitle.Text == "")
            {

                MessageBox.Show("Title must not be blank!", "Invalid Title!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;
                txtTitle.Clear();

                txtTitle.Focus();

            }
            else if (!Regex.IsMatch(txtDirector.Text, @"^[\s*a-zA-Z]+$"))
            {

                MessageBox.Show("Director must only contain letters!  Please Seperate By spaces!", "Invalid Director!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;

                txtDirector.Clear();

                txtDirector.Focus();

            }
            else if (txtDirector.Text == "")
            {

                MessageBox.Show("Director must not be blank!", "Invalid Director!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;

                txtDirector.Clear();

                txtDirector.Focus();

            }
            else if (Regex.IsMatch(txtRunningTime.Text, @"^[a-zA-Z]+$"))
            {

                MessageBox.Show("Running time must be in minutes and only contain numbers!", "Invalid Running Time!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;

                txtRunningTime.Clear();

                txtRunningTime.Focus();

            }
            else if (txtRunningTime.Text == "")
            {

                MessageBox.Show("Running time must not be blank!", "Invalid Running Time!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valid = false;

                txtRunningTime.Clear();

                txtRunningTime.Focus();

            }
            else
            {
                valid = true;
            }
            return valid;
        }
        public void CleanForm()
        {

            txtTitle.Clear();

            txtDirector.Clear();

            txtRunningTime.Clear();

            cboCategories.SelectedIndex = -1;

            cboAgeRatings.SelectedIndex = -1;

            cboGenres.SelectedIndex = -1;

            txtdvdID.Text = "000";
        }

        private void FrmAdminUpdateDvd_Load(object sender, EventArgs e)
        {
            Category.LoadCategories(cboCategories);

            AgeRating.LoadAgeRatings(cboAgeRatings);

            Utility.LoadGenres(cboGenres);
        }

        private void btnUpdateDvd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                UpdateDVD();

                FrmAdminUpdateDvd updateDvd = new FrmAdminUpdateDvd();

                updateDvd.Show();

                this.Close();


            }
        }
    }

}