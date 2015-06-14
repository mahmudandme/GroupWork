using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityWebAppDemo.Model
{
    public class SearchCityModel
    {
       
        public int Serial { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int NumberOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public String Country { get; set; }
        public String AboutCountry { get; set; }
    }
}