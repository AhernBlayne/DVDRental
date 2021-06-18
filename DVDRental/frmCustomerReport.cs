using Oracle.ManagedDataAccess.Client;
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
    public partial class frmCustomerReport : Form
    {
        public frmCustomerReport()
        {
            InitializeComponent();
        }

        public void LoadYears()
        {
            cboSelectYear.Items.Clear();

            int year = DateTime.Today.Year;
            for (int i = 1; i <= 3; i++)
            {
                cboSelectYear.Items.Add(year.ToString());
                year = year - 1;
            }
        }

        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }
                default:
                    return "OTH";

            }
        } //end of getMonth()

        public void LoadChart()
        {
            String stringSQL = "SELECT COUNT(cust_ID), TO_CHAR(date_of_reg,'MM') FROM members WHERE date_of_reg LIKE '%" + cboSelectYear.Text.Substring(2, 2) + "'" + " GROUP BY TO_CHAR(date_of_reg, 'MM') ORDER BY TO_CHAR(date_of_reg, 'MM')";

            DataTable datatable = new DataTable();

            OracleConnection connection = new OracleConnection(DBConnect.oradb);

            OracleCommand cmd = new OracleCommand(stringSQL, connection);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(datatable);
            connection.Close();

            String[] Months = new string[12];
            decimal[] Amounts = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i + 1);
                Amounts[i] = 0;
            }

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                Amounts[Convert.ToInt32(datatable.Rows[i][1]) - 1] = Convert.ToDecimal(datatable.Rows[i][0]);
            }

            chtReport.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtReport.ChartAreas[0].AxisX.Interval = 1;

            chtReport.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtReport.Series[0].LegendText = "Income in €";
            chtReport.Series[0].Points.DataBindXY(Months, Amounts);
            chtReport.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            chtReport.Series[0].Label = "#VALY";

            chtReport.Visible = true;
        }

        private void frmCustomerReport_Load(object sender, EventArgs e)
        {
            LoadYears();
        }

        private void menu_Click_1(object sender, EventArgs e)
        {
            FrmDvd mainMenu = new FrmDvd();
            mainMenu.Show();
            this.Close();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void cboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}