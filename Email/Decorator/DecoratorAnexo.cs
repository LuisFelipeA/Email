using EnvioDeEmail.Builder;

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
            Console.WriteLine("Anexo: Arquivo.txt");
        }
    }
}
