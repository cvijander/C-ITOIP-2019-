using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trougao_i_metoda_obim
{
    internal class Trougao
    {
        private float a;
        private float b;
        private float c;

        public void a_set(float a)
        {
            if(a>0)
            {
                this.a = a;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }

        public void b_set(float b)
        {
            if(b>0)
            {
                this.b = b;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }

        public void c_set(float c)
        {
            if(c>0)
            {
                this.c = c;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }

        public void PrikazStranica()
        {
            Console.WriteLine("Stranice trougla su ");
            Console.WriteLine("a= " +a);
            Console.WriteLine("b= " +b);
            Console.WriteLine("c= " + c);
        }

        public float a_get()
        {
            return a;
        }
        public float b_get()
        {
            return b;
        }

        public float c_get()
        {
            return c;
        }

        public void ProveraIspravnosti()
        {
            if(a < b+c && b < a+c && c< a+b)
            {
                Console.WriteLine("Trougao je ispravan");
            }
            else
            {
                Console.WriteLine("Trougao nije ispravan");
            }
        }

        internal void Obim ()
        {
            if(a < b + c && b < a+c && c< a+b )
            {
                Console.WriteLine("Obim trougla " + (a+ b+c));
            }
            else
            {
                Console.WriteLine("Trougao nije isprtavan");
            }
        }
    }
}
