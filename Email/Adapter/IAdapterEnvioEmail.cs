using EnvioDeEmail.Builder;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;


namespace EnvioDeEmail.Adapter
{
    // Padrão Adapter para adaptar a interface do Email para a interface de envio
    interface IAdapterEnvioEmail
    {
        void Enviar(Email email, MimeMessage message);
    }
}
