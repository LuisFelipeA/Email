using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    // Exemplo de um Decorator que adiciona uma assinatura ao Email
    class DecoratorAssinatura : DecoratorEmail
    {
        public DecoratorAssinatura(Email email) : base(email) { }

        // Sobrescreve o método Exibir para adicionar a informação de assinatura
        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine("Assinatura Digital");
        }
    }
}
