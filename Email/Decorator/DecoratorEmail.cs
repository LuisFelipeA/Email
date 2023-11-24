using EnvioDeEmail.Builder;


namespace EnvioDeEmail.Decorator
{
    //O Padrão Decorator para adicionar funcionalidades extras aos objetos Email
    abstract class DecoratorEmail : Email
    {
        protected Email EmailDecorado;

        public DecoratorEmail(Email email)
        {
            EmailDecorado = email;
        }

        //Override do método Exibir para adicionar funcionalidades extras
        public override void Exibir()
        {
            EmailDecorado.Exibir();
        }
    }
}
