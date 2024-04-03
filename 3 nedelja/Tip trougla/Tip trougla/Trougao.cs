using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_trougla
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
            Console.WriteLine("Stranice trougla su");
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

        public void ProveraIspavnosit()
        {
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("Trougao je ispravan.");
            else
                Console.WriteLine("Trougao nije ispravan.");
        }

        public void Obim()
        {
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("Obim trougla: " + (a + b + c));
            else
                Console.WriteLine("Greska kod obima: Trougao nije ispravan.");
        }


        public void Tip()
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                List<float> L = new List<float>();
                L.Add(a); L.Add(b); L.Add(c);
                double hip = L.Max();
                if (hip * hip == a * a + b * b + c * c - hip * hip)
                {
                    Console.WriteLine("Trougao je pravougli.");
                }
                else if (hip * hip > a * a + b * b + c * c - hip * hip)
                {
                    Console.WriteLine("Trougao je tupougli.");
                }
                else
                {
                    Console.WriteLine("Trougao je oštrougli.");
                }

            }
            else Console.WriteLine("Trougao nije ispravan.");
        }

    }
}
