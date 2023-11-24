namespace EnvioDeEmail.Builder
{
    //Classe que representa um email.
    class Email
    {
        public string nomeRemetente { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }

        //Método para exibir ao usuário no terminal as informações do email enviado.
        public virtual void Exibir()
        {
            Console.WriteLine($"Remetente: {Remetente}, Destinatario: {Destinatario}, Assunto: {Assunto}");
        }
    }
}
