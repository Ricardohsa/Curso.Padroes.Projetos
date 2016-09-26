using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Facade
{
    public class MailMessage
    {
        private string _message;
        private MailFormat _format;

        public string Message
        { get { return _message; }
          set { _message = value; }
        }

        public MailMessage(string message, MailFormat format)
        {
            _message = message;
            _format = format;
        }
    }
}
