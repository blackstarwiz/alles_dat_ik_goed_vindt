using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_SinglePlayer
{
    internal class KleurVakje : Speelvakje
    {
        public override void ToonVakje(bool kleurenVersie)
        {
            if (kleurenVersie)
            {
                if (BeweegVakjes < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
            }
            Console.Write(BeweegVakjes >= 0 ? "+" : BeweegVakjes);
            Console.Write(Math.Abs(BeweegVakjes));

            Console.ResetColor();
        }
    }
}
