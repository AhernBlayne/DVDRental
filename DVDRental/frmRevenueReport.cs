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
    public partial class frmRevenueReport : Form
    {
        public frmRevenueReport()
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

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            LoadYears();

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
        }

        public void LoadChart()
        {
            String strSQL = "SELECT SUM(total), TO_CHAR(rent_Date,'MM') FROM transactions WHERE rent_Date LIKE '%" + cboSelectYear.Text.Substring(2, 2) + "'" + " GROUP BY TO_CHAR(rent_Date, 'MM') ORDER BY TO_CHAR(rent_Date, 'MM')";

            DataTable dt = new DataTable();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);

            conn.Close();

            String[] Months = new string[12];

            decimal[] Amounts = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i + 1);

                Amounts[i] = 0;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Amounts[Convert.ToInt32(dt.Rows[i][1]) - 1] = Convert.ToDecimal(dt.Rows[i][0]);
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

        private void CboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //close entire application

            System.Windows.Forms.Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            FrmDvd mainMenu = new FrmDvd();

            mainMenu.Show();

            this.Close();
        }
    }
}