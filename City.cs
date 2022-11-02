using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2ottobre
{
    internal class City
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Country country;
        public List<Citizen> citizens { get; set; }


        public City(string name, int id)
        {
            Name = name;
            Id = id;
            this.country = null;
            this.citizens = new List<Citizen>();
        }

        public Citizen addCitizen(Citizen citizen)
        {
            if (this.citizens.Count() < 5)
            {
                Console.WriteLine(this.citizens.Count());
                citizens.Add(citizen);
                citizen.City = this;
                return citizen;
            }
            else
            {
                Console.WriteLine("La città è al completo.");
                return citizen;
            }

        }
    }
}
