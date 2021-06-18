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
    public partial class frmAdmin : Form
    {
        public static string user;
        public static string pass;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            user = txtUserName.Text;
            pass = txtPassWord.Text;

            if (user == "Blayne" && pass == "challangeaccepted") {
                MessageBox.Show("Valid!");
                 }
            else { MessageBox.Show("Invalid!");
            }
        }
    }
}
