using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDRental
{
    public partial class frmAdminUpdateDvd : Form
    {
        public frmAdminUpdateDvd()
        {
            InitializeComponent();
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


        private void btnUpdateDvd_Click(object sender, EventArgs e)
        {



            if (txtUpdateDvd.Text.Equals(""))
            {
                MessageBox.Show("Enter the dvd id", "Error");
                txtUpdateDvd.Focus();
            }
            else if (txtNewDvdName.Text.Equals(""))
            {
                MessageBox.Show("dvd name cannot be blank!", "Error");
                txtUpdateDvd.Focus();
            }
            else
            {
                DVD myDvd = new DVD();
                myDvd.setDvdname(txtNewDvdName.Text);
                myDvd.setDvdcat(txtUpdateDvdcat.Text);
                myDvd.setDvdstatus(Convert.ToString('A'));
                myDvd.setId(Convert.ToInt32(txtUpdateDvd.Text));
                myDvd.updateDvd();
                grdUpdateDvd.DataSource = DVD.getDvds().Tables["WS"];
                MessageBox.Show("You have updated a DVD!", "dvd updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdminUpdateDvd frmDVD = new frmAdminUpdateDvd();
                this.Hide();
                frmDVD.Show();
            }
        }

        private void grdUpdateDvd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DVD dvd = new DVD();
            dvd.getOneDvd(Convert.ToInt32(grdUpdateDvd.Rows[grdUpdateDvd.CurrentCell.RowIndex].Cells[0].Value));
            txtUpdateDvd.Text = dvd.getId().ToString();
            txtUpdateDvd.Visible = true;
        }
        private void frmAdminUpdateDvd_Load(object sender, EventArgs e)
        {
            grdUpdateDvd.DataSource = DVD.getgroupDvds().Tables["WS"];
        }
    }
}