
using System;

namespace RMMSA.PadroesProjeto.Estruturais.Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Método Request de Target chamado");
        }
    }
}
