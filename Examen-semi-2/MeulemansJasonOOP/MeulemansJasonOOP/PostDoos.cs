using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeulemansJasonOOP
{
    internal class PostDoos : Doos
    {

        public PostDoos(int id): base(id)
        {
            ID = id;
        }


        public override int KostPrijs
        {
            get{ return 10; } 
        }
    }
}
