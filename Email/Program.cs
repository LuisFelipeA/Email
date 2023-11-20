using EnvioDeEmail.Adapter;
using EnvioDeEmail.Builder;
using EnvioDeEmail.Decorator;
using Org.BouncyCastle.Bcpg;

Console.Write("Digite o remetente: ");
string rementete = Console.ReadLine(); // "remetente@email.com"
Console.WriteLine();

Console.Write("Digite o destinatario: ");
string destinatario = Console.ReadLine(); // "destinatario@email.com"
Console.WriteLine();

Console.Write("Digite o assunto: ");
string assunto = Console.ReadLine(); // "Saudações"
Console.WriteLine();

Console.Write("Adicionar anexo e assinatura digital? 1-Sim/2-Não ");
int anexo = int.Parse(Console.ReadLine()); // "Saudações"
Console.WriteLine();

// Usando o padrão Builder para construir um objeto Email
var BuilderEmail = new BuilderEmail();
var email = BuilderEmail.DeRemetente(rementete)
                           .ParaDestinatario(destinatario)
                           .ComAssunto(assunto)
                           .Construir();

// Usando o padrão Decorator para adicionar funcionalidades extras ao Email


if (anexo == 1) 
{
    var emailComAnexo = new DecoratorAnexo(email);
    var emailComAssinatura = new DecoratorAssinatura(emailComAnexo);
    Console.WriteLine("Email com Anexo e Assinatura:");
    emailComAssinatura.Exibir();
}
else
{
    email.Exibir();
}

// Usando o padrão Adapter para enviar o Email
var AdapterEnvioEmail = new AdapterEnvioEmail(email);
Console.WriteLine("\nUsando o Adapter para enviar o email:");
AdapterEnvioEmail.Enviar();

