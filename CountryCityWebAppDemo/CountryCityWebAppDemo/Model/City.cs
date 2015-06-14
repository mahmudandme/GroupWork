using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityWebAppDemo.Model
{
    public class City
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String About { get; set; }
        public int NumberOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryID { get; set; }

    }
}