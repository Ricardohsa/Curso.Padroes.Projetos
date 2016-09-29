using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Comportamentais.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria Concrete Aggregate
            var equipe = new Equipe();
            equipe[0] = "Ricardo";
            equipe[1] = "Miguel";
            equipe[2] = "Michellle";
            equipe[3] = "Sá";

            //Cria Iterator
            ConcreteIterator i = new ConcreteIterator(equipe);

            //iterar pela coleção
            Console.WriteLine("Listando membros da equipe:");
            object item = i.First();


            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadLine();

        }
    }
}
