using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    internal class Salon : Kamers
    {
        private bool Schouw { get; set; } = false;

        public override decimal Prijs
        {
            get
            {
                return Schouw ? 500 : 300;
            }
        }

        public Salon(string naam, decimal opperVlakte, bool heeftSchouw) : base(naam, opperVlakte) {

            this.Schouw = heeftSchouw;
        }
    }
}
