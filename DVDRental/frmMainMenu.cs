using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVDsys
{
    public partial class FrmDvd : Form
    {
        
        public FrmDvd()
        {
            InitializeComponent();
        }

        private void addMembertoolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmAdminAddMember addMember = new FrmAdminAddMember();

            addMember.Show();

            this.Hide();
        }

        private void updateMembertoolStripMenuItem8_Click(object sender, EventArgs e)
        {

            FrmAdminUpdateMember updateMember = new FrmAdminUpdateMember();

            updateMember.Show();

            this.Hide();
        }

        private void removeMembertoolStripMenuItem9_Click(object sender, EventArgs e)
        {

            frmAdminDeleteMember removeMember = new frmAdminDeleteMember();

            removeMember.Show();

            this.Hide();
        }

        private void addDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminAddDvd addDvd = new FrmAdminAddDvd();

            addDvd.Show();

            this.Hide();
        }

        private void updateDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminUpdateDvd updateDvd = new FrmAdminUpdateDvd();

            updateDvd.Show();

            this.Hide();
        }

        private void removeDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminDeleteDvd removeDvd = new FrmAdminDeleteDvd();

            removeDvd.Show();

            this.Hide();
        }

        private void rentDvdtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCustomerRent rent = new FrmCustomerRent();

            rent.Show();

            this.Hide();
        }

        private void returnDvdtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCustomerReturn returnRent = new FrmCustomerReturn();

            returnRent.Show();

            this.Hide();
        }

        private void viewCustomerChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerReport report = new frmCustomerReport();

            report.Show();

            this.Hide();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmRevenueReport report = new frmRevenueReport();

            report.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuMembers_Click(object sender, EventArgs e)
        {
           
        }

       /* public void mnuMembers_MouseHover(object sender, EventArgs e)
        {
            mnuMembers.BackColor = Color.DimGray;
        }

        public void mnuMembers_MouseLeave(object sender, EventArgs e)
        {
            mnuMembers.BackColor = Color.Black;
        } */

        private void FrmDvd_Load(object sender, EventArgs e)
        {
            //mnuMembers.MouseHover += new EventHandler(mnuMembers_MouseHover);
           // mnuMembers.MouseLeave += new EventHandler(mnuMembers_MouseLeave);
        }
    }
}