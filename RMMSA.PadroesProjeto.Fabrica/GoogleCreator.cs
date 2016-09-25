
using System;

namespace RMMSA.PadroesProjeto.Fabrica
{
    //Concreto Creator
    public class GoogleCreator : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoGoogle();
        }
    }
}
