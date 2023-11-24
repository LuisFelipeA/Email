using EnvioDeEmail.Adapter;
using EnvioDeEmail.Builder;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;

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
        public void Enviar(Email email, MimeMessage message)


        {
            Console.Write("Digite sua senha para enviar o email:");
            string senha = Console.ReadLine(); // "******"
            Console.WriteLine();

            SmtpClient client= new SmtpClient();

            try
            {
                client.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
                client.Authenticate(email.Remetente, senha);
                client.Send(message);

                Console.WriteLine("Email Enviado!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
            Console.ReadLine();
            
        }
    }
}
