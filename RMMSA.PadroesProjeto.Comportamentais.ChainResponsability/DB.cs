using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Comportamentais.ChainResponsability
{
    public class DB:IValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            var ret = name == password;
            Console.WriteLine("Validação feita em DB: " + ret);
            //encadeia chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);
            return ret;
        }
    }
}
