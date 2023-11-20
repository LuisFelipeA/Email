using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
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
