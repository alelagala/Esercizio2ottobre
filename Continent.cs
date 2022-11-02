using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2ottobre
{
    internal class Continent
    {
        public string Name { get; set; }
        public List<Country> countries;
        public Continent(string name)
        {
            Name = name;
            countries = new List<Country>();
        }

        public Country addCountry(Country country)
        {
            this.countries.Add(country);
            country.continent= this;
            return country;
        }
    }
}
