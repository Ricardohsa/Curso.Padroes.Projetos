using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjetos.Hernanca
{
    public class Aluno : Pessoa
    {
        public int iMatricula { get; set; }

        public void Estudar()
        {
            Console.WriteLine(sNome + " Estudando ");
        }
    }
}
