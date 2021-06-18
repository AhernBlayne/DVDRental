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
    public partial class frmAdminDeleteDvd : Form
    {
        public frmAdminDeleteDvd()
        {
            InitializeComponent();
        }

        private void btnDeleteDvd_Click(object sender, EventArgs e)
        {
           

     
            for (int i = 0; i < txtDeleteDvd.Text.Length; i++)
            {
                if (txtDeleteDvd.Text[i] >= 'a' && txtDeleteDvd.Text[i] <= 'z' || txtDeleteDvd.Text[i] >= 'A' && txtDeleteDvd.Text[i] <= 'Z')
                {
                    MessageBox.Show("ID can not have a letter!","Error");
                }
                
            }

            if (txtDeleteDvd.Text.Equals(""))
            {
                MessageBox.Show("You need to enter a dvd name!", "Error");
                txtDeleteDvd.Focus();
            }
            else
            {

                MessageBox.Show("You have deleted a DVD!", "DVD Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DVD myDvd = new DVD();
                myDvd.setId(Convert.ToInt32(txtDeleteDvd.Text));
                myDvd.removeDvd();
                txtDeleteDvd.Visible = false;
                grdRemoveDvd.DataSource = DVD.getgroupDvds().Tables["WS"];
                txtDeleteDvd.Focus();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            frmDvd yeet = new frmDvd();
            yeet.Show();
            Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            frmDvd menu = new frmDvd();
            menu.Show();
            this.Close();
        }

        private void frmAdminDeleteDvd_Load(object sender, EventArgs e)
        {
                grdRemoveDvd.DataSource = DVD.getgroupDvds().Tables["WS"];
        }
      
        private void grdRemoveDvd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DVD dvd = new DVD();
            dvd.getOneDvd(Convert.ToInt32(grdRemoveDvd.Rows[grdRemoveDvd.CurrentCell.RowIndex].Cells[0].Value));
            txtDeleteDvd.Text = dvd.getId().ToString();
            txtDeleteDvd.Visible = true;
        }

    
    }
}
