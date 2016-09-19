using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Polimorfismo
{
    public class Aviao
    {
        public string sModelo { get; set; }

        public string sFabricante { get; set; }

        public void Mover()
        {
            Console.WriteLine(sModelo + " voando");
        }
    }
}
