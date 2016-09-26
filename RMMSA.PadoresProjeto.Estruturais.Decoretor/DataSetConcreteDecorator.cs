using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Estruturais.Decoretor
{
    public class DataSetConcreteDecorator: DataSetDecorator
    {
        public override void Write()
        {
            Console.WriteLine("Método DataSetConcreteDecorator.Write() invocado");
            _datasetBase.Write();
        }

        public void WriteXML()
        {
            Console.WriteLine("Método DataSetConcreteDecorator.Write() invocado");
        }
    }
}
