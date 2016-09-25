using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Fabrica
{
    public class AutenticacaoFaceBook : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Facebook");
        }
    }
}
