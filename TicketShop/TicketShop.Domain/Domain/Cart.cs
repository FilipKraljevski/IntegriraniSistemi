using System;
using System.Collections.Generic;
using TicketShop.Domain.Identity;
using TicketShop.Domain.Relations;

namespace TicketShop.Domain.Domain
{
    public class Cart : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual TicketShopApplicationUser Owner { get; set; }

        public virtual ICollection<TicketInCart> TicketInCarts { get; set; }
    }
}
