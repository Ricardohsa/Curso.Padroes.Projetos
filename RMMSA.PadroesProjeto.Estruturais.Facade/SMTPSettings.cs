using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Facade
{
    public class SMTPSettings
    {
        private string _servername;
        public string Servername
        {
            get { return _servername; }
            set { _servername = value; }
        }

        private string _username;
        public string Username
        { get { return _username; }
          set { _username = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
            
        }
    }
}
