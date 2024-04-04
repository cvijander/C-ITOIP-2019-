using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Gradjanin_dani_starosti_i_minuti_starosti
{
    internal class Gradjanin
    {
        private string jmbg;
        private string ime;
        private string prezime;


        public Gradjanin(string jmbg, string ime, string prezime)
        {
            if(jmbg.Length==13 && ime.Length< 20 && prezime.Length< 25)
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
            if (jmbg[4] >'7')
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
            return jmbg.Substring(5,2);
        }

        public string Ime_Get()
        {
            return ime;
        }

        public DateTime KonvertDana()
        {
            int dan = int.Parse(jmbg.Substring(0, 2));
            int mesec = int.Parse(jmbg.Substring(2, 2));
            int godina = 0;
            if (jmbg[4]>'7')
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
            DateTime rodj = KonvertDana();
            DateTime danas = DateTime.Now;
            int daniStarost = (danas - rodj).Days;
            return daniStarost.ToString();
        }

        public string MinutiStarosti()
        {
            DateTime min = KonvertDana();
            DateTime danas = DateTime.Now;
            int minutiStarosti = int.Parse(DaniStarosti()) * 24 * 60 + (danas - min).Minutes;
            return minutiStarosti.ToString();
        }




    }
}
