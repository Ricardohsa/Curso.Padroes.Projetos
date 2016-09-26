using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Proxy
{
    public class Calc : ICalc
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
