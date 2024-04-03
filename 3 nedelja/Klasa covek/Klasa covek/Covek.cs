using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_covek
{
    internal class Covek
    {
        public string Ime;
        public string Prezime;

        public void Pozdravisvet()
        {
            Console.WriteLine("Zdravo ja sam " + Ime + " " + Prezime);
        }
    }
}
