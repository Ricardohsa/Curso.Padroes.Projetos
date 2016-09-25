using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var director = new Director();

            builder = new CarroBuilder();
            director.Construct(builder);
            builder.veiculo.Mostrar();

            //Cria roduto


            //Cria Moto
            builder = new MotoBuilder();
            director.Construct(builder);
            builder.veiculo.Mostrar();

            Console.ReadLine();
        }
    }
}
