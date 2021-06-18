using DVDsys;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    class RentalItems
	{
		private int rental_ID;
		private int dvd_ID;
        private DateTime returnDate;
		private float fine;

		public RentalItems(int rental_ID, DateTime returnDate, float fine)
		{

			rental_ID = this.rental_ID;
			returnDate = this.returnDate;
			fine = this.fine;

		}
		public RentalItems()
		{

			rental_ID = 0;
			returnDate = DateTime.Now;
			fine = 0;

		}
        public int GetRentalID()
        {
            return rental_ID;
        }

        public int GetDVDID()
        {
            return dvd_ID;
        }

        public DateTime GetReturnDate()
        {
            return returnDate;
        }

        public float getFine()
        {
            return fine;
        }
        public void SetRentalID(int rental_ID)
        {
            this.rental_ID = rental_ID;
        }
        public void SetReturnDate(DateTime returnDate)
        {
            this.returnDate = returnDate;
        }

        public void SetFine(float fine)
        {
            this.fine = fine;
        }

        public void SetDvdID(int dvd_ID) {
            this.dvd_ID = dvd_ID;
        }

        public void AddRentalItem()
        {
            //define oracle connection 
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //open connection 
            conn.Open();
            String strSQLAddRent = "INSERT INTO RentalItems (rental_ID, dvd_ID, return_Date,fine) VALUES ('" +
                this.rental_ID + "', '" + this.dvd_ID + "','" + String.Format("{0:dd-MMM-yy}", this.returnDate) + "','" + this.fine + "')";
            OracleCommand cmdAddRent = new OracleCommand(strSQLAddRent, conn);

            //execute command
            cmdAddRent.ExecuteNonQuery();

            //close connection
            conn.Close();
        }

        public void GetRentalItem(int dvdID)
        {
            //define Sql Query

            String strSQL = "SELECT * FROM RentalItems WHERE dvd_ID =" + dvdID;

            //Declare an Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            //declare an Oracle Command to execute

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object

            dr.Read();

            this.rental_ID = dr.GetInt32(0);

            this.dvd_ID = dr.GetInt32(1);

            this.returnDate = dr.GetDateTime(2);

            this.fine = dr.GetInt32(3);

            //close database connection

            conn.Close();
        }

        public int LateCheck(int dvdID)
        {
            //define oracle connection 
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //open connection 
            conn.Open();

            //define sql query
            String strSQLCount = "SELECT * FROM rentalitems WHERE return_Date < SYSDATE AND dvd_ID = " + dvdID;
            OracleCommand cmdCount = new OracleCommand(strSQLCount, conn);

            //execute command
            OracleDataReader dataRead = cmdCount.ExecuteReader();

            //read data
            dataRead.Read();
            int l;
            if (!dataRead.HasRows)
                l = 0;
            else
                l = 1;

            //close connection 
            conn.Close();
            return l;
        }

        public void UpdateTransaction()
        {

            //define oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //open connection
            conn.Open();

            //define sql query
            String strSQLUpdate = "UPDATE RentalItems SET rental_ID = '" + this.rental_ID + "', dvd_ID = '" + this.dvd_ID + "', return_Date = '" + String.Format("{0:dd-MMM-yy}", returnDate) + "'";
            OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);

            //execute command
            cmd.ExecuteNonQuery();

            //close connection
            conn.Close();


        }

        public void GetRentalItems(int dvdID)
        {
            //define Sql Query

            String strSQL = "SELECT * FROM RentalItems WHERE dvd_ID =" + dvdID;

            //Declare an Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            //declare an Oracle Command to execute

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object

            dr.Read();

            this.rental_ID = dr.GetInt32(0);

            this.dvd_ID = dr.GetInt32(1);

            this.returnDate = dr.GetDateTime(2);

            this.fine = dr.GetInt32(3);

            //close database connection

            conn.Close();
        }

      

    }
}
