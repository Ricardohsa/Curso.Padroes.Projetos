using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    public class SQLConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("O Método Open da SQLConnection foi chamado");
        }
    }
}
