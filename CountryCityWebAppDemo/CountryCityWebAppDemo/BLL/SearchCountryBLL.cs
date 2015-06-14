using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityWebAppDemo.DAL;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.BLL
{
    public class SearchCountryBLL
    {
        SearchCountryDAL searchCountryDal = new SearchCountryDAL();

        public List<SearchCountryModel> GetAllCountryByCountryName(string partialCountryName)
        {
            return searchCountryDal.GetAllCountryInfromationByCountryName(partialCountryName);
        }
    }
}