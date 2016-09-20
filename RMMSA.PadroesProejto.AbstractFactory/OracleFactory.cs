using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    public class OracleFactory : DBFactory
    {
        public override DBCommand createCommand()
        {
           return new OracleCommand();
        }

        public override DBConnection createDBConnection()
        {
            return new OracleConnection();
        }
    }
}
