using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new Formulario("Cadastro Cliente");
            form.Add(new Button("Incluir"));
            form.Add(new Button("Consultar"));
            form.Add(new TextBox("Nome"));
            form.Add(new TextBox("Fone"));
            form.Display();

            Console.Read();
        }
    }
}
