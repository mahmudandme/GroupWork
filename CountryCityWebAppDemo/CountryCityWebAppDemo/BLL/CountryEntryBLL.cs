using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityWebAppDemo.DAL;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.BLL
{
    public class CountryEntryBLL
    {
        CountryEntryDataAccessLayer countryEntryDataAccessLayer = new CountryEntryDataAccessLayer();

        public bool IsCountryExist(string countryName)
        {
            return countryEntryDataAccessLayer.IsCountryExist(countryName);
        }

        public int SaveCountry(Country aCountry)
        {
          return countryEntryDataAccessLayer.SaveCountry(aCountry);
        }

        public List<Country> GetAllCountries()
        {
            return countryEntryDataAccessLayer.GetAllCountry();
        }

    }
}