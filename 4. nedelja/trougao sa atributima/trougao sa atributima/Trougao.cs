using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trougao_sa_atributima
{
    internal class Trougao
    {
        private float a, b, c;

        public Trougao(string odgovor)
        {
            string[] stranice = odgovor.Split(' ');
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
            return (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
