using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDsys
{
    class Transactions
    {
        private int rental_ID;
        private int cust_ID;
        private DateTime rentDate;
        private DateTime returnDate;
        private float total;

		public Transactions(int rental_ID, int cust_ID, DateTime rentDate, DateTime returnDate,float total)
		{

			rental_ID = this.rental_ID;
			cust_ID = this.cust_ID;
			rentDate = this.rentDate;
			returnDate = this.returnDate;
            total = this.total;

		}
		public Transactions()
		{

			rental_ID = 0;
			cust_ID = 0;
			rentDate = DateTime.Now;
			returnDate = DateTime.Now;
            total = 0;

		}

        public int GetRentalID()
        {
            return rental_ID;
        }

        public int GetCustID()
        {
            return cust_ID;
        }

        public DateTime GetRentDate()
        {
            return rentDate;
        }
        public DateTime GetReturnDate()
        {
            return returnDate;
        }

        public float getTotal() { 
            return total;
        }
        public void SetRentalID(int rental_ID)
        {
            this.rental_ID = rental_ID;
        }

        public void SetCustID(int cust_ID)
        {
            this.cust_ID = cust_ID;
        }

        public void SetRentDate(DateTime rentDate)
        {
            this.rentDate = rentDate;
        }
        public void SetReturnDate(DateTime returnDate)
        {
            this.returnDate = returnDate;
        }

        public void SetTotal(float total) {
            this.total = total;
        }

        public void AddTransaction()
        {
            //define oracle connection 
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //open connection 
            conn.Open();
            String strSQLAddRent = "INSERT INTO transactions (rental_ID, cust_ID, rent_Date, return_Date,total) VALUES ('" +
                this.rental_ID + "', '" + this.cust_ID + "','" + String.Format("{0:dd-MMM-yy}", rentDate) + "','" + String.Format("{0:dd-MMM-yy}", returnDate) + "','" + this.total + "')";
            OracleCommand cmdAddRent = new OracleCommand(strSQLAddRent, conn);

            //execute command
            cmdAddRent.ExecuteNonQuery();

            //close connection
            conn.Close();
        }

        public static int GetCountId()
        {
            //define oracle connection 
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //open connection 
            conn.Open();

            //define sql query
            String strSQLCount = "SELECT MAX(rental_ID) FROM TRANSACTIONS";
            OracleCommand cmdCount = new OracleCommand(strSQLCount, conn);

            //execute command
            OracleDataReader dataRead = cmdCount.ExecuteReader();
            //read data
            dataRead.Read();
            int l;
            if (dataRead[0] == DBNull.Value) l = 1;
            else l = Convert.ToInt32(dataRead[0]) + 1;

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
            String strSQLUpdate = "UPDATE Transactions SET rental_ID = '" + this.rental_ID + "', cust_ID = '" + this.cust_ID + "',rent_Date = '" + String.Format("{0:dd-MMM-yy}", rentDate) + "', return_Date = '" + String.Format("{0:dd-MMM-yy}", returnDate) + "'";
            OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);

            //execute command
            cmd.ExecuteNonQuery();

            //close connection
            conn.Close();


        }

        public void GetTransactions(int custID)
        {
            //define Sql Query

            String strSQL = "SELECT * FROM transactions WHERE cust_ID =" + custID;

            //Declare an Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            //declare an Oracle Command to execute

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object

            dr.Read();

            this.rental_ID = dr.GetInt32(0);

            this.cust_ID = dr.GetInt32(1);

            this.rentDate = dr.GetDateTime(2);

            this.returnDate = dr.GetDateTime(3);

            this.total = dr.GetInt32(4);

            //close database connection

            conn.Close();
        }

        public int LateCheck(int custID)
        {
            //define oracle connection 
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //open connection 
            conn.Open();

            //define sql query
            String strSQLCount = "SELECT * FROM transactions WHERE return_Date < SYSDATE AND cust_ID = " + custID;
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
    }
}
