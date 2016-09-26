using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Estruturais.Decoretor
{
    public class DataSet: BaseDataSet
    {
        public override void Write()
        {
            Console.WriteLine("O Metódo DataSet.Write() invocado....");
        }
    }
}
