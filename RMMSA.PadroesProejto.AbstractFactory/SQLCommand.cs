using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    public class SQLCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Executando o comando foi chamado");
        }
    }
}
