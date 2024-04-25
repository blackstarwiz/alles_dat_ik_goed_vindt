using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeulemansJasonOOP
{
    abstract class Doos
    {
        public Doos(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
        public int Gewicht { get; set; }
        public string Inhoudt { get; set; }

        public virtual int KostPrijs
        {
            get
            {
                return Gewicht * 10;
            }
        }


    }
}
