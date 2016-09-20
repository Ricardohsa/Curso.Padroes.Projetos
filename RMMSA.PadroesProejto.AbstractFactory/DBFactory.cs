using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    //Fábrica Abstrat
    public abstract class DBFactory
    {
        public abstract DBCommand createCommand();

        public abstract DBConnection createDBConnection();
        
    }
}
