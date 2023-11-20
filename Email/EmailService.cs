namespace Email
{
    public class EmailService : IEmailService
    {
        public void SendEmail(EmailBuilder emailBuilder)
        {
            Email email = emailBuilder.Build();
            // Lógica para enviar o e-mail (pode ser simulada aqui)
            Console.WriteLine($"Enviando e-mail para: {email.To}, Assunto: {email.Subject}, Corpo: {email.Body}");
        }
    }
}
