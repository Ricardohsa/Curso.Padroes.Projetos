using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Comportamentais.Command
{
    //ConcreteCommand
    public class ServerCommand: Command
    {
        private Server _server;

        public ServerCommand(Server srv)
        {
            _server = srv;
        }

        public override void Execute()
        {
            Console.WriteLine("ServerCommand - ConcreteCommand: Validando Usuário.....");
            _server.ValidadeUser();
        }
    }
}
