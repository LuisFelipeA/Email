using EnvioDeEmail.Adapter;
using EnvioDeEmail.Builder;
using EnvioDeEmail.Decorator;
using Org.BouncyCastle.Bcpg;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

//Esta é uma aplicação de console que realiza o envio de e-mails com o MailKit e através de um SMTP Client, o Ethereal.
//Implementando os padrões Builder, Decorator e Adapter.


//O Program.cs é o código principal da aplicação e o primeiro a "rodar".

// Aqui temos alguns inserts de terminal para que o usuário possa inserir as informações para o envio do email e seus conteúdos.
Console.Write("Digite o nome do remetente: ");
string nomeRemetente = Console.ReadLine(); // "Remetente Fulano"
Console.WriteLine();

Console.Write("Digite o e-mail do remetente: ");
string rementete = Console.ReadLine(); // "remetente@email.com"
Console.WriteLine();

Console.Write("Digite o e-mail do destinatario: ");
string destinatario = Console.ReadLine(); // "destinatario@email.com"
Console.WriteLine();

Console.Write("Digite o assunto: ");
string assunto = Console.ReadLine(); // "Saudações"
Console.WriteLine();

Console.Write("Digite o corpo da mensagem: ");
string corpo = Console.ReadLine(); // "Olá vou te ligar mais tarde"
Console.WriteLine();


Console.Write("Adicionar anexo? 1-Sim/2-Não ");
int anexo = int.Parse(Console.ReadLine()); // "Foto.png"
Console.WriteLine();


//Após coletadas as informações elas são passadas ao Builder responsável por montar o objeto da classe Email.
var BuilderEmail = new BuilderEmail();
var email = BuilderEmail.DeRemetente(nomeRemetente, rementete)
                           .ParaDestinatario(destinatario)
                           .ComAssunto(assunto)
                           .ComCorpo(corpo)
                           .Construir();

//Aqui utilizamos o objeto construído pelo builder para definir os atributos da mensagem a ser enviada através do MailKit.
MimeMessage message = new MimeMessage();
message.From.Add(new MailboxAddress(email.nomeRemetente, email.Remetente));
message.To.Add(MailboxAddress.Parse(destinatario));
message.Subject = email.Assunto;
message.Body = new TextPart("plain")
{
    Text = email.Corpo
};



//Aqui utilizamos uma pequena validação lógica para a adição de um anexo ao email por meio do padrão Decorator.
if (anexo == 1) 
{
    var multipart = new Multipart("mixed");
    multipart.Add(message.Body);

    var emailComAnexo = new DecoratorAnexo(email, multipart);

    message.Body = multipart;
}
else
{
    //caso o usuário opte por não adicionar um anexo a aplicação prossegue com o objeto de email inalterado
    //pelo decorator de anexos, e executa a função da Classe Email exibir() que exibe os dados do email sendo enviado.
    email.Exibir();
}

// Usando o padrão Adapter para enviar o Email
//E então o padrão Adapter é utilizado no envio do email.
var AdapterEnvioEmail = new AdapterEnvioEmail(email);
Console.WriteLine("\nUsando o Adapter para enviar o email:");
AdapterEnvioEmail.Enviar(email, message);

