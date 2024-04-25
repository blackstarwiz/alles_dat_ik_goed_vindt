using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_SinglePlayer
{
    internal class Ganzenbord
    {
        private static List<Speelvakje> SpeelVakjes {get; set; } = new List<Speelvakje>();
        private int pionIndex;
        private bool statusPion { get; set; } = false;
        public int HuidigeScore { get; set; } = 0;

       public Ganzenbord(bool kleurenVersie) {

            SpeelVakjes = new List<Speelvakje>();
            for (var i = 0; i < 10; i++)
            {
                if (kleurenVersie)
                {
                    Speelvakje vakje = new KleurVakje();
                    SpeelVakjes.Add(vakje);
                }
                else
                {
                    Speelvakje vakje = new Speelvakje();
                    SpeelVakjes.Add(vakje);
                }
            }
            pionIndex = 0;
            HuidigeScore = 0;
        }

        public bool BeweegPion(int aantalStappen)
        {
            pionIndex += aantalStappen;

            if(pionIndex > 9)
            {
                HuidigeScore += 10;
                pionIndex = 9;
                Console.WriteLine("Gefeliciteerd, je hebt gewonnen");
                return true;
            }
            else if(pionIndex < 0)
            {
                HuidigeScore -= 10;
                pionIndex = 0;
                Console.WriteLine("Je bent op een negatief vakje beland. Je score is verlaagd.");
                return false;
            }
            else
            {
                Speelvakje vakje = SpeelVakjes[pionIndex];
                pionIndex += vakje.BeweegVakjes;
                return (pionIndex > 8);
            }
        }

        public void TekenBord()
        {
           
            if (statusPion)
            {
                for (int i = 0; i < SpeelVakjes.Count; i++)
                {
                    SpeelVakjes[i].ToonVakje(true);
                }
                statusPion = false;
                Console.WriteLine();
            }
            else
            {
                for (var i = 0; i < SpeelVakjes.Count; i++)
                {
                    if (i == pionIndex)
                        Console.Write("_T");
                    Console.Write($"_{i+1}");
                }
                statusPion = true;
                Console.WriteLine();
                TekenBord();
            }
        }
    }
}
