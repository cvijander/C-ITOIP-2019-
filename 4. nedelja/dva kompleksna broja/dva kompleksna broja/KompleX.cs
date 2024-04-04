using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dva_kompleksna_broja
{
    internal class KompleX
    {
        private float x;
        private float y;

        public KompleX()
        {

        }

        public KompleX(float x, float y)
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
            string odgovor;
            if(x ==0)
            {
                odgovor = y + "i";
            }
            else if (y==0)
            {
                odgovor = x + "";
            }
            else if(y <0)
            {
                odgovor = x+ "" + y+ "i";
            }
            else
            {
                odgovor = x + "+" + y + "i";
            }
            return odgovor;
        }

        public void SaverBrojeve(KompleX z1, KompleX z2)
        {
            x = z1.Re() + z2.Re();
            y =z1.Im() + z2.Im();
        }

    }
}
