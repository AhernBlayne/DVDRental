using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace DVDsys
{
	class DVD
	{
		private int dvd_ID;
		private String cat_Code;
		private String genre_Code;
		private String ar_Code;
		private String title;
		private String director;
		private String status;
		private int running_Time;

        public DVD(int dvd_ID,String Genre_Code,string cat_Code, string ar_Code, string title, string director, string status,int running_Time)
        {
            this.dvd_ID = dvd_ID;
			this.genre_Code = Genre_Code;
            this.cat_Code = cat_Code;
            this.ar_Code = ar_Code;
            this.title = title;
            this.director = director;
            this.status = status;
			this.running_Time = running_Time;
        }

        public DVD()
		{
			dvd_ID = 0;
			genre_Code = "";
			cat_Code = "";
			ar_Code = "";
			title = "";
			director = "";
			status = "";
			running_Time = 0;
		}
		public int GetDvd_ID()
		{
			return dvd_ID;
		}

		public string getGenre_Code() {
			return genre_Code;
		}

		public String GetAr_Code() {
			return ar_Code;
		}

		public String GetCat_Code()
		{
			return cat_Code;
		}

		public String GetTitle()
		{
			return title;
		}


		public String GetDirector()
		{
			return director;
		}
		public String GetStatus()
		{
			return status;
		}
		public int GetRunning_Time()
		{
			return running_Time;
		}

		public void setGenre_Code(String Genre_Code) { this.genre_Code = Genre_Code; }
		public void SetRunning_Time(int running_Time) { this.running_Time = running_Time; }
		public void SetCat_Code(String cat_code) { this.cat_Code = cat_code; }
		public void SetAr_Code(String ar_code) { this.ar_Code = ar_code; }
		public void SetDvd_ID(int dvd_ID) { this.dvd_ID = dvd_ID; }
		public void SetStatus(String status)
		{
			this.status = status;
		}


		public void SetTitle(String title)
		{
			this.title = title;
		}
	
	
		public void SetDirector(String director)
		{
			this.director = director;
		}

	
		public static DataSet GetDvds()
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define SQL Query.
			String strSQLDvd = "SELECT * FROM DVDS WHERE status = 'A'";
			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);
			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);

			DataSet dataSet = new DataSet();
			dataAdapt.Fill(dataSet, "DVD");

			//close DB
			conn.Close();

			// return data set
			return dataSet;

		}
		public static DataSet GetOutDvds()
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define SQL Query.
			String strSQLDvd = "SELECT * FROM DVDS WHERE status = 'O'";
			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);

			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);
	
			DataSet dataSet = new DataSet();
			dataAdapt.Fill(dataSet, "DVD");

			//close DB
			conn.Close();

			// return data set
			return dataSet;

		}
		public static DataSet GetDvdsCatalog(int catalog)
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define SQL Query.
			String strSQLDvd = "SELECT * FROM DVDS WHERE catalog_No = " + catalog + "AND status = 'A'";

			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);
			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);

			DataSet dataSet = new DataSet();
			dataAdapt.Fill(dataSet, "DVD");

			//close DB
			conn.Close();

			// return data set
			return dataSet;

		}


		public static int GetNextID()
		{

			//define oracle connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define sql query
			String strSQLCount = "SELECT MAX(dvd_ID) FROM DVDS";
			OracleCommand cmdCount = new OracleCommand(strSQLCount, conn);
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
		public bool CheckDVD(String title)
		{
			//define sql connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//define sql query
			String strSQLDvd = "SELECT * FROM DVDs WHERE TITLE LIKE '" + title + "%' AND status = 'A'";
			OracleCommand cmdCount = new OracleCommand(strSQLDvd, conn);

			//execute command
			OracleDataReader dataRead = cmdCount.ExecuteReader();

			//read data
			dataRead.Read();
			bool check = false;
			if (dataRead.HasRows)
			{
				check = true;
			}
			else
			{
				
			}
			conn.Close();
			return check;


		}
		public void AddDvd()
		{
			
				//define oracle connection

				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection
				conn.Open();

				//define sql query
				String strSQL = "INSERT INTO DVDS (dvd_ID,genre_Code,cat_Code,ar_Code,run_Time,title,director,status) VALUES('" + this.dvd_ID + "',  '" + this.genre_Code + "',  '" + this.cat_Code + "',  '" + this.ar_Code + "',  '" + this.running_Time + "',  '" + this.title + "',  '" + this.director + "', '" + this.status + "')";
				OracleCommand cmd = new OracleCommand(strSQL, conn);

				//execute command
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
		
		}

		public void UpdateDvd()
		{
			
				//define oracle connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection
				conn.Open();

				//define sql query
				String strSQLUpdate = "UPDATE DVDS SET cat_Code = '" + this.cat_Code + "', genre_Code = '" + this.genre_Code + "', ar_Code = '" + this.ar_Code + "', title = '" + this.title + "', director = '" + this.director + "', run_time = '" + this.running_Time + "', status = '" + this.status + "' WHERE dvd_ID =" + this.dvd_ID;
				OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);

				//execute command
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
		
		
		}
		public void UpdateDvdO()
		{
			try
			{
				//define oracle connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection
				conn.Open();

				//define sql query
				String strSQLUpdate = "UPDATE DVDS SET status = '" + "O" + "' WHERE dvd_ID =" + this.dvd_ID;
				OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);

				//execute command
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
			}
			catch
			{
				MessageBox.Show("dvd status could not be updated to O");
			}
		}
		public void UpdateDvdA(int dvd_ID)
		{
			try
			{
				//define oracle connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection 
				conn.Open();

				//define sql query
				String strSQLUpdate = "UPDATE DVDS SET status = '" + "A" + "' WHERE dvd_ID =" + dvd_ID;
				OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);

				//execute command
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
			}
			catch
			{
				MessageBox.Show("dvd status could not be updated to A");
			}
		}

		public void UpdateDvdR(int dvdNo)
		{
			try
			{
				//define oracle connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection 
				conn.Open();

				//define sql query
				String strSQLUpdate = "UPDATE DVDS SET status = '" + "R" + "' WHERE dvd_ID =" + dvdNo;
				OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);

				//execute command
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
			}
			catch
			{
				MessageBox.Show("dvd status could not be updated to A");
			}
		}

		public void GetDvd(int dvd_id)
		{
			//define Sql Query

			String strSQL = "SELECT * FROM DVDs WHERE dvd_id =" + dvd_id;

			//Declare an Oracle Connection

			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			conn.Open();

			//declare an Oracle Command to execute

			OracleCommand cmd = new OracleCommand(strSQL, conn);

			OracleDataReader dr = cmd.ExecuteReader();

			//read the record returned in dr and use values to instantiate the object

			dr.Read();

			this.dvd_ID = dr.GetInt32(0);

			this.genre_Code = dr.GetString(1);

			this.cat_Code = dr.GetString(2);

			this.running_Time = dr.GetInt32(3);

			this.ar_Code = dr.GetString(4);

			this.title = dr.GetString(5);

			this.director = dr.GetString(6);

			this.status = dr.GetString(7);

			//close database connection

			conn.Close();
		}

		public static DataSet GetSummaryDVDs(String title)
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define SQL Query.
			String strSQLDvd = "SELECT * FROM DVDs WHERE TITLE LIKE '" + title + "%' AND status = 'A'";

			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);

			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);

			DataSet dataSet = new DataSet();
			
			dataAdapt.Fill(dataSet, "DVD");

			//close DB
			conn.Close();

			// return data set
			return dataSet;

		}

		public static DataSet GetSummaryDVDOs(String title)
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define SQL Query.
			String strSQLDvd = "SELECT * FROM DVDs WHERE TITLE LIKE '%" + title + "%' AND status = 'O'";

			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);

			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);

			DataSet dataSet = new DataSet();

			dataAdapt.Fill(dataSet, "DVD");

			//close DB
			conn.Close();

			// return data set
			return dataSet;

		}

		public static DataSet GetSummaryTransactions(int cust_ID)
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define SQL Query.
			String strSQLDvd = "SELECT RentalItems.dvd_ID, DVDS.Title , Transactions.cust_ID FROM RentalItems INNER JOIN DVDS ON DVDS.dvd_ID = RentalItems.dvd_ID INNER JOIN Transactions ON RentalItems.rental_ID = Transactions.Rental_ID WHERE cust_ID =" + cust_ID + "AND status = 'O'";

			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);

			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);

			DataSet dataSet = new DataSet();

			dataAdapt.Fill(dataSet, "TRA");

			//close DB
			conn.Close();

			// return data set
			return dataSet;

		}






	}
}