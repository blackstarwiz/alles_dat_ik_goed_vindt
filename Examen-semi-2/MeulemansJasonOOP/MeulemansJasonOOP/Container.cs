using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeulemansJasonOOP
{
    internal class Container: Doos
    {
        public Container(int id) : base(id)
        {
            ID=id;
        }

        public override int KostPrijs
        {
            get
            {
               return base.KostPrijs + 10 ;
            }
        }
    }
}
