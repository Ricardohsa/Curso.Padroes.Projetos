using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();

            foreach(Creator c in creators)
            {
                Autenticacao aut = c.CreateInstance();
                aut.Autenticar();
            }

            Creator face;
            face = new FacebookCreator();
            Autenticacao autentica =  face.CreateInstance();

            autentica.Autenticar();

            Console.ReadLine();
        }
    }
}
