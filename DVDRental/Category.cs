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
    class Category
    {
        private String cat_Code;
        private String descrip;
        private float rate;

        public Category(string cat_Code, string descrip, float rate)
        {
            this.cat_Code = cat_Code;
            this.descrip = descrip;
            this.rate = rate;
        }

        public Category() {
            cat_Code = "";
            descrip = "";
            rate = 0;
        }
        public String GetCat_Code()
        {
            return cat_Code;
        }

        public String GetDescrip()
        {
            return descrip;
        }

        public float getRate() {
            return rate;
        }

        public void setRate(float rate) { this.rate = rate; }

        public void SetCat_Code(String cat_code) { this.cat_Code = cat_code; }

        public void SetDescrip(String descrip) { this.descrip = descrip; }

        public static void LoadCategories(ComboBox cboCat)
        {
            DataSet ds = Utility.GetCategories();

            for (int i = 0; i < ds.Tables["CAT"].Rows.Count; i++)
                cboCat.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " +
                  ds.Tables[0].Rows[i][1].ToString());

        }

        public void GetCategory(String cat_Code)
        {
            //define Sql Query

            String strSQL = "SELECT * FROM Categories WHERE cat_Code = '" + cat_Code  + "'";

            //Declare an Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            //declare an Oracle Command to execute

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object

            dr.Read();

            this.cat_Code = dr.GetString(0);    

            this.descrip = dr.GetString(1);

            this.rate = dr.GetFloat(2);

             //close database connection

            conn.Close();
        }


    }
}
