using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Encapsulamento
{
    public class Motor
    {

    }

    public class Bateria
    {

    }

    public class Carro
    {
        private Motor _Motor;

        private Bateria _Bateria;

        public string sBateria { get; set; }

        public int iNumeroPeneus { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando o carro");
        }

        public void Mover()
        {
            Console.WriteLine("Carro em movimento...");
        }

        public void Abastecer()
        {
            Console.WriteLine("Carro sendo abastecido");
        }
    }
}
