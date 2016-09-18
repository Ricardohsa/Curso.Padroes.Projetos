using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjetos.Hernanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno()
            {
                iMatricula = 454,
                sNome = "Miguel"
            };

            aluno1.Estudar();
            aluno1.Domir();

            Funcionario func1 = new Funcionario()
            {
                iMatricula = 12385,
                sNome = "João",
                sDepartamento = "Secretaria"
            };

            func1.Trabalhar();

            Console.ReadLine();


        }
    }
}
