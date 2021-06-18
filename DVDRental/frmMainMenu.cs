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
    public partial class frmDvd : Form
    {
        public frmDvd()
        {
            InitializeComponent();
        }

        private void addDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminAddDvd addDvd = new frmAdminAddDvd();

         
            this.Hide();
            addDvd.Show();
        }

        private void updateDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminUpdateDvd updateDvd = new frmAdminUpdateDvd();


            this.Hide();
            updateDvd.Show();
        }

        private void deleteDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminDeleteDvd deleteDvd = new frmAdminDeleteDvd();


            this.Hide();
            deleteDvd.Show();
        }

        private void rentDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerRentDvd rentDvd = new frmCustomerRentDvd();


            this.Hide();
            rentDvd.Show();
        }

        private void returnDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerReturnDvd returnDvd = new frmCustomerReturnDvd();


            this.Hide();
            returnDvd.Show();
        }
    }
}
