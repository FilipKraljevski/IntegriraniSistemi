using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain.Domain;
using TicketShop.Domain.DTO;

namespace TicketShop.Service.Interface
{
    public interface ITicketService
    {
        List<Ticket> GetAllTickets();
        List<Ticket> GetTicketsByGenre(String genre);

        List<Ticket> GetTicketsByValidDateAfter(DateTime validDate);
        Ticket GetDetailsForTicket(Guid? id);
        void CreateNewTicket(Ticket p);
        void UpdeteExistingTicket(Ticket p);
        AddToCartDto GetCartInfo(Guid? id);
        void DeleteTicket(Guid id);
        bool AddToCart(AddToCartDto item, string userID);
    }
}
