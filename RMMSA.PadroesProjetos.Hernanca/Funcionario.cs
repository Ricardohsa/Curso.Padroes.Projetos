using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjetos.Hernanca
{
    public class Funcionario : Pessoa
    {
        public int iMatricula { get; set; }

        public string sDepartamento { get; set; }

        public void Trabalhar()
        {
            Console.WriteLine(sNome + " Trabalhando no Departamento:  "  + sDepartamento);
        }
    }
}
