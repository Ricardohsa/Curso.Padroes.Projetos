using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Flyweight
{
    public abstract class Flyweight
    {
        //Dados que não podem ser compartilhados entre as instancias
        public abstract void Operation(int ext);
    }
}
