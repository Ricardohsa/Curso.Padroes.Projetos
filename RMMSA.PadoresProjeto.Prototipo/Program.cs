using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um objeto prototipo e clona
            Livro prod1 = new Livro( 1, "Cozinha Prática",  (double)45.66);
            Livro c1 = (Livro)prod1.Clone();
            Console.WriteLine(c1.Descricao);

            DVD prod2 = new DVD(1, "Musicas", (double)55);
            DVD c2 = (DVD)prod2.Clone();
            Console.WriteLine(c2.Descricao);

            Console.ReadLine();
        }
    }
}
