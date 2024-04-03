using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_sa_metodama
{
    internal class Covek
    {
        private string Ime;
        private string Prezime;

        public void PozdraviSvet()
        {
            Console.WriteLine("Zdravo svima ja sam " + Ime + " " + Prezime);
        }

        public void Ime_Set(string i )
        {
            if(i.Length <25)
            {
                Ime = i;
            }
        }

        public void Prezime_Set(string p) 
        {
            if(p.Length <35)
            {
                Prezime = p;
            }
        }
    }
}
