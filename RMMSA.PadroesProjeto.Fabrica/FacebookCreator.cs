

using System;

namespace RMMSA.PadroesProjeto.Fabrica
{
    //Concrete Creator
    public class FacebookCreator : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoFaceBook();
        }
    }
}
