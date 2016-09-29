using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Comportamentais.ChainResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var valFrom = new Form();
            var valServer = new Server();
            var valBD = new DB();
            valFrom.setSucessor(valServer);
            valServer.setSucessor(valBD);

            valFrom.ValidateUser("teste", "teste");
            Console.ReadLine();
        }
    }
}
