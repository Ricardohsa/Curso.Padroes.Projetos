using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Facade
{
    public class EmailFacede
    {
        private readonly Mail _mail;
        private MailFormat _mailFormat;
        private SMTPSettings _smtpSettings;

        private MailMessage _mailMessage;

        public EmailFacede()
        {
            _mail = new Mail(_smtpSettings);
            _mailFormat = new MailFormatHTML();
            _smtpSettings = new SMTPSettings()
            {
                Username = "r.humberto.sa",
                Password = "123",
                Servername = "smtp.gmail.com"
            };

            _mailMessage = new MailMessage("", _mailFormat);

        }

        public void Enviar(string Mensagem)
        {
            _mailMessage = new MailMessage("", _mailFormat);
            _mail.Send(_mailMessage, _mailFormat);
        }
    }
}
