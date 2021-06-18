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
    public partial class FrmAdminAddDvd : Form
    {
        // invokes getnextid method and stores result in latest variable.

        int latest = DVD.GetNextID();
        public FrmAdminAddDvd()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // validates form and if its valid then it invokes adddvd method and reloads form.

            if (Validation())
            {
                AddDvd();

                FrmAdminAddDvd addDvd = new FrmAdminAddDvd();

                addDvd.Show();

                this.Close();

            }
        }

        private void FrmAddDvd_Load(object sender, EventArgs e)
        {
            // sets dvdid on load along with invokes loadcategories,loadageratings and loadgenres in order to populate comboboxes

            txtdvdID.Text = latest.ToString("000");

            Utility.LoadCategories(cboCategories);

            AgeRating.LoadAgeRatings(cboAgeRatings);

            Utility.LoadGenres(cboGenres);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //opens main menu when the button is invoked.

            FrmDvd mainMenu = new FrmDvd();

            mainMenu.Show();

            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public Boolean Validation()
        {
            //validation for form. if its valid then the boolean stays true otherwise its false.

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
            else if (!Regex.IsMatch(Convert.ToString(txtRunningTime.Text), @"^[0-9]+$"))
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

        public void AddDvd()
        {
            //once invoked it adds a dvd to the database with the inserted values

            DVD myDvd = new DVD();

            int latest = DVD.GetNextID();

            myDvd.SetDvd_ID(latest);

            myDvd.SetCat_Code(cboCategories.SelectedItem.ToString().Substring(0, 2));

            myDvd.SetDirector(txtDirector.Text);

            myDvd.SetTitle(txtTitle.Text);

            myDvd.SetAr_Code(cboAgeRatings.SelectedItem.ToString().Substring(0, 4));

            myDvd.SetStatus("A");

            myDvd.SetRunning_Time(Convert.ToInt32(txtRunningTime.Text));

            myDvd.setGenre_Code(cboGenres.SelectedItem.ToString().Substring(0,2)); ;

            myDvd.AddDvd();

            MessageBox.Show("You have added DVD " + latest + " to the database!", "DVD added Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      /*  public void CleanForm()
        {
            //cleans up the form but reseting everything.

            int latest = DVD.GetNextID();

            txtTitle.Clear();

            txtDirector.Clear();

            txtRunningTime.Clear();

            cboCategories.SelectedIndex = -1;

            cboAgeRatings.SelectedIndex = -1;

            cboGenres.SelectedIndex = -1;

            txtdvdID.Text = latest.ToString("000");
        } */

    }

}