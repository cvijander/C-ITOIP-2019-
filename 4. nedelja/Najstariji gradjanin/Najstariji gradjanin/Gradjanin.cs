using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Najstariji_gradjanin
{
    internal class Gradjanin
    {
        private string jmbg;
        private string ime;
        private string prezime;

        public Gradjanin(string jmbg, string ime, string prezime)
        {
            if (jmbg.Length == 13 && ime.Length < 20 && prezime.Length < 25)
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
            string datum = "";
            datum += jmbg.Substring(0, 2) + ".";
            datum += jmbg.Substring(2, 2) + ".";
            if (jmbg[4] > '7')
            {
                datum += "1" + jmbg.Substring(4, 3);
            }
            else
            {
                datum += "2" + jmbg.Substring(4, 3);
            }
            return datum;
        }

        public string Godiste()
        {
            return jmbg.Substring(5, 2);
        }

        public string Ime_get()
        {
            return ime;
        }

        public DateTime KonvDat()
        {
            int dan = int.Parse(jmbg.Substring(0, 2));
            int mesec = int.Parse(jmbg.Substring(2, 2));
            int godina = 0;
            if (jmbg[4] > '7')
            {
                godina = 1000 + int.Parse(jmbg.Substring(4, 3));
            }
            else
            {
                godina = 2000 + int.Parse(jmbg.Substring(4, 3));
            }

            DateTime d = new DateTime(godina, mesec, dan);
            return d;
        }

        public string DaniStarosti()
        {
            DateTime rodj = KonvDat();
            DateTime trenutno = DateTime.Now;
            int dani = (trenutno - rodj).Days;
            return dani.ToString();
        }

        public string MinutiStarosti()
        {
            DateTime rodj = KonvDat();
            DateTime trenutno = DateTime.Now;
            int minuti = (int.Parse(DaniStarosti())) * 24 * 60 + (trenutno - rodj).Minutes;
            return minuti.ToString();
        }

        public string jmbg_get()
        {
            return jmbg;
        }
        public string prezime_get()
        {
            return prezime;
        }
    }
}
