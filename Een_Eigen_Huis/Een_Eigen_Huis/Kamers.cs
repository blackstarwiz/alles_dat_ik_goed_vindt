using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    internal class Kamers
    {
        public string Naam { get; }
        public decimal Oppervlakte { get; set; }

        public virtual decimal Prijs { get; } = 400;

        public Kamers(string naam, decimal oppervlakte)
        {
            Naam = naam;
            Oppervlakte = oppervlakte;
        }

    }
}
