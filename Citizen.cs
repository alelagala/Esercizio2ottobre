using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2ottobre
{
    internal class Citizen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FC { get; set; }
        public City City { get; set; }

        public Citizen(string name, string surname, string FC)
        {
            Name = name;
            Surname = surname;
            this.FC = FC;
            City = null;
        }



    }
}
