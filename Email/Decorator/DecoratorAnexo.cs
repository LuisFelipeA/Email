using EnvioDeEmail.Builder;
using MimeKit;
using System.Text;

namespace EnvioDeEmail.Decorator
{
    // Exemplo de um Decorator que adiciona um anexo ao Email
    class DecoratorAnexo : DecoratorEmail
    {
        public DecoratorAnexo(Email email) : base(email) { }

        // Sobrescreve o método Exibir para adicionar a informação de anexo
        public override void Exibir()
        {
            base.Exibir();
            var attachment = new MimePart("application", "octet-stream")
            {
                Content = new MimeContent(new MemoryStream(Encoding.UTF8.GetBytes("Conteúdo do Anexo"))),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = "nome-do-anexo.txt"
            };
            Console.WriteLine("Anexo: Arquivo.txt");

            var multipart = new Multipart("mixed");
            multipart.Add(Corpo);
            multipart.Add(attachment);
        }
    }
}
