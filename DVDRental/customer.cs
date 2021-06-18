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
    class customer
    {
        private int custid;
        private String address;
        private String surname;
        private String phone;
        private String forename;
 

   
        public customer()
        {
     
            custid = 0;
            address = "";
            surname = "";
            phone = "";
            forename = "";
        }

        public int getCustid()
        {
            return custid;
        }

        public String getAddress()
        {
            return address;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getPhone()
        {
            return phone;
        }

        public String getForename()
        {
            return forename;
        }

        public void setCustid(int custid)
        {
            this.custid = custid;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }


        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public void setForename(String forename)
        {
            this.forename = forename;
        }

        public static int getCountId()
        {
            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLId = "SELECT MAX(Cust_ID) FROM Customer";
            OracleCommand cmdNextId = new OracleCommand(strSQLId, conn);
            OracleDataReader dataRead = cmdNextId.ExecuteReader();
            dataRead.Read();
            if (dataRead[0] == DBNull.Value)  
                last = 1;
            else
                last = Convert.ToInt32(dataRead[0]) + 1;
            conn.Close();
            return last;
        }

        public void addCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLCust = "INSERT INTO Customer (cust_ID, Address, Surname, Phone, Forename) VALUES (" + getCountId() + ", '" +
                this.address + "', '" + this.surname + "', '" + this.phone + "', '" + this.forename.ToUpper() +"')";
            OracleCommand cmdCust = new OracleCommand(strSQLCust, conn);
            cmdCust.ExecuteNonQuery();
            conn.Close();
        }
  
 
    }
}
*/