namespace NguyenTranQuangKhai_Tuan3.Services
{
    using Microsoft.AspNetCore.Identity.UI.Services;
    using System.Threading.Tasks;

    public class FakeEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Console.WriteLine($"[FakeEmailSender] To: {email} - Subject: {subject}");
            return Task.CompletedTask;
        }
    }
}