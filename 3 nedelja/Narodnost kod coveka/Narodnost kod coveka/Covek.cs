using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narodnost_kod_coveka
{
    internal class Covek
    {
        private string Ime;
        private string Prezime;
        private string Narodnost;
        private bool UnetoIme;
        private bool UnetoPrezime;
        private bool UnetaNarodnost;

        //metode klase 
        public void PozdravNaMaternjemJeziku()
        {
            if(!UnetoIme || !UnetoPrezime || ! UnetaNarodnost)
            {
                Console.WriteLine("Greska podaci nisu pravilno uneti");
            }
            else if (Narodnost.ToLower() == "englez")
            {
                Console.WriteLine("Hi , I am " + Ime + " " + Prezime);
            }
            else if (Narodnost.ToLower() == "spanac")
            {
                Console.WriteLine("Hola ,estoy " + Ime + " " + Prezime);
            }
            else if (Narodnost.ToLower() == "srbin")
            {
                Console.WriteLine("Zdravo ja sam " + Ime + " " + Prezime);
            }
            else
            {
                Console.WriteLine(" Sistem ne poznaje odabrani maternji jezik");
            }
        }

        public void Ime_set(string i)
        {
            if (i.Length<25)
            {
                Ime = i;
                UnetoIme = true;
            }
            else
            {
                Console.WriteLine("Greska Predugacko ime");
            }
        }

        public void Prezime_set(string p)
        {
            if(p.Length <35 )
            {
                Prezime = p;
                UnetoPrezime = true;
            }
            else
            {
                Console.WriteLine("Greska predugacko prezime");
            }
        }

        public void Narodnost_set(string n)
        {
            if(n.Length<25)
            {
                Narodnost = n;
                UnetaNarodnost = true;
            }
            else
            {
                Console.WriteLine("Greksa predugacka narodnost");
            }
        }
    }
}
