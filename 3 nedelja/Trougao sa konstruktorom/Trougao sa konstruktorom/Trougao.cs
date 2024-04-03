using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trougao_sa_konstruktorom
{
    internal class Trougao
    {
        private float a;
        private float b;
        private float c;

        public Trougao(float v1, float v2, float v3)
        {
            this.a = v1;
            this.b = v2;
            this.c = v3;
        }

        public float Obim()
        {
            return a + b + c;
        }

        public float Povrsina()
        {
            float s = Obim()/2;
            return (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
