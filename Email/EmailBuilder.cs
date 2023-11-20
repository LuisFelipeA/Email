namespace Email
{
    public class EmailBuilder
    {
        private string to;
        private string subject;
        private string body;

        public EmailBuilder To(string to)
        {
            this.to = to;
            return this;
        }

        public EmailBuilder Subject(string subject)
        {
            this.subject = subject;
            return this;
        }

        public EmailBuilder Body(string body)
        {
            this.body = body;
            return this;
        }

        public Email Build()
        {
            return new Email(to, subject, body);
        }
    }
}
