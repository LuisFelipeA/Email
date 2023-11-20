using Email;

class Program
{
    static void Main()
    {
        Console.Write("Digite o email: ");
        string email = Console.ReadLine();

        Console.Write("Digite o assunto: ");
        string assunto = Console.ReadLine();

        Console.Write("Digite o corpo do e-mail: ");
        string conteudo = Console.ReadLine();

        var emailBuilder = new EmailBuilder()
            .To(email)
            .Subject(assunto)
            .Body(conteudo);

        // Criando uma instância do serviço de e-mail original
        var originalEmailService = new EmailService();

        // Criando uma instância do serviço de e-mail decorado
        var decoratedEmailService = new EmailServiceDecorator(originalEmailService);

        // Enviando o e-mail usando o serviço de e-mail decorado
        decoratedEmailService.SendEmail(emailBuilder);
    }
}