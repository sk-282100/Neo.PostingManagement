using PostingManagement.Application.Models.Mail;
using System.Threading.Tasks;

namespace PostingManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
