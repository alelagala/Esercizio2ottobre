using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2ottobre
{
    internal class Country
    {
        public string name;
        public string countryCode;
        public Continent continent;
        public List<City> cities;

        public Country(string name,string countryCode)
        {
            this.name = name;
            this.countryCode = countryCode;
            this.continent = null;
            this.cities = new List<City>();
        }
        
        public City addCity(City city)
        {
            this.cities.Add(city);
            city.country = this;
            return city;
        }


    }
}
