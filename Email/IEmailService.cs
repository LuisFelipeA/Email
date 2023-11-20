namespace Email
{
    public interface IEmailService
    {
        void SendEmail(EmailBuilder emailBuilder);
    }
}
