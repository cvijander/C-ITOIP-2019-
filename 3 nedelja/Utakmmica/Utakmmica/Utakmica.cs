using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utakmmica
{
    internal class Utakmica
    {
        private string domacin;
        private string gost;
        private int goloviDomacin;
        private int goloviGost;

        public Utakmica(string v1,string v2)
        {
            domacin = v1;
            gost = v2;
            this.goloviDomacin = 0;
            this.goloviGost = 0;
        }

        public void Gol(string klub)
        {
            if(klub==domacin)
            {
                goloviDomacin++;
            }
            else if(klub ==gost)
            {
                goloviGost++;
            }
            else
            {
                Console.WriteLine("Greska neipsavan naziv kluba");
            }
        }

        public void Kraj()
        {
            Console.WriteLine(domacin + " - " + gost +" (" + goloviDomacin +"-" + goloviGost + ")");
            if(goloviDomacin ==goloviGost)
            {
                Console.WriteLine("Nereseno");
            }
            else if (goloviDomacin > goloviGost)
            {
                Console.WriteLine("Pobeda " + domacin +".");
            }
            else
            {
                Console.WriteLine("Pobeda za " + gost + ".");
            }

        }
    }
}
