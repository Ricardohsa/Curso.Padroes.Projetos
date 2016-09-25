using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Singleton
{
    public class ConexaoBD
    {
        //guarda internamente a instance
        private static ConexaoBD _instance;

        protected ConexaoBD()
        {
        }

        public static ConexaoBD Instance()
        {
            if (_instance == null)
                _instance = new ConexaoBD();

            return _instance; 
        }

        public string  StringConexao { get; set; }

        public void Open()
        {
            Console.WriteLine("Abrindo conexão com Banco de Dados...." + StringConexao);
        }


    }
}
