using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Adapter
{
    //Cliente
    class Program
    {
        static void Main(string[] args)
        {
            var target = new Adapter();
            target.Request();
            
            Console.Read();
        }
    }
}
