using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradjanin_sa_jos_metodama
{
    internal class Gradjanin
    {
        private string jmbg;
        private string ime;
        private string prezime;

        public Gradjanin(string jmbg, string ime, string prezime)
        {
            if(jmbg.Length==13 && ime.Length<25 && prezime.Length <20)
            {
                this.jmbg = jmbg;
                this.ime = ime;
                this.prezime = prezime;
            }

            else
            {
                Console.WriteLine("Greska");
            }
        }

        public string DatumRodjenja()
        {
            string datim = "";
            datim += jmbg.Substring(0, 2) + ".";
            datim += jmbg.Substring(2, 2) + ".";
            if (jmbg[4]>'7')
            {
                datim += "1" + jmbg.Substring(4, 3) + ".";
            }
            else
            {
                datim += "2" + jmbg.Substring(4, 3) + ".";
            }
            return datim;
        }

        public string Godiste()
        {
            return jmbg.Substring(5, 2);
        }

        public string Ime_Get()
        {
            return ime;
        }

        public DateTime KonvDat()
        {
            int dan = int.Parse(jmbg.Substring(0, 2));
            int mesec = int.Parse(jmbg.Substring(2, 2));
            int godina = 0;
            if (jmbg[4]> '7')
            {
                godina = 1000+ int.Parse(jmbg.Substring(4,3));
            }
            else
            {
                godina = 2000 + int.Parse(jmbg.Substring(4, 3));
            }
            DateTime d = new DateTime(godina, mesec, dan);
            return d;
        }
    }
}
