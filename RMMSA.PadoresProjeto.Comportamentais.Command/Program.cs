using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Comportamentais.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configura Receiver
            Server server = new Server();
            //Cria comando configurando o receiver
            Command cmd = new ServerCommand(server);

            //configura o Invoker
            Formulario frm =new Formulario();
            //configura e executa o camnado
            frm.setCommand(cmd);
            frm.ClickValidadte();

            Console.ReadLine();



        }
    }
}
