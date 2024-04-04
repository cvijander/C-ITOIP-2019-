using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradjanin
{
    internal class GradjaninG
    {
        private string jmbg;
        private string ime;
        private string prezime;

        public GradjaninG(string jmbg, string ime, string prezime)
        {
            if(jmbg.Length ==13 && ime.Length<20 && prezime.Length<25)
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
            string datumRodjenja = "";
            datumRodjenja += jmbg.Substring(0,2) + "."; //dodajemo dan rodjenja
            datumRodjenja += jmbg.Substring(2, 2) + "."; // dodajemo mesec rodjenja
           // datumRodjenja += jmbg.Substring(4, 3) + "."; // godina 
            if (jmbg[4]>'7') // 2 milenijum 
            {
                datumRodjenja += "1" + jmbg.Substring(4, 3);
            }
            else
            {
                datumRodjenja += "2" + jmbg.Substring(4, 3);
            }
            return datumRodjenja;
            
        }

         

    }
}
