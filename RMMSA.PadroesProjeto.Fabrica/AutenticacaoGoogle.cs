using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Fabrica
{
    //Produto COncreto
    public class AutenticacaoGoogle : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Google");
        }
    }
}
