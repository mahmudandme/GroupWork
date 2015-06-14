using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityWebAppDemo.DAL;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.BLL
{
    public class SearchCityBLL
    {
        SearchCityDAL searchCityDAL = new SearchCityDAL();

        public List<Country> GetAllCountryName()
        {
            return searchCityDAL.GetAllCountryName();
        }

        public List<SearchCityModel> GetAllCityInfromation()
        {
            return searchCityDAL.GetAllCityInformation();
        }

        public List<SearchCityModel> GetIntendedCityInfromation(string partialCityName)
        {
            return searchCityDAL.GetIntendedCityInformation(partialCityName);
        }

        public List<SearchCityModel> GetIntendedCityInformationByCountryName(string countryName)
        {
            return searchCityDAL.GetIntendedCityInformationByCountry(countryName);
        }


    }
}