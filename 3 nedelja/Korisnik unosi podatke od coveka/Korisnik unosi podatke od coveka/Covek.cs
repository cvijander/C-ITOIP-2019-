using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korisnik_unosi_podatke_od_coveka
{
    internal class Covek
    {
        private string Ime;
        private string Prezime;

        public void PozdraviSvet()
        {
            Console.WriteLine("Zdravo ja sam " + Ime  + " " + Prezime );
        }

        public void Ime_set(string i)
        {
            if(i.Length <25)
            {
                Ime = i;
            }
            else
            {
                Console.WriteLine("Greska predugacko ime");
            }
        }

        public void Prezime_set(string p) 
        {
            if(p.Length<35)
            {
                Prezime = p;
            }
            else
            {
                Console.WriteLine("Greska predugacko prezime");
            }
        }


    }
}
