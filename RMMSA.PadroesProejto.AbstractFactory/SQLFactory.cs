using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    //Fabrica Concreta
    public class SQLFactory : DBFactory
    {
        public override DBCommand createCommand()
        {
            return new SQLCommand();
        }

        public override DBConnection createDBConnection()
        {
            return new SQLConnection();
        }
    }
}
