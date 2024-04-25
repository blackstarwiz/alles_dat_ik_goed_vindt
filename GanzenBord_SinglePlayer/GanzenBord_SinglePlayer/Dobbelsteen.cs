using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_SinglePlayer
{
    internal class Dobbelsteen
    {
        public static int Rol()
        {
            Random Dobbelsteen6Ogen = new Random();
            return Dobbelsteen6Ogen.Next(1, 7);   
        }
    }
}
