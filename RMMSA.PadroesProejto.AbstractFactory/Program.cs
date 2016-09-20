using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProejto.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            DBFactory db = new OracleFactory();

            var con = db.createDBConnection();
            con.Open();

            var cmd = db.createCommand();
            cmd.Execute();


            //var con = new SQLConnection();
            //con.Open();

            //var cmd = new SQLCommand();
            //cmd.Execute();
            Console.ReadLine();
        }
    }
}
