using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample
{
    internal class City
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public int CityPopulation { get; set; }
        public bool IsCapitalCity { get; set; }
        public Country Country { get; set; }
    }
}
