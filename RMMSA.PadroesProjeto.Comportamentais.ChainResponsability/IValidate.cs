using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Comportamentais.ChainResponsability
{
    public abstract class IValidate
    {
        protected IValidate _sucessor;

        public void setSucessor(IValidate sucessor)
        {
            _sucessor = sucessor;
        }

        public abstract bool ValidateUser(string name, string password);

    }
}
