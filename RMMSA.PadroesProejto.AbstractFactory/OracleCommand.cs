using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    public class OracleCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de OracleCommand foi chamado. ");
        }
    }
}
