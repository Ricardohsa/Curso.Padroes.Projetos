using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Flyweight
{
    public class UnsharedConcreteFlyweight: Flyweight
    {
        public override void Operation(int ext)
        {
            Console.WriteLine("ConcreteUnsharedConcreteFlyweight: " + ext);
        }
    }
}
