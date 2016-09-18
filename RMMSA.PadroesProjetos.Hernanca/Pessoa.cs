using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjetos.Hernanca
{
    public class Pessoa
    {
        public string sNome { get; set; }
        
        public void Domir ()
        {
            Console.WriteLine(sNome + " dormir");
        }


    }
}
