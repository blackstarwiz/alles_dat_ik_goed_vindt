using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_SinglePlayer
{
    internal class Speelvakje
    {
        public int BeweegVakjes {get; private set;}

        public Speelvakje()
        {
            int randomNumber = new Random().Next(1, 11);
            if (randomNumber <= 3)
                BeweegVakjes = randomNumber > 1 ? randomNumber : 0;
            else if (randomNumber <= 5)
                BeweegVakjes = randomNumber < 5 ? -randomNumber : 0;
            else
                BeweegVakjes = 0;
        }

        public virtual void ToonVakje(bool kleurenVersie)
        {
            if (kleurenVersie)
            {
                if(BeweegVakjes < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            Console.Write(BeweegVakjes >= 0 ? "+" :BeweegVakjes);
            Console.Write(Math.Abs(BeweegVakjes));

            Console.ResetColor();
        }
     
    }
}
