using System;
using System.Linq;

namespace Esercizio2ottobre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Continent europe = new Continent("Europe");
            Country italy = new Country("Italy", "abc129vi");
            City bari = new City("Bari", 70235);
            Citizen citizen1 = new Citizen("Alessandro", "La Gala", "29428ychsi");

            italy = europe.addCountry(italy);
            bari=italy.addCity(bari);
            for(int i = 0; i < 10; i++)
            {
                bari.addCitizen(citizen1);                
            }

            for(int i = 0; i < italy.cities[0].citizens.Count(); i++)
            {
                Console.WriteLine(italy.cities[0].citizens[i].Name);
            }


        }
    }
}
