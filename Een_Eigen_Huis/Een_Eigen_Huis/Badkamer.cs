using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    internal class Badkamer : Kamers
    {
        public override decimal Prijs { get { return 500; } }

        public Badkamer(string naam, decimal opperVlakte) : base(naam, opperVlakte) { }
    }
}
