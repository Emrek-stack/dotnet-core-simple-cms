using System.Threading.Tasks;

namespace SimpleCms.Api.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
