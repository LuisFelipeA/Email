using EnvioDeEmail.Adapter;
using EnvioDeEmail.Builder;
using EnvioDeEmail.Decorator;

// Usando o padrão Builder para construir um objeto Email
var BuilderEmail = new BuilderEmail();
var email = BuilderEmail.DeRemetente("remetente@email.com")
                           .ParaDestinatario("destinatario@email.com")
                           .ComAssunto("Saudações")
                           .Construir();

// Usando o padrão Decorator para adicionar funcionalidades extras ao Email
var emailComAnexo = new DecoratorAnexo(email);
var emailComAssinatura = new DecoratorAssinatura(emailComAnexo);

Console.WriteLine("Email com Anexo e Assinatura:");
emailComAssinatura.Exibir();

// Usando o padrão Adapter para enviar o Email
var AdapterEnvioEmail = new AdapterEnvioEmail(email);
Console.WriteLine("\nUsando o Adapter para enviar o email:");
AdapterEnvioEmail.Enviar();

