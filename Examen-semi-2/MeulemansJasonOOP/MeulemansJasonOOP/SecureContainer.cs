using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeulemansJasonOOP
{
    internal class SecureContainer: Container, ISafe
    {

        public SecureContainer(int id): base(id)
        {
            ID = id;
        }

        int NumberOfAttemps = 0;
        public int GeefAantalAttemps()
        {
            NumberOfAttemps++;
            return NumberOfAttemps;
        }

        public void VerzegelInhoudt()
        {
            base.Gewicht = 0;
            int WordLength = base.Inhoudt.Length;
            for (int i = 0; i < WordLength; i++)
            {
                base.Inhoudt += "*";
            }
        }
    }
}
