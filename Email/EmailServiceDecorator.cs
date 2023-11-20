namespace Email
{
    public class EmailServiceDecorator : IEmailService
    {
        private readonly IEmailService _emailService;

        public EmailServiceDecorator(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void SendEmail(EmailBuilder emailBuilder)
        {
            // Lógica adicional antes de chamar o método original
            Console.WriteLine("Realizando alguma lógica adicional antes de enviar o e-mail...");

            // Chamar o método original
            _emailService.SendEmail(emailBuilder);

            // Lógica adicional após chamar o método original
            Console.WriteLine("Realizando alguma lógica adicional após o envio do e-mail...");
        }
    }
}
