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
    class DVD
    {

		private int catalogNO;
		private String title;
		private String filmCast;
		private String director;
		private String filmCategory;
		private int filmCost;
		private int dailyRent;


        public DVD()
        {
			catalogNO = 0;
			title = "";
			filmCast = "";
			director = "";
			filmCategory = "";
			filmCost = 0;
			dailyRent = 0;
		}

        public int getCatalogNo()
        {
            return catalogNO;
        }

        public String getTitle()
        {
            return title;
        }

        public String getFilmCast()
        {
			return filmCast;
        }
		public String getFilmCategory()
		{
			return filmCategory;
		}
		public String getDirector()
        {
            return director;
        }
		public int getFilmCost()
		{
			return filmCost;
		}
		public int getDailyRent()
		{
			return dailyRent;
		}

		public void setCatalogNo(int catalogNo)
        {
            this.catalogNO = catalogNo;
        }

        public void setTitle(String title)
        {
			this.title = title;
        }
		public void setFilmCategory(String filmcategory)
		{
			this.filmCategory = filmcategory;
		}
		public void setFilmCast(String filmCast)
        {
            this.filmCast = filmCast;
        }
		public void setDirector(String director)
		{
			this.director = director;
		}
		public void setFilmCost(int filmcost)
		{
			this.filmCost = filmcost;
		}
		public void setDailyRent(int dailyRent)
		{
			this.dailyRent = dailyRent;
		}

		public static DataSet getDvds()
        {
            String strSQLDvd = "SELECT * FROM STOCK ORDER BY catalog_NO";
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQLDvd, conn);
            OracleDataAdapter dataAdapt = new OracleDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapt.Fill(dataSet, "WS");
            conn.Close();
            return dataSet;
        }
                public static DataSet getgroupDvds()
                {

                    String strSQLDvd = "SELECT catalog_NO,title,filmcast,director,filmcategory,filmcost,daily_rent FROM STOCK ORDER BY catalog_NO";
                    OracleConnection conn = new OracleConnection(DBConnect.oradb);
                    conn.Open();
                    OracleCommand cmdDvd = new OracleCommand(strSQLDvd, conn);
                    OracleDataAdapter dataAdapt = new OracleDataAdapter(cmdDvd);
                    DataSet dataSet = new DataSet();
                    dataAdapt.Fill(dataSet, "WS");
                    conn.Close();
                    return dataSet;
                } 


        public void getOneDvd(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "SELECT * FROM stock WHERE catalog_NO =" + id;
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dataRead = cmd.ExecuteReader();
            dataRead.Read(); 
            this.filmCategory = dataRead.GetString(4);
            this.title = dataRead.GetString(5);
            conn.Close();
        }

        public static int getCountId()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLCount = "SELECT MAX(catalog_NO) FROM stock";
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

        public void addDvd()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "INSERT INTO stock(catalog_NO,title,filmcast,director,filmcategory,filmcost,daily_rent) VALUES (" + getCountId() + ",  '" + this.filmCast +  "', '" + this.filmCategory + "', '" + this.filmCost + "', '" + this.dailyRent + "')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
		/*
        public void updateDvd()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLUpdate = "UPDATE DVD SET DVD_status = '" + this.dvdstatus + "', DVD_category = '" +
                            this.dvdcat + "', DVD_name = '" + this.dvdname +
                            "' WHERE DVD_ID =" + this.id;
            OracleCommand cmd = new OracleCommand(strSQLUpdate, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }*/

        public void removeDvd()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQLRemove = "DELETE FROM DVD WHERE DVD_ID =" + this.catalogNO;
          
            OracleCommand cmd = new OracleCommand(strSQLRemove, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
