using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoput
{
    internal class AutoputA
    {
        private string gradA;
        private string gradB;
        private float duzina;

        public AutoputA(string gradA, string gradB, float duzina)
        {
            this.gradA = gradA;
            this.gradB = gradB;
            this.duzina = duzina;
        }

        public override string ToString()
        {
            return "Autoput " + gradA + " - " + gradB + " " + (int)duzina + " km";
        }
    }
}
