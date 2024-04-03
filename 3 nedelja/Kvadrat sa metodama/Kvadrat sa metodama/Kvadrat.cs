using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadrat_sa_metodama
{
    internal class Kvadrat
    {
        private float a;
        private bool PopunjenaStranica;

        public void a_set(float a)
        {
            if(a>0)
            {
                this.a = a;
                PopunjenaStranica = true;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }

        public float a_get() 
        
        {
            if (!PopunjenaStranica)
            {
                return 0;
            }

            else
            {
                return this.a;
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
