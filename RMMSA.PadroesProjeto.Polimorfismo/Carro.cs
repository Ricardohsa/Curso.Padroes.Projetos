
using System;

namespace RMMSA.PadroesProjeto.Polimorfismo
{
    public class Carro: MeioTransporte
    {
        public string sMarca { get; set; }

        public string sModelo { get; set; }

        public override void Mover()
        {
            base.Mover();
            Console.WriteLine(sMarca + " " + sModelo + " Andando");
        }
    }
}
