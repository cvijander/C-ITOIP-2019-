using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komplex_broj
{
    internal class KompleX
    {
        private float x;
        private float y;

        public KompleX (float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float Re()
        {
            return x;
        }

        public float Im()
        {
            return y;
        }

        public override string ToString()
        {
            string odg;
            if(y < 0)
            {
                odg = x + " " + y + "i";
            }
            else
            {
                odg = x + " +" + y + "i";
            }
            return odg;
        }
    }
}
