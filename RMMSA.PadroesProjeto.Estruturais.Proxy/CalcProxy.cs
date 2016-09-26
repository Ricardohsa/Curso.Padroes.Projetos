using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Proxy
{
    public class CalcProxy: ICalc
    {
        //RealSubject
        private Calc _calc;

        public int Somar(int x, int y)
        {
            //instanica por demanda (lazy)
            if (_calc == null)
            {
                _calc = new Calc();
            };

            //repassando chamada ao RealSubject
            return _calc.Somar(x, y);
        }
    }
}
