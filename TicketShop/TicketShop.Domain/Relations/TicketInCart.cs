using System;
using TicketShop.Domain.Domain;

namespace TicketShop.Domain.Relations
{
    public class TicketInCart : BaseEntity
    {
        public Guid TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
        public Guid CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public int Quantity { get; set; }

    }
}
