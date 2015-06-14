using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityWebAppDemo.Model;
using CountryCityWebAppDemo.UI;

namespace CountryCityWebAppDemo.DAL
{
    public class SearchCityDAL
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public SearchCityDAL()
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

        public List<SearchCityModel> GetAllCityInformation()
        {
            List<SearchCityModel> searchCityModels = new List<SearchCityModel>();
            int serialNumber = 1;
            string query = String.Format(@"select tblCity.cityName , tblCity.about , tblCity.numberOfDwellers ,
                                           tblCity.location , tblCity.weather , tblCountry.countryName , tblCountry.about
                                           from tblCity join tblCountry on tblCity.countryID = tblCountry.id ");
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                SearchCityModel searchCityModel = new SearchCityModel();
                searchCityModel.Serial = serialNumber;
                searchCityModel.Name = rdr[0].ToString();
                searchCityModel.About = rdr[1].ToString();
                searchCityModel.NumberOfDwellers = Convert.ToInt32(rdr[2]);
                searchCityModel.Location = rdr[3].ToString();
                searchCityModel.Weather = rdr[4].ToString();
                searchCityModel.Country = rdr[5].ToString();
                searchCityModel.AboutCountry = rdr[6].ToString();
                searchCityModels.Add(searchCityModel);
                serialNumber++;
            }
            sqlConnection.Close();
            return searchCityModels;
        }

        public List<SearchCityModel> GetIntendedCityInformation(string partialCityName)
        {
            int serialNumber = 1;
            List<SearchCityModel> searchCityModels = new List<SearchCityModel>();
            string query = String.Format(@"select tblCity.cityName , tblCity.about , tblCity.numberOfDwellers ,
                                        tblCity.location , tblCity.weather , tblCountry.countryName , tblCountry.about
                                        from tblCity join tblCountry on tblCity.countryID = tblCountry.id
                                        where tblCity.cityName like @partialCityName");
            sqlCommand.CommandText = query;
            SqlParameter partialNameParameter = new SqlParameter("@partialCityName","%"+partialCityName+"%");
            sqlCommand.Parameters.Add(partialNameParameter);

            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                SearchCityModel searchCityModel = new SearchCityModel();
                searchCityModel.Serial = serialNumber;
                searchCityModel.Name = rdr[0].ToString();
                searchCityModel.About = rdr[1].ToString();
                searchCityModel.NumberOfDwellers = Convert.ToInt32(rdr[2]);
                searchCityModel.Location = rdr[3].ToString();
                searchCityModel.Weather = rdr[4].ToString();
                searchCityModel.Country = rdr[5].ToString();
                searchCityModel.AboutCountry = rdr[6].ToString();
                searchCityModels.Add(searchCityModel);
                serialNumber++;
            }
            sqlConnection.Close();
            return searchCityModels;

        }

        public List<SearchCityModel> GetIntendedCityInformationByCountry(string countryName)
        {
            int serialNumber = 1;
            List<SearchCityModel> searchCityModels = new List<SearchCityModel>();
            string query = String.Format(@"select tblCity.cityName , tblCity.about , tblCity.numberOfDwellers ,
                                        tblCity.location , tblCity.weather , tblCountry.countryName , tblCountry.about
                                        from tblCity join tblCountry on tblCity.countryID = tblCountry.id
                                        where tblCountry.countryName=@countryName");
            sqlCommand.CommandText = query;
            SqlParameter countryNameParameter = new SqlParameter("@countryName",countryName);
            sqlCommand.Parameters.Add(countryNameParameter);

            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            if (rdr == null)
            {
                searchCityModels = null;
            }
            while (rdr.Read())
            {
                SearchCityModel searchCityModel = new SearchCityModel();
                searchCityModel.Serial = serialNumber;
                searchCityModel.Name = rdr[0].ToString();
                searchCityModel.About = rdr[1].ToString();
                searchCityModel.NumberOfDwellers = Convert.ToInt32(rdr[2]);
                searchCityModel.Location = rdr[3].ToString();
                searchCityModel.Weather = rdr[4].ToString();
                searchCityModel.Country = rdr[5].ToString();
                searchCityModel.AboutCountry = rdr[6].ToString();
                searchCityModels.Add(searchCityModel);
                serialNumber++;
            }
            sqlConnection.Close();
            return searchCityModels;

        }

    }

}