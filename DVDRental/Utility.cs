using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DVDsys
{
    class Utility
    {
       
        public static DataSet GetCategories() {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "SELECT * FROM categories";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter dataAdapt = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            dataAdapt.Fill(ds, "CAT");

            //close DB
            conn.Close();

            // return data set
            return ds;

     }

        public static DataSet GetCounties()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "SELECT * FROM Counties ORDER BY County_Code";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter dataAdapt = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            dataAdapt.Fill(ds, "COU");

            //close DB
            conn.Close();

            // return data set
            return ds;

        }

        public static DataSet GetGenres()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "SELECT * FROM Genres ORDER BY genre_Code";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter dataAdapt = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            dataAdapt.Fill(ds, "GEN");

            //close DB
            conn.Close();

            // return data set
            return ds;

        }

        public static void LoadCategories(ComboBox cboCat)
        {
            DataSet ds = GetCategories();

            for (int i = 0; i < ds.Tables["CAT"].Rows.Count; i++)
                cboCat.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadRight(4, ' ') + " " +
                  ds.Tables[0].Rows[i][1].ToString());

        }

        public static void LoadGenres(ComboBox cboCat)
        {
            DataSet ds = GetGenres();

            for (int i = 0; i < ds.Tables["GEN"].Rows.Count; i++)
                cboCat.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadRight(4, ' ') + " " +
                  ds.Tables[0].Rows[i][1].ToString());

        }

        public static void LoadCounties(ComboBox cboCat)
        {
            DataSet ds = GetCounties();

            for (int i = 0; i < ds.Tables["COU"].Rows.Count; i++)
                cboCat.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " +
                  ds.Tables[0].Rows[i][1].ToString());

        }


    }
}
