using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    internal class Huis
    {
        private List<Kamers> Kamers { get; set; }

        public Huis()
        {
            Kamers = new List<Kamers>();
        }
        public void VoegKamerToe(Kamers kamer)
        {
            Kamers.Add(kamer);
        }

        public decimal BerekenPrijs()
        {
            decimal totaal = 0;
            foreach(Kamers kamer in Kamers)
            {
                totaal += kamer.Prijs;
            }
            return totaal;
        }

        public override string ToString()
        {
            decimal total = 0;
            string result = "";
            string resultC = "";
           foreach(var kamer in Kamers)
            {
                total += kamer.Prijs;
                resultC += $"{kamer.Naam}\n{kamer.Prijs}\n";
               
            }
            result = $"{resultC}\nTotal: {total}";
            Console.WriteLine(result);
            return result;
        }

    }
}
