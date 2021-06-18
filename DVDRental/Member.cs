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
	class Member
	{
		private int cust_ID;
		private String firstName;
		private String lastName;
		private String address;
		private String county_Code;
		private String town;
		private String dateOfRegistration;
		private String phoneNumber;
		private String pin;
		private String status;

		public Member()
		{
			cust_ID = 0;
			firstName = "";
			lastName = "";
			address = "";
			county_Code = "";
			town = "";
			dateOfRegistration = "";
			phoneNumber = "";
			pin = "";
			status = "";

		}

		public int GetCustID()
		{
			return cust_ID;
		}
		public String GetPhoneNumber()
		{
			return phoneNumber;
		}
		public String GetFirstName()
		{
			return firstName;
		}

		public String GetLastName()
		{
			return lastName;
		}
		public String GetAddress()
		{
			return address;
		}
		public String GetCountyCode()
		{
			return county_Code;
		}
		public String GetTown()
		{
			return town;
		}
		public String GetDateOfRegistration()
		{
			return dateOfRegistration;
		}
		public String GetPin()
		{ return pin; }
		private String GetStatus() { return status; }
		public void SetPhoneNumber(String phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}
		public void SetPin(String pin)
		{
			this.pin = pin;
		}

		public void SetCustID(int custNO)
		{
			this.cust_ID = custNO;
		}

		public void SetFirstName(String firstname)
		{
			this.firstName = firstname;
		}
		public void SetLastName(String lastname)
		{
			this.lastName = lastname;
		}
		public void SetAddress(String address)
		{
			this.address = address;
		}
		public void SetCountyCode(String county_code)
		{
			this.county_Code = county_code;
		}
		public void SetTown(String town)
		{
			this.town = town;
		}
		public void SetDateOfRegistration(String dateofreg)
		{
			this.dateOfRegistration = dateofreg;
		}

		public void SetStatus(String status) { this.status = status; }

		public void GetAMember(int ID)
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);
			conn.Open();

			//Define SQL Query. Only 1 record can be returned as Id is unique
			String strSQL = "SELECT * FROM members WHERE cust_ID = " + ID;
			OracleCommand cmd = new OracleCommand(strSQL, conn);

			//execute query
			OracleDataReader dr = cmd.ExecuteReader();

			dr.Read(); //Consider if dr.Read()

			//Instantiate object variables
			this.cust_ID = dr.GetInt32(0);
			this.firstName = dr.GetString(1);
			this.lastName = dr.GetString(2);
			this.address = dr.GetString(3);
			this.town = dr.GetString(4);
			this.county_Code = dr.GetString(5);
			this.phoneNumber = dr.GetString(7);
			this.pin = dr.GetString(8);
			this.status = dr.GetString(9);



			//close DB
			conn.Close();
		}
		public static DataSet GetMembers()
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//define sql query
			String strSQLDvd = "SELECT * FROM Members ORDER BY cust_ID";
			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);
			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);


			DataSet dataSet = new DataSet();
			dataAdapt.Fill(dataSet, "MEM");

			//close connection
			conn.Close();

			//return dataset
			return dataSet;

		}

		public static int GetNextID()
		{
			//define oracle connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//define sql query
			String strSQLCount = "SELECT MAX(cust_ID) FROM members";
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

		public void AddMember()
		{
			
				//define oracle connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection
				conn.Open();

				//define sql query
				String strSQL = "INSERT INTO members VALUES ('" + this.cust_ID + "', '" + this.firstName + "', '" + this.lastName +
				"', '" + this.address + "', '" + this.town + "', '" + this.county_Code + "', '" + String.Format("{0:dd-MMM-yy}", this.dateOfRegistration) + "','" + this.phoneNumber + "', '" + this.pin + "', '" + this.status + "')";
				OracleCommand cmd = new OracleCommand(strSQL, conn);

				//execute commend
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
			
	
		}

		public void UpdateMember()
		{
			
				//define oracle connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection
				conn.Open();
		
				//define sql query
				String strSQLUpdate = "UPDATE members SET first_name = '" + this.firstName + "', last_name = '" + this.lastName + "', address = '" + this.address +
				"', county_Code = '" + this.county_Code + "', town = '" + this.town + "', phoneNumber = '" + this.phoneNumber + "', pin = '" + this.pin + "' WHERE cust_ID =" + this.cust_ID;
			OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);
	
			//execute command
			cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
			
		}

		public void RemoveMember()
		{
			try
			{
				//define sql connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection
				conn.Open();

				//define sql query
				String strSQLRemove = "DELETE FROM members WHERE cust_ID =" + this.cust_ID;
				OracleCommand cmd = new OracleCommand(strSQLRemove, conn);

				//execute command
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
			}
			catch
			{
				MessageBox.Show("member could not be removed");
			}
		}
		public bool ValidateMember(int cust_ID, String pin)
		{
			//define sql connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//define sql query
			String strSQLCount = "SELECT pin FROM members WHERE cust_ID = " + cust_ID + "AND status = 'A'";
			OracleCommand cmdCount = new OracleCommand(strSQLCount, conn);

			//execute command
			OracleDataReader dr = cmdCount.ExecuteReader();

			//read data
			dr.Read();
			bool check = false;
			if (dr.HasRows != true) {

				check = false;
				
			}
			else if (dr.GetString(0) == pin)
			{
				check = true;

			}
			else if (dr.GetString(0) != pin)
			{
				check = false;
			}
			conn.Close();
			return check;


		}
		public static DataSet GetSummaryMembers(String firstName)
		{
			//Define Oracle Connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//Define SQL Query.
			String strSQLDvd = "SELECT * FROM MEMBERS WHERE first_name LIKE '" + firstName + "%' AND status = 'A'";

			OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);

			OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);

			DataSet dataSet = new DataSet();

			dataAdapt.Fill(dataSet, "MEM");

			//close DB
			conn.Close();

			// return data set
			return dataSet;

		}

		public void UpdateMemberR(int custID)
		{
			try
			{
				//define oracle connection
				OracleConnection conn = new OracleConnection(DBConnect.oradb);

				//open connection 
				conn.Open();

				//define sql query
				String strSQLUpdate = "UPDATE MEMBERS SET status = '" + "R" + "' WHERE cust_ID =" + custID;
				OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);

				//execute command
				cmd.ExecuteNonQuery();

				//close connection
				conn.Close();
			}
			catch
			{
				MessageBox.Show("member status could not be updated to R");
			}
		}

		public bool CheckMember(String name)
		{
			//define sql connection
			OracleConnection conn = new OracleConnection(DBConnect.oradb);

			//open connection
			conn.Open();

			//define sql query
			String strSQLDvd = "SELECT * FROM MEMBERS WHERE First_Name LIKE '" + name + "%' AND status = 'A'";
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

	}
}


