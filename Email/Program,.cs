using System;

// Classe que representa um email
class Email
{
    public string Remetente { get; set; }
    public string Destinatario { get; set; }
    public string Assunto { get; set; }

    // Método para exibir as informações do email
    public virtual void Exibir()
    {
        Console.WriteLine($"Remetente: {Remetente}, Destinatario: {Destinatario}, Assunto: {Assunto}");
    }
}

// Padrão Builder para construir objetos Email
class ConstrutorEmail
{
    private Email email = new Email();

    // Método para definir o remetente do email
    public ConstrutorEmail DeRemetente(string remetente)
    {
        email.Remetente = remetente;
        return this;
    }

    // Método para definir o destinatário do email
    public ConstrutorEmail ParaDestinatario(string destinatario)
    {
        email.Destinatario = destinatario;
        return this;
    }

    // Método para definir o assunto do email
    public ConstrutorEmail ComAssunto(string assunto)
    {
        email.Assunto = assunto;
        return this;
    }

    // Método para construir o objeto Email
    public Email Construir() => email;
}

// Padrão Decorator para adicionar funcionalidades extras aos objetos Email
abstract class DecoradorEmail : Email
{
    protected Email EmailDecorado;

    public DecoradorEmail(Email email)
    {
        EmailDecorado = email;
    }

    // Sobrescreve o método Exibir para adicionar funcionalidades extras
    public override void Exibir()
    {
        EmailDecorado.Exibir();
    }
}

// Exemplo de um Decorator que adiciona um anexo ao Email
class DecoradorAnexo : DecoradorEmail
{
    public DecoradorAnexo(Email email) : base(email) { }

    // Sobrescreve o método Exibir para adicionar a informação de anexo
    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine("Anexo: Arquivo.txt");
    }
}

// Exemplo de um Decorator que adiciona uma assinatura ao Email
class DecoradorAssinatura : DecoradorEmail
{
    public DecoradorAssinatura(Email email) : base(email) { }

    // Sobrescreve o método Exibir para adicionar a informação de assinatura
    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine("Assinatura Digital");
    }
}

// Padrão Adapter para adaptar a interface do Email para a interface de envio
interface IAdaptadorEnvioEmail
{
    void Enviar();
}

// Implementação do Adapter para enviar o Email
class AdaptadorEnvioEmail : IAdaptadorEnvioEmail
{
    private Email Email;

    public AdaptadorEnvioEmail(Email email)
    {
        Email = email;
    }

    // Método para enviar o Email
    public void Enviar()
    {
        Console.WriteLine($"Enviando email de {Email.Remetente} para {Email.Destinatario} com assunto: {Email.Assunto}");
    }
}

class Programa
{
    static void Main()
    {
        // Usando o padrão Builder para construir um objeto Email
        var construtorEmail = new ConstrutorEmail();
        var email = construtorEmail.DeRemetente("remetente@email.com")
                                   .ParaDestinatario("destinatario@email.com")
                                   .ComAssunto("Saudações")
                                   .Construir();

        // Usando o padrão Decorator para adicionar funcionalidades extras ao Email
        var emailComAnexo = new DecoradorAnexo(email);
        var emailComAssinatura = new DecoradorAssinatura(emailComAnexo);

        Console.WriteLine("Email com Anexo e Assinatura:");
        emailComAssinatura.Exibir();

        // Usando o padrão Adapter para enviar o Email
        var adaptadorEnvioEmail = new AdaptadorEnvioEmail(email);
        Console.WriteLine("\nUsando o Adaptador para enviar o email:");
        adaptadorEnvioEmail.Enviar();
    }
}

