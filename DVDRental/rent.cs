
/*
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
        private double price;


        public Rent()
        {

            rentid = 0;
            dvdid = 0;
            custid = 0;
            price = 0.00;
        }
     
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

        public double getprice()
        {
            return price;
        }

   
        public void setRentid(int rentid)
        {
            this.rentid = rentid;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setDvdid(int dvdid)
        {
            this.dvdid = dvdid;
        }

        public void setCustid(int custid) {
            this.custid = custid;
        }

/*
        public static DataSet getRents()
        {
            String strSQLRent = "SELECT * FROM Rent ORDER BY rent_ID";
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQLRent, conn);
            OracleDataAdapter dataAdapt = new OracleDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapt.Fill(dataSet, "WS");
            conn.Close();
            return dataSet;
        }
        */
/*
        public void getARent(int rentid)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLRent = "SELECT * FROM Rent WHERE rent_ID =" + rentid;
            OracleCommand cmd = new OracleCommand(strSQLRent, conn);
            OracleDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            this.rentid = dataReader.GetInt32(0);
            this.dvdid = dataReader.GetInt32(0);
            this.custid = dataReader.GetInt32(0);
            this.price = dataReader.GetInt32(0);
            conn.Close();
        } 
	
        public static int getCountId()
        {
          
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLCount = "SELECT MAX(rent_ID) FROM Rent";
            OracleCommand cmdCount = new OracleCommand(strSQLCount, conn);
            OracleDataReader dataRead = cmdCount.ExecuteReader();
            dataRead.Read();
            int l;
            if (dataRead[0] == DBNull.Value)
                l = 1;
            else
                l = Convert.ToInt32(dataRead[0]) + 1;
            conn.Close();
            return l;
        }

        public void addRent()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLAddRent = "INSERT INTO Rent (rent_ID, DVD_ID, cust_ID) VALUES ('" +
                this.rentid + "', '" + this.dvdid + "', '" + this.custid +"')";
            OracleCommand cmdAddRent = new OracleCommand(strSQLAddRent, conn);
            cmdAddRent.ExecuteNonQuery();
            conn.Close();
        }
        public void updaterent()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLUpdateRent = "UPDATE Rent SET rent_ID = '" + this.rentid + "', DVD_ID = '" +
                            this.dvdid + "', cust_ID = '" + this.custid +  "', Price = '" + this.price +
                            " WHERE rent_ID =" + this.id;
            OracleCommand cmdUpdate = new OracleCommand(strSQLUpdateRent, conn);
            cmdUpdate.ExecuteNonQuery();
            conn.Close();
        }
        
      
    }
}
*/