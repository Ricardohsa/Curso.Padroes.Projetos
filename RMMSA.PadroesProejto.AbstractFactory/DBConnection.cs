using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    //Produto Abstrato (Abstract Product)
    public abstract class DBConnection
    {
        public abstract void Open();
    }
}
