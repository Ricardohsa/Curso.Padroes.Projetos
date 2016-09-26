using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new CalcProxy();
            var r = calc.Somar(10, 5);
            Console.WriteLine(r.ToString());

            Console.Read();
        }

    }
}
