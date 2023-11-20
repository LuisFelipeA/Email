using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    // Implementação do Adapter para enviar o Email
    class AdapterEnvioEmail : IAdapterEnvioEmail
    {
        private Email Email;

        public AdapterEnvioEmail(Email email)
        {
            Email = email;
        }

        // Método para enviar o Email
        public void Enviar()
        {
            Console.WriteLine($"Enviando email de {Email.Remetente} para {Email.Destinatario} com assunto: {Email.Assunto}");
        }
    }
}
