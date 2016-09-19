using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Polimorfismo
{
    public class MeioTransporte
    {
        public string Modelo { get; set; }

        public virtual void Mover()
        {
            Console.WriteLine("Ligando");
        }
        
    }
}
