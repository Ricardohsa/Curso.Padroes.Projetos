using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Abstracao
{
    public class NoteBook
    {
        public string sNOME { get; set; }

        private string _nome
        {
            get { return sNOME; }
        }

        public NoteBook()
        {
            
        }

        
    }
}
