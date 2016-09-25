using System;
using System.Collections.Generic;

namespace RMMSA.PadroesProjeto.Builder
{
    public class Veiculo
    {
        private string _tipo;
        private Dictionary<string, string>  _parts = new Dictionary<string, string>();

        public Veiculo(string tipo)
        {
            _tipo = tipo;
        }

        //index
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Tipo: {0}", _tipo);
            Console.WriteLine("Motor: {0}", _parts["motor"]);
            Console.WriteLine("Pneus: {0}", _parts["pneus"]);

            Console.WriteLine("Portas: {0}", _parts["portas"]);
        }

    
    }
}
