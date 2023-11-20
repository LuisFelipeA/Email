using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    // Padrão Builder para construir objetos Email
    class BuilderEmail
    {
        private Email email = new Email();

        // Método para definir o remetente do email
        public BuilderEmail DeRemetente(string remetente)
        {
            email.Remetente = remetente;
            return this;
        }

        // Método para definir o destinatário do email
        public BuilderEmail ParaDestinatario(string destinatario)
        {
            email.Destinatario = destinatario;
            return this;
        }

        // Método para definir o assunto do email
        public BuilderEmail ComAssunto(string assunto)
        {
            email.Assunto = assunto;
            return this;
        }

        // Método para construir o objeto Email
        public Email Construir() => email;
    }
}
