using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Comportamentais.Command
{
    //Invoker
    public class Formulario
    {
        private Command _command;

        public void setCommand(Command command)
        {
            _command = command;
        }

        public void ClickValidadte()
        {
            Console.WriteLine("Invoker: Validando Usuário.....");
            _command.Execute();
        }
    }
}
