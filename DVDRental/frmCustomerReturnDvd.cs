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
    public partial class frmCustomerReturnDvd : Form
    {
        public frmCustomerReturnDvd()
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
    }
}
