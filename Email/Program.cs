using EnvioDeEmail.Adapter;
using EnvioDeEmail.Builder;
using EnvioDeEmail.Decorator;
using Org.BouncyCastle.Bcpg;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;





Console.Write("Digite o nome do remetente: ");
string nomeRemetente = Console.ReadLine(); // "remetente@email.com"
Console.WriteLine();

Console.Write("Digite o remetente: ");
string rementete = Console.ReadLine(); // "remetente@email.com"
Console.WriteLine();

Console.Write("Digite o destinatario: ");
string destinatario = Console.ReadLine(); // "destinatario@email.com"
Console.WriteLine();

Console.Write("Digite o assunto: ");
string assunto = Console.ReadLine(); // "Saudações"
Console.WriteLine();

Console.Write("Digite o corpo da mensagem: ");
string corpo = Console.ReadLine(); // "Olá vou te ligar mais tarde"
Console.WriteLine();


Console.Write("Adicionar anexo? 1-Sim/2-Não ");
int anexo = int.Parse(Console.ReadLine()); // "Saudações"
Console.WriteLine();


// Usando o padrão Builder para construir um objeto Email
var BuilderEmail = new BuilderEmail();
var email = BuilderEmail.DeRemetente(nomeRemetente, rementete)
                           .ParaDestinatario(destinatario)
                           .ComAssunto(assunto)
                           .ComCorpo(corpo)
                           .Construir();

MimeMessage message = new MimeMessage();
message.From.Add(new MailboxAddress(email.nomeRemetente, email.Remetente));
message.To.Add(MailboxAddress.Parse(destinatario));
message.Subject = email.Assunto;
message.Body = new TextPart("plain")
{
    Text = email.Corpo
};



// Usando o padrão Decorator para adicionar funcionalidades extras ao Email


if (anexo == 1) 
{
    var emailComAnexo = new DecoratorAnexo(email);
}
else
{
    email.Exibir();
}

// Usando o padrão Adapter para enviar o Email
var AdapterEnvioEmail = new AdapterEnvioEmail(email);
Console.WriteLine("\nUsando o Adapter para enviar o email:");
AdapterEnvioEmail.Enviar(email, message);

