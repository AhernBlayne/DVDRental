using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDsys
{

    class AgeRating
    {
        private String ar_Code;
        private String descrip;

        public AgeRating(string ar_Code, string descrip)
        {
            this.ar_Code = ar_Code;
            this.descrip = descrip;

        }

        public AgeRating()
        {
            ar_Code = "";
            descrip = "";

        }
        public String GetAr_Code()
        {
            return ar_Code;
        }

        public String GetDescrip()
        {
            return descrip;
        }

        public void SetAr_Code(String ar_code) { this.ar_Code = ar_code; }

        public void SetDescrip(String descrip) { this.descrip = descrip; }

        public static DataSet GetAgeRatings()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "SELECT * FROM ageratings";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter dataAdapt = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            dataAdapt.Fill(ds, "AGE");

            //close DB
            conn.Close();

            // return data set
            return ds;

        }

        public void GetAR(String ar_code)
        {
            //define Sql Query

            String strSQL = "SELECT * FROM Categories WHERE ar_code =" + ar_code;

            //Declare an Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            //declare an Oracle Command to execute

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object

            dr.Read();

            this.ar_Code = dr.GetString(0);

            this.descrip = dr.GetString(1);



            //close database connection

            conn.Close();



        }

        public static void LoadAgeRatings(ComboBox cboAge)
        {

            DataSet ds = AgeRating.GetAgeRatings();

            for (int i = 0; i < ds.Tables["AGE"].Rows.Count; i++)
                cboAge.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " +
                  ds.Tables[0].Rows[i][1].ToString());

        }
    }
}
