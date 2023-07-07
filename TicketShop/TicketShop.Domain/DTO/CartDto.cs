using System.Collections.Generic;
using TicketShop.Domain.Relations;

namespace TicketShop.Domain.DTO
{
    public class CartDto
    {
        public List<TicketInCart> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
