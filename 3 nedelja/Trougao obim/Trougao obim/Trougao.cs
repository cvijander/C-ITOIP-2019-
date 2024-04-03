using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trougao_obim
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
                Console.WriteLine("Greksa");
            }
        }

        public void b_set(float b)
        {
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
        }

        public void c_set(float c) 
        {
            if(c>0)
            {
                this.c = c;
            }
            else
            {
                Console.WriteLine("Greksa");
            }
        
        }

        public void PrikazStranica()
        {
            Console.WriteLine("Stranice trougla su ");
            Console.WriteLine("a= " +a);
            Console.WriteLine("b= " +b);
            Console.WriteLine("c= " +c);
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
    }
}
