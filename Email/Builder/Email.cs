namespace EnvioDeEmail.Builder
{
    // Classe que representa um email
    class Email
    {
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }

        // Método para exibir as informações do email
        public virtual void Exibir()
        {
            Console.WriteLine($"Remetente: {Remetente}, Destinatario: {Destinatario}, Assunto: {Assunto}");
        }
    }
}
