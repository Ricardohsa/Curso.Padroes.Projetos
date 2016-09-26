using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMMSA.PadoresProjeto.Estruturais.Decoretor;

namespace RMMSA.PadoresProjeto.Estruturais.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria o componente concreto
            var ds = new DataSet();

            //cria o Decorator
            var d = new DataSetConcreteDecorator();

            //setando objeto a ser decorado (injetando implementação)
            d.setDatasetbase(ds);
            
            //chamando método da abstração
            d.Write();
            d.WriteXML();

            Console.Read();
        }
    }
}
