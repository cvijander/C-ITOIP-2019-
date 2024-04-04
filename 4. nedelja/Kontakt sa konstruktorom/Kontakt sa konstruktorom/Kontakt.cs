using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakt_sa_konstruktorom
{
    internal class Kontakt
    {
        private string ime, prezime, brtel, email;

        public Kontakt(string v1,string v2, string v3, string v4)
        {
            this.ime = v1;
            this.prezime = v2;
            this.brtel = v3;
            this.email = v4;
        }

        public Kontakt(string odg)
        {
            string[] niz = odg.Split(' ');
            ime = niz[0];
            prezime = niz[1];
            brtel = niz[2];
            email = niz[3];
        }

        public string Ime_Get()
        {
            return ime;
        }

        public string Prezime_Get()
        {
            return prezime;
        }

        public string Brtel_Get() 
        {
            return brtel;
        }

        public string Email_Get() 
        {
            return email;
        }

        public void Ime_Set(string v)
        {
            ime= v;
        }

        public void Prezime_Set(string v)
        {
            prezime= v;
        }

        public void BrTel_Set(string v)
        {
            brtel= v;
        }

        public void Email_Set(string v)
        {
            email= v;
        }

        public override string ToString()
        {
            return ime + "\t" + prezime + "\t" + brtel+ "\t" + email;
        }
    }
}
