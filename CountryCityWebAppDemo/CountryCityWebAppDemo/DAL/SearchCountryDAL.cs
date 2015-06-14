using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.DAL
{
    public class SearchCountryDAL
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public SearchCountryDAL()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }

        public List<SearchCountryModel> GetAllCountryInfromationByCountryName(string countryName)
        {
            List<SearchCountryModel> searchCountryModels = new List<SearchCountryModel>();
            int serialNumber = 1;
            string query = String.Format(@"select tblCountry.countryName ,tblCountry.about, 
                                         COUNT(tblCity.cityName) ,SUM(tblCity.numberOfDwellers)
                                          from tblCountry join tblCity on tblCountry.id = tblCity.countryID
                                          where tblCountry.countryName like @partialCountryName
                                          group by tblCountry.countryName , tblCountry.about");
            sqlCommand.CommandText = query;
            SqlParameter partialNameParameter = new SqlParameter("@partialCountryName","%"+countryName+"%");
            sqlCommand.Parameters.Add(partialNameParameter);

            sqlConnection.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            while (rdr.Read())
            {
                SearchCountryModel searchCountryModel = new SearchCountryModel();
                searchCountryModel.Serial = serialNumber;
                searchCountryModel.Name = rdr[0].ToString();
                searchCountryModel.About = rdr[1].ToString();
                searchCountryModel.NoOfCity = Convert.ToInt32(rdr[2]);
                searchCountryModel.NoOfCityDweller = Convert.ToInt32(rdr[3]);
                searchCountryModels.Add(searchCountryModel);
                serialNumber++;
            }
            sqlConnection.Close();
            return searchCountryModels;


        }

    }
}