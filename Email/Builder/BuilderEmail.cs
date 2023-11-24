namespace EnvioDeEmail.Builder
{
    // Padrão Builder para construir objetos Email através de métodos das baseados nas propriedades da classe Email.
    class BuilderEmail
    {
        private Email email = new Email();

        // Método para definir o remetente do email
        public BuilderEmail DeRemetente(string nomeRemetente, string remetente)
        {
            email.nomeRemetente = nomeRemetente;
            email.Remetente = remetente;
            return this;
        }

        // Método para definir o destinatário do email
        public BuilderEmail ParaDestinatario(string destinatario)
        {
            email.Destinatario = destinatario;
            return this;
        }

        // Método para definir o assunto do email
        public BuilderEmail ComAssunto(string assunto)
        {
            email.Assunto = assunto;
            return this;
        }

        public BuilderEmail ComCorpo(string corpo)
        {
            email.Corpo = corpo;
            return this;
        }

        // Método para construir o objeto Email
        public Email Construir() => email;
    }
}
