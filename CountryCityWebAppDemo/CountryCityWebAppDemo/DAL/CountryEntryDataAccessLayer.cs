using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.DAL
{
    public class CountryEntryDataAccessLayer
    {

        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;


        public CountryEntryDataAccessLayer() 
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

        }

        public bool IsCountryExist(string countryName)
        {
            bool isCountryExist = false;
            String query = String.Format("select * from tblCountry where countryName=@Name");
            sqlCommand.CommandText = query;

            SqlParameter nameParameter = new SqlParameter("@Name",countryName);
            sqlCommand.Parameters.Add(nameParameter);

            sqlConnection.Open();
            SqlDataReader rdr =  sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                isCountryExist = true;
            }
            sqlConnection.Close();
            return isCountryExist;
        }

        public int SaveCountry(Country aCountry)
        {
            String query = string.Format("Insert into tblCountry values(@Name1,@About1)");
            sqlCommand.CommandText = query; 
            
             SqlParameter nameParameter = new SqlParameter("@Name1",aCountry.Name);
            sqlCommand.Parameters.Add(nameParameter);

            SqlParameter aboutParameter = new SqlParameter("@About1",aCountry.About);
            sqlCommand.Parameters.Add(aboutParameter);

            sqlConnection.Open();
            int rowsInserted =  sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return rowsInserted;
        }

        public List<Country> GetAllCountry()
        {
            string query = string.Format("Select * from tblCountry");
            sqlCommand.CommandText = query;
            List<Country> countries = new List<Country>();
            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            int serialNumber = 1;
            while (rdr.Read())
            {
                Country country = new Country();
                country.ID = serialNumber;
                country.Name = rdr[1].ToString();
                country.About = rdr[2].ToString();
                countries.Add(country);
                serialNumber++;
            }
            sqlConnection.Close();
            return countries;
        }
    }
}