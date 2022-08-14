using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample
{
    internal class Language
    {
        public int ID { get; set; }
        public string SpokenLanguage { get; set; }
        public ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
