using System.Threading.Tasks;

namespace shopapp.webui.EmailServices
{
    public interface IEmailSender
    {
        // smptp => gmail, hotmail
        // api   => sendgri

        Task SenEmailAsync(string email, string subject, string htmlMessage);
    }
}