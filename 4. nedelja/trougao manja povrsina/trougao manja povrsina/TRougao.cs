using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trougao_manja_povrsina
{
    internal class TRougao
    {
        private float a;
        private float b;
        private float c;

        public TRougao(string odgovro)
        {
            string[] stranice = odgovro.Split(' ');
            a = float.Parse(stranice[0]);
            b = float.Parse(stranice[1]);
            c = float.Parse(stranice[2]);
        }

        public float Obim()
        {
            return a + b + c;
        }

        public float Povrsina()
        {
            float s = Obim() / 2;
            return (float)Math.Sqrt(s *(s-a) *(s-b) * (s-c));
        }

        public float A_get()
        {
            return a;
        }
        public float B_get() 
        {
            return b;
        }

        public float C_get() 
        {
            return c;
        }

    }

    

    
}
