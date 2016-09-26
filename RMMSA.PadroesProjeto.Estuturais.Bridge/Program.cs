

using System;

namespace RMMSA.PadroesProjeto.Estuturais.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var exp = new ExportacaoEx();
            //Injetando o objeto de implementaão
            exp.Implementor = new ExportacaoPDF();
            exp.Exportar();

            Console.Read();
        }
    }
}
