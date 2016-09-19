using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro1 = new Carro()
            {
                sMarca = "GM",
                sModelo = "Astra"
            };

            carro1.Mover();

            var aviao1 = new Aviao()
            {
                sModelo = "Foker 100",
                sFabricante = "Embraer"
            };

            aviao1.Mover();

            Console.ReadLine();
        }
    }
}
