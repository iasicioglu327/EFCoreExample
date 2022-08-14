using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample
{
    internal class Location
    {
        public int ID { get; set; }
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set;}
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
