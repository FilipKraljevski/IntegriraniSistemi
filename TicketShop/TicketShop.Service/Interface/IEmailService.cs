using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TicketShop.Domain.Domain;

namespace TicketShop.Service.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
