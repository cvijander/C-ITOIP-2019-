using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razlomak_preko_konstruktora_i_preko_metode
{
    internal class Razlomak
    {
        private int ceoBroj, imenilac, brojilac;

        public Razlomak()
        {

        }

        public Razlomak(int ceo, int bro, int ime)
        {
            if(ime !=0 && bro <ime)
            {
                ceoBroj = ceo;
                imenilac = ime;
                brojilac= bro;
            }
            else
            {
                Console.WriteLine("Greksa");
            }
        }

        public void CeoBroj_Set(int v)
        {
            ceoBroj = v;
        }

        public void Imenilac_Set(int v)
        {
            if(v != 0 && v >brojilac)
            {
                imenilac = v;
            }
            else if(v ==0)
            {
                Console.WriteLine("Greska: imenilac ne sme biti nula");
            }
            else
            {
                Console.WriteLine("Greska Brojilac mora biti manji od imenioca");
            }
        }

        public void Brojilac_Set(int v)
        {
            if(v <= imenilac || brojilac ==0)
            {
                brojilac = v;
            }
            else
            {
                Console.WriteLine("Greska brojilac mora biti manji od imenioca");
            }
        }

        public int CeoBroj_Get()
        {
            return ceoBroj;
        }

        public int Imenilac_Get()
        {
            return imenilac;
        }

        public int Brojilac_Get() 
        {
            return brojilac;
        }

        public float PribliznaVrednost()
        {
            float pribliznaVrednost;
            pribliznaVrednost = ceoBroj + brojilac / (float)imenilac;
            return pribliznaVrednost;
        }

        public override string ToString()
        {
            if(ceoBroj !=0 && brojilac >0)
            {
                string raz = ceoBroj + " " + brojilac + "/ " + imenilac;
                return raz;
            }
            else if( brojilac >0)
            {
                string raz = brojilac + "/" + imenilac;
                return raz;
            }
            else
            {
                string raz = ceoBroj.ToString();
                return raz;
            }
        }
    }
}
