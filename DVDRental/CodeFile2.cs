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
    class Rent
    {
        private int rentid;
        private int dvdid;
        private int custid;
        private String datedue;
        private String dateout;
        private String datereturned;
        private int price;


        //Constructor
        public Rent()
        {
            rentid = 0;
            dvdid = 0;
            custid = 0;
            datedue = "";
            dateout = "";
            datereturned = "";
            price = 0;
        }

        //Getters
        public int getRentid()
        {
            return rentid;
        }

        public int getDvdid()
        {
            return dvdid;
        }

        public int getCustid()
        {
            return custid;
        }

        public String getDateDue()
        {
            return datedue;
        }

        public String getDateout()
        {
            return dateout;
        }
        public String getreturned()
        {
            return datereturned;
        }
        public int getprice()
        {
            return price;
        }

        //Setters
        public void setRentid(int rentid)
        {
            this.rentid = rentid;
        }

        public void setDvdid(int dvdid)
        {
            this.dvdid = dvdid;
        }

        public void setDvdcat(int custid)
        {
            this.custid = custid;
        }

        public void setDateout(String dateout)
        {
            this.dateout = dateout;
        }
        public void setDatedue(String datedue)
        {
            this.datedue = datedue;
        }
        public void setDatereturned(String datereturned)
        {
            this.datereturned = datereturned;
        }

        //get all appointments from appointments Table 
        //Uses an OracleDataAdapter
        //An OracleDataAdapter object represents a data provider object that 
        //populates the DataSet and updates changes in the DataSet to the
        //Oracle database.

        public static DataSet getRents()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Rent ORDER BY rent_ID";

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


        public void getARent(int rentid)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT * FROM Rent WHERE rent_ID =" + rentid;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); //Consider if dr.Read()

            //Instantiate object variables
            this.rentid = dr.GetInt32(0);
            this.dvdid = dr.GetInt32(0);
            this.custid = dr.GetInt32(0);
            this.datedue = dr.GetString(3);
            this.dateout = dr.GetString(3);
            this.datereturned = dr.GetString(3);
            this.price = dr.GetInt32(0);


            //close DB
            conn.Close();
        }

        public static int getNextId()
        {
            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query 
            String strSQL = "SELECT MAX(rent_ID) FROM Rent";

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

        public void addRent()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO Rent (rent_ID, DVD_ID, cust_ID, Date_Due,Date_Out,Date_Returned) VALUES (" + getNextId() + ", '" +
                this.rentid + this.dvdid + "', '" + this.custid + "', '" + this.datedue + "', '" + this.dateout +"', '" + this.datereturned;
            //MessageBox.Show(strSQL, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }
        public void updaterent()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Rent SET rent_ID = '" + this.rentid + "', DVD_ID = '" +
                            this.dvdid + "', cust_ID = '" + this.custid + "', Date_Due = '" + this.datedue + "', Date_Out = '" + this.dateout
                            + "', Date_Returned = '" + this.datereturned + "', Price = '" + this.price;
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
