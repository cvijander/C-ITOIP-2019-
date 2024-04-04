using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakt
{
    internal class KontaktK
    {
        private string ime;
        private string prezime;
        private string brtel;
        private string email;

        public KontaktK(string v1, string v2 , string v3 , string v4)

        {
            ime = v1;
            prezime = v2;
            brtel = v3;
            email = v4;
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
            ime=v;
        }

        public void Prezime_Set(string v) 
        {
            prezime=v;
        }

        public void BrTel_Set(string v)
        {
            brtel=v;
        }

        public void Email_Set(string v)
        {
            email=v;
        }

        public override string ToString()
        {
            return ime + "\t" + prezime + "\t" + brtel + "\t" + email;
        }

    }
}
