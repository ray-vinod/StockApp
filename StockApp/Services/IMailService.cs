using StockApp.Models;
using System.Threading.Tasks;

namespace StockApp.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
