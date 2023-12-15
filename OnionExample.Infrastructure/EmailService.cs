using OnionExample.Application.Interfaces.Services;

namespace OnionExample.Infrastructure
{
    public class EmailService : IEmailService
    {
        public bool SendMail(string to, string massage)
        {
            Console.WriteLine("Mail gönderildi");
            return true;
        }
    }
}
