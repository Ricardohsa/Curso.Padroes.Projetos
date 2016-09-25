using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = ConexaoBD.Instance();
            conn.StringConexao = "Oracle";
            conn.Open();

            var conn2 = ConexaoBD.Instance();
            //conn2.StringConexao = "SQL SERVER";
            conn2.Open();

            Console.ReadLine();
        }
    }
}
