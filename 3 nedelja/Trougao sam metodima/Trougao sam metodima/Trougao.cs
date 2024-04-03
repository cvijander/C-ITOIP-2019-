using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trougao_sam_metodima
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
                Console.WriteLine("Greska stranica a mora biti pozitivna");
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
                Console.WriteLine("Greska stranica b mora biti pozitivna");
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
                Console.WriteLine("Greska stranica c mora biti pozitivna");
            }
        }

        public void PrikazStranica()
        {
            Console.WriteLine("Stranice trougla su ");
            Console.WriteLine("a= " +a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("c= " + c);
        }
    }
}
