using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Estruturais.Decoretor
{
    public class DataSetDecorator: BaseDataSet
    {
        protected BaseDataSet _datasetBase;

        public void setDatasetbase(BaseDataSet datasetBase)
        {
            _datasetBase = datasetBase;
        }
        
        public override void Write()
        {
            Console.WriteLine("Método DataSetConcreteDecorator.Write() invocado");
            _datasetBase.Write();
        }
    }
}
