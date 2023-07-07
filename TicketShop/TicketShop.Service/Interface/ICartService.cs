using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain.DTO;

namespace TicketShop.Service.Interface
{
    public interface ICartService
    {
        CartDto getCartInfo(string userId);
        bool deleteTicketFromCart(string userId, Guid ticketId);
        bool order(string userId);
    }
}
