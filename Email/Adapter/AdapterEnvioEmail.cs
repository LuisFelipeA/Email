using EnvioDeEmail.Adapter;
using EnvioDeEmail.Builder;

namespace EnvioDeEmail.Adapter
{
    // Implementação do Adapter para enviar o Email
    class AdapterEnvioEmail : IAdapterEnvioEmail
    {
        private Builder.Email Email;

        public AdapterEnvioEmail(Builder.Email email)
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
