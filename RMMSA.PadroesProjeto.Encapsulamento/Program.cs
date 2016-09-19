using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Carro();
           

            car1.Abastecer();
            car1.Ligar();
            car1.Mover();

            Console.ReadLine();


        }
    }
}
