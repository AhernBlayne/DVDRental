using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace DVDRental
{
    class cat
    {
        private int catcode;
        private String catdesc;
        private int price;


        //Constructor
        public cat()
        {
            catcode = 0;
            catdesc = "";
            price = 0;
   
        }

        //Getters
        public int getCatcode()
        {
            return catcode;
        }

        public String getCatdesc()
        {
            return catdesc;
        }

        public int getPrice()
        {
            return price;
        }

        //Setters
        public void setCatcode(int catcode)
        {
            this.catcode = catcode;
        }

        public void setCatdesc(String catdesc)
        {
            this.catdesc = catdesc;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        //get all appointments from appointments Table 
        //Uses an OracleDataAdapter
        //An OracleDataAdapter object represents a data provider object that 
        //populates the DataSet and updates changes in the DataSet to the
        //Oracle database.

        public static DataSet getCats()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM cat ORDER BY cat_Code";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "WS");

            //Close database connection
            conn.Close();

            return ds;
        }
        /*
                //this method retrieves a summary of an appointment
                public static DataSet getSummaryAppointments()
                {
                    //define Sql Query
                    String strSQL = "SELECT DVDID, Forename, Surname, MobileNo FROM Appointments ORDER BY StaffID";

                    //Declare an Oracle Connection
                    OracleConnection conn = new OracleConnection(DBConnect.oradb);
                    conn.Open();

                    //declare an Oracle Command to execute
                    OracleCommand cmd = new OracleCommand(strSQL, conn);

                    //Declare an Oracle DataAdapter
                    OracleDataAdapter da = new OracleDataAdapter(cmd);

                    //Declare DataSet to return records to application
                    DataSet ds = new DataSet();

                    da.Fill(ds, "WS");

                    //Close database connection
                    conn.Close();

                    return ds;
                } */


        public void getACat(int catcode)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT * FROM cat WHERE cat_Code =" + ID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); //Consider if dr.Read()

            //Instantiate object variables
            this.dvdid = dr.GetInt32(0);
            this.dvdstatus = dr.GetString(3);
            this.dvdcat = dr.GetString(4);
            this.dvdname = dr.GetString(5);


            //close DB
            conn.Close();
        }

        public static int getNextId()
        {
            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query 
            String strSQL = "SELECT MAX(cat_Code) FROM cat";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr[0] == DBNull.Value) // if(dr.IsDBNull(0)… 
                last = 1;

            else
                last = Convert.ToInt32(dr[0]) + 1;

            conn.Close();
            //conn.Close();
            return last;
        }

        public void addCat()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO cat (cat_Code, cat_Desc, Price) VALUES (" + getNextId() + ", '" +
                this.catcode + this.catdesc.ToUpper() + "', '" + this.price.ToUpper();
            //MessageBox.Show(strSQL, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }
        public void updateCat()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE cat SET cat_Code = '" + this.catcode.ToUpper() + "', cat_Desc = '" +
                            this.catdesc + "', Price = '" + this.price +
                            " WHERE DVD_ID =" + this.dvdid;
            //MessageBox.Show(strSQL, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }
        /*
                public bool checkMobileNo(String mobileNo)
                {
                    OracleConnection conn = new OracleConnection(DBConnect.oradb);
                    conn.Open();

                    //define SQL query 
                    String strSQL = "SELECT * FROM Appointments WHERE MobileNo = '" + mobileNo + "'";

                    OracleCommand cmd = new OracleCommand(strSQL, conn);

                    OracleDataReader dr = cmd.ExecuteReader();

                    //adapted from https://stackoverflow.com/questions/22443634/how-to-check-if-a-value-already-exists-in-my-database-and-show-a-validation-mess
                    if (dr.HasRows == true)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }//end of checkMobileNo()
                */
    }
}
