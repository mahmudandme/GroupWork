using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.DAL
{
    public class CityEntryDAL
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        public CityEntryDAL()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }

        public List<Country> GetAllCountryName()
        {
            string query = String.Format("Select * from tblCountry");
            sqlCommand.CommandText = query;
            List<Country> countries = new List<Country>();

            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                Country country = new Country();
                country.ID = Convert.ToInt32(rdr[0]);
                country.Name = rdr[1].ToString();
                countries.Add(country);
            }
            sqlConnection.Close();
            return countries;
        }

        public bool IsCityNameExist(string cityName)
        {
            bool isCityExist = false;
            string query = String.Format("Select * from tblCity where cityName=@Name");
            sqlCommand.CommandText = query;
            SqlParameter nameParameter = new SqlParameter("@Name",cityName);
            sqlCommand.Parameters.Add(nameParameter);


            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                isCityExist = true;
            }
            sqlConnection.Close();
            return isCityExist;

        }

        public int SaveCityInformation(City city)
        {
            string query = String.Format(@"Insert into tblCity values(@cityName,@about," +
                                         "@numberOfDewllers,@location,@weather,@countryID)");
            sqlCommand.CommandText = query;
            SqlParameter nameParameter = new SqlParameter("@cityName",city.Name);
            sqlCommand.Parameters.Add(nameParameter);

            SqlParameter aboutParameter = new SqlParameter("@about",city.About);
            sqlCommand.Parameters.Add(aboutParameter);

            SqlParameter numberOfDwlParameter = new SqlParameter("@numberOfDewllers",city.NumberOfDwellers);
            sqlCommand.Parameters.Add(numberOfDwlParameter);

            SqlParameter locationParameter = new SqlParameter("@location",city.Location);
            sqlCommand.Parameters.Add(locationParameter);

            SqlParameter weatherParameter = new SqlParameter("@weather",city.Weather);
            sqlCommand.Parameters.Add(weatherParameter);

            SqlParameter countryIdParameter = new SqlParameter("@countryID",city.CountryID);
            sqlCommand.Parameters.Add(countryIdParameter);
            sqlConnection.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected;
        }

        public List<CityCountryModel> GetSomeCityInformation()
        {
            List<CityCountryModel> cityCountryModels = new List<CityCountryModel>();
            string query = String.Format("spGetSomeCityInformation");
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            int serialNumber = 1;
            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                CityCountryModel cityCountry = new CityCountryModel();
                cityCountry.Serial = serialNumber;
                cityCountry.Name = rdr[0].ToString();
                cityCountry.NumberOfDwellers = Convert.ToInt64(rdr[1]);
                cityCountry.Country = rdr[2].ToString();
                cityCountryModels.Add(cityCountry);
            }
            sqlConnection.Close();
            return cityCountryModels;

        }

    }
}