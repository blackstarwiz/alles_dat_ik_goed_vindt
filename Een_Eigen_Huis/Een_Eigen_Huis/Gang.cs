using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    internal class Gang : Kamers
    {
        public override decimal Prijs
        {
            get
            {
                return Oppervlakte * 10;
            }
        }

        public Gang(string naam, decimal opperVlakte) : base(naam, opperVlakte) { }
    }
}
