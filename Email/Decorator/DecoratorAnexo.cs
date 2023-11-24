using EnvioDeEmail.Builder;
using MimeKit;
using System.IO;
using System.Text;

namespace EnvioDeEmail.Decorator
{
    //Aqui temos o Concrete Decorator que adiciona o anexo ao email.
    class DecoratorAnexo : DecoratorEmail
    {
        private readonly Multipart multipart;
        public DecoratorAnexo(Email email, Multipart multipart) : base(email) 
        {
            this.multipart = multipart;
        }

        
        //O Método Exibir é sobrescrito para adicionar a informação de anexo.
        public override void Exibir()
        {
            base.Exibir();
            var attachment = new MimePart("application", "octet-stream")
            {
                //Aqui é definido o tipo de anexo e o local do arquivo a ser anexado (neste caso o local foi hardcoded para fins de desenvilvimento e teste.
                Content = new MimeContent(new MemoryStream(Encoding.UTF8.GetBytes("Conteúdo do Anexo"))),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(@"../Read_me.txt")
            };
            //E então o anexo é adicionado ao email.
            multipart.Add(attachment);

        }
    }
}
