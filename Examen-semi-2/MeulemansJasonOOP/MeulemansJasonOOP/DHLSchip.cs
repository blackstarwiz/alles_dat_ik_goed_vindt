using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeulemansJasonOOP
{
    internal class DHLSchip
    {
        public List<Doos> Vrachtruimte;
        int TotaalGewicht = 0;
        int TotaalPrijs = 0;
        string NaamSchip { get; set; }

        public DHLSchip(string Naam)
        {
            NaamSchip = Naam;
            Vrachtruimte = new List<Doos>();
        }
        public bool VoegDoosToe(Doos doos)
        {
            TotaalGewicht += doos.Gewicht;
            
            

            //2: Enkel al het totale gewicht van de VrachtRuimte niet over 10 gaat
            do
            {
                //3: indien doos te zwaar is dan wordt er een Exception geworpen
                if (TotaalGewicht > 10)
                {
                    throw new Exception("Te Zwaar Doos niet toegevoed");
                }
                else
                {
                    //1: Voegt doos toe aan List VrachtRuimte
                    Vrachtruimte.Add(doos);
                    //4: als doos toch kan toegevoegd worden return true;
                    return true;
                }

            } while (TotaalGewicht >= 10);
            
            
            
        }
        public void ToonManifest()
        {
            Console.Clear();
            Console.WriteLine($"{NaamSchip}");
            Console.WriteLine("************************");
            foreach(var dozen in Vrachtruimte)
            {
                TotaalPrijs += dozen.KostPrijs;
                if(dozen is ISafe)
                    Console.WriteLine($"-{dozen.Inhoudt}\t\t\t{dozen.Gewicht}\t\t\t{dozen.KostPrijs}###");
                Console.WriteLine($"-{dozen.Inhoudt}\t\t\t{dozen.Gewicht}\t\t\t{dozen.KostPrijs}");
            }
            Console.WriteLine($"-------------------------------");
            Console.WriteLine($"TOTAAL GEWICHT=\t\t\t{TotaalGewicht}\nTOTAAL PRIJS=\t\t\t{TotaalPrijs}");
        }
    }
}
