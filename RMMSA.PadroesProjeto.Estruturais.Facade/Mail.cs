using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Facade
{
    public class Mail
    {
        private SMTPSettings _smtpSettings;

        public Mail(SMTPSettings settings)
        {
            _smtpSettings = settings;
        }

        public void Send(MailMessage message, MailFormat format)
        {
            Console.WriteLine("Enviando mensagem.....");
            Console.WriteLine(message.Message);
        }
    }
}
