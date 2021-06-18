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
	public partial class FrmAdminAddMember : Form
	{
		int latest = Member.GetNextID();
		public FrmAdminAddMember()
		{
			InitializeComponent();
		}

		private void FrmAdminAddMember_Load(object sender, EventArgs e)
		{
			txtcustID.Text = latest.ToString("000");

			Utility.LoadCounties(cboCounties);
		}

		private void btnAddMember_Click_1(object sender, EventArgs e)
		{
			if (validation())
			{
				AddMember();

				FrmAdminAddMember addMember = new FrmAdminAddMember();

				addMember.Show();

				this.Close();
			}
		}
		
        private void exit_Click(object sender, EventArgs e)
        {
			System.Windows.Forms.Application.Exit();
		}

        private void menu_Click(object sender, EventArgs e)
        {
			FrmDvd mainMenu = new FrmDvd();
			mainMenu.Show();
			this.Close();
		}

		public void AddMember() {

			Member myMember = new Member();

			// DateTime now = DateTime.Now;

			myMember.SetDateOfRegistration(String.Format("{0:dd/MMM/yy}", DateTime.Now));

			myMember.SetFirstName(Convert.ToString(txtFirstName.Text));

			myMember.SetLastName(Convert.ToString(txtLastName.Text));

			myMember.SetCustID(Convert.ToInt32(txtcustID.Text));

			myMember.SetAddress(Convert.ToString(txtAddress.Text));

			myMember.SetCountyCode(Convert.ToString(cboCounties.Text.Substring(0,2)));

			myMember.SetTown(Convert.ToString(txtTown.Text));

			myMember.SetPin(txtPin.Text);

			myMember.SetStatus("A");

			myMember.SetPhoneNumber(txtPhoneNumber.Text);

			myMember.AddMember();

			MessageBox.Show("You have added a member to the database!", "Member added Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

			CleanForm();
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

			else if (!Regex.IsMatch(txtLastName.Text, @"^[\s*a-zA-Z]+$") )
			{
				MessageBox.Show("Last name must contain letters!", "Invalid Last Name!");
				valid = false;

			}
			else if ( Convert.ToString(txtLastName.Text).Equals(""))
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

			else if (Convert.ToString(txtPin.Text).Length != 4 )
			{
				MessageBox.Show("Pin must be 4 characters long! ", "Invalid Pin!");
				valid = false;

			}
			else if ( Convert.ToString(txtPin.Text) == "" )
			{
				MessageBox.Show("Pin must also not be blank!", "Invalid Pin!");
				valid = false;

			}
			else if (!Regex.IsMatch(Convert.ToString(txtPin.Text), @"^[0-9]+$"))
			{
				MessageBox.Show("Pint must contain numbers!", "Invalid Pin!");
				valid = false;

			}

			else if (Convert.ToString(txtPhoneNumber.Text).Length != 10 )
			{
				MessageBox.Show("Mobile Number must be 10 characters long!", "Invalid Phone Number!");
				valid = false;

			}
			else if (Convert.ToString(txtPhoneNumber.Text).Equals("") )
			{
				MessageBox.Show("Mobile Number cannot be blank!", "Invalid Phone Number!");
				valid = false;

			}
			else if (!Regex.IsMatch(Convert.ToString(txtPhoneNumber.Text), @"^[0-9]+$"))
			{
				MessageBox.Show("Mobile Number must contain numbers!!", "Invalid Phone Number!");
				valid = false;
			}
			return valid;
		
		}

		public void CleanForm()
		{
			txtFirstName.Clear();

			txtLastName.Clear();

			txtAddress.Clear();

			txtTown.Clear();

			cboCounties.SelectedIndex = -1;

			txtPin.Clear();

			txtPhoneNumber.Clear();

			txtcustID.Clear();

			txtcustID.Text = Member.GetNextID().ToString("000");


		}

        private void cboCounties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}