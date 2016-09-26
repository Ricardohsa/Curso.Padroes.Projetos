using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailFacede();
            email.Enviar("Ola Mundo");

            Console.Read();
        }
    }
}
