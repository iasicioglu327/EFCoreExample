using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample
{
    internal class Country
    {
        
        public int ID { get; set; }
        public string CountryName { get; set; }
        public string Currency { get; set; }
        public string TimeZone { get; set; }
        public int CountryPopulation { get; set; }
        public ICollection<Language> Languages { get; set; } = new List<Language>();
        public ICollection<City> Cities { get; set; }
        public Location Location { get; set; }

        //MANY TO MANY LANGUAGE
        //ONE TO ONE LOCATION
        //ONE TO MANY CITY

    }
}
