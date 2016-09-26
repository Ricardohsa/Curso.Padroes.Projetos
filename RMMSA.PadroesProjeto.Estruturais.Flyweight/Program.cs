using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dado externo
            int ext = 10;

            var fabrica = new FlyweightFactory();

            var f1 = fabrica.getFlyweight("A");
            f1.Operation(ext++);

            var f2 = fabrica.getFlyweight("B");
            f2.Operation(ext++);

            var f3 = fabrica.getFlyweight("C");
            f3.Operation(ext++);

            var f4 = new UnsharedConcreteFlyweight();
            f4.Operation(ext++);

            Console.Read();
        }
    }
}
