using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razlomak
{
    internal class RazlomakR
    {
        //atributi klase
        private int ceoBroj, imenilac, brojiac;

        // metode kalse
        // 1 set metode  sluze nam za upis podataka
        public void CeoBroj_Set(int v)
        {
            ceoBroj = v;
        }

        public void Imenilac_Set(int v)
        {
            imenilac = v;// neoprezno
        }

        public void Brojilac_Set(int v)
        {
            brojiac = v;
        }

        // get metode sluze nam da procitamo pogledamo podatak

        public int CeoBroj_Get()
        {
            return ceoBroj;
        }

        public int Brojilac_Get() 
        {
            return brojiac;
        }

        public int Imenilac_Get()
        {
            return imenilac;
        }

        // ostale metode 
        public float PribliznaVrednost()
        {
            float pribliVrednost;
            pribliVrednost = ceoBroj + brojiac / (float)imenilac;
            return pribliVrednost;
        }



    }
}
