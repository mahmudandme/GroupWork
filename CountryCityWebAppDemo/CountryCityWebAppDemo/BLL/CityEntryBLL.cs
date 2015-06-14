using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityWebAppDemo.DAL;
using CountryCityWebAppDemo.Model;

namespace CountryCityWebAppDemo.BLL
{
    public class CityEntryBLL
    {
        CityEntryDAL cityEntryDal = new CityEntryDAL();

        public List<Country> GetAllCountryNames()
        {
            return cityEntryDal.GetAllCountryName();
        }

        public bool IsCityExist(string cityName)
        {
            return cityEntryDal.IsCityNameExist(cityName);
        }

        public int SaveCityInformation(City city)
        {
            return cityEntryDal.SaveCityInformation(city);
        }

        public List<CityCountryModel> GetSomeCityInformation()
        {
            return cityEntryDal.GetSomeCityInformation();
        }
    }
}