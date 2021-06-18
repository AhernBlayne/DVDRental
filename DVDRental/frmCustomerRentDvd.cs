using System;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;



namespace DVDRental
{
    public partial class frmCustomerRentDvd : Form
    {

        public frmCustomerRentDvd()
        {
            InitializeComponent();
        }
        //got help from Conor here.Only works when dvds are added using the add dvd function instead of in the sql script.
        private void frmCustomerRentDvd_Load(object sender, EventArgs e)
        {

            txtRentid.Text = Rent.getCountId().ToString("000");
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String dvdStr = "SELECT * FROM DVD";
            OracleCommand cmd = new OracleCommand(dvdStr, conn);
            OracleDataReader dvd = cmd.ExecuteReader();
            while (dvd.Read())
            {
                //MessageBox.Show(dvd["DVD_CATEGORY"].ToString());
                cboCat.Items.Add(dvd["DVD_CATEGORY"].ToString());
            }
            String dvdStr2 = "SELECT * FROM DVD";
            OracleCommand cmd2 = new OracleCommand(dvdStr2, conn);
            OracleDataReader dvd2 = cmd2.ExecuteReader();
            while (dvd2.Read())
            {
                //MessageBox.Show(dvd2["DVD_NAME"].ToString());
                cboDVD.Items.Add(dvd2["DVD_NAME"].ToString());
            }
            conn.Close();
        }
        private void btnRentDvd_Click(object sender, EventArgs e)
        {
     
            for (int y = 0; y < txtForename.Text.Length; y++)
            {
                if ( txtForename.Text[y] >= 'A' && txtForename.Text[y] <= 'Z' || txtForename.Text[y] >= 'a' && txtForename.Text[y] <= 'z')
                {
                }
                else { MessageBox.Show("Forename can only have letters!","Error!"); }
            }


            for (int y = 0; y < txtSurname.Text.Length; y++)
            {
                if (txtSurname.Text[y] >= 'A' && txtSurname.Text[y] <= 'Z' || txtSurname.Text[y] >= 'a' && txtSurname.Text[y] <= 'z')
                {

                }
                else
                {
                    MessageBox.Show("Surname can only have letters!", "Error!");
                }
            }

            for (int y = 0; y < txtPhone.Text.Length; y++)
            {
                if (txtPhone.Text[y] >= 'a' && txtPhone.Text[y] <= 'z' || txtPhone.Text[y] >= 'A' && txtPhone.Text[y] <= 'Z')
                {
                        MessageBox.Show("the phone number can only have numbers!", "Error!");
                    }
            }

             if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("surname cant be blank!", "Error!");
				txtSurname.Focus();
            }



            else if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("phone can not be blank!", "Error");
				txtPhone.Focus();
            }


            else if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("invalid phone number length", "Error!");
				txtPhone.Focus();
            }


            else if (cboWeeks.Text.Equals(""))
            {
                MessageBox.Show("please choose how long you wish to rent!", "Error");
				cboWeeks.Focus();
            }
            else if (cboDVD.Text.Equals(""))
            {
                MessageBox.Show("Please choose a dvd!", "Error");
                cboDVD.Focus();
            }
            else
            {
                customer bigCustomer = new customer();
                Rent bigrent = new Rent();

 

                bigCustomer.setForename(txtForename.Text);
                bigCustomer.setSurname(txtSurname.Text);
                bigCustomer.setPhone(txtPhone.Text);
                bigCustomer.setAddress(txtAddress.Text);
         
                if (cboWeeks.Items.Equals("1 week")) { bigrent.setPrice(7.50); }
                if (cboWeeks.Items.Equals("2 weeks")) { bigrent.setPrice(15.00); }
                if (cboWeeks.Items.Equals("3 weeks")) { bigrent.setPrice(22.50); }

                bigrent.setDvdid(cboDVD.SelectedIndex);
                bigrent.setRentid(Rent.getCountId() -1);
                bigrent.setCustid(customer.getCountId()- 1);
               


                bigCustomer.addCustomer();
                bigrent.addRent();



                MessageBox.Show("You have Rented a DVD!", "DVD Rented!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void menu_Click(object sender, EventArgs e)
        {

            frmDvd menu = new frmDvd();
            menu.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            frmDvd yeet = new frmDvd();
            yeet.Show();
            Application.Exit();
        }


    }
}
