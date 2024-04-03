using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadrat_i_porednje_dva_kvadrata
{
    internal class Kvadrat
    {
        private float a;
        private bool PopunjenaStranica;

        public void a_set(float a)
        {
            if(a>0)
            {
                PopunjenaStranica = true;
                this.a = a;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }

        public float a_get()
        {
            if(!PopunjenaStranica)
            {
                return 0;
            }
            else
            {
                return a;
            }      

        }

        public float Obim()
        {
            if(!PopunjenaStranica)
            {
                return 0;
            }
            else
            {
                return 4 * a;
            }
        }

        public float Povrsina()
        {
            if(!PopunjenaStranica)
            {
                return 0;
            }
            else
            {
                return a * a;
            }
        }

    }
}
