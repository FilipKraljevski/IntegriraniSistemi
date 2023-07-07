using System.Collections.Generic;
using TicketShop.Domain.Identity;
using TicketShop.Domain.Relations;

namespace TicketShop.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public TicketShopApplicationUser User { get; set; }

        public virtual ICollection<TicketInOrder> TicketInOrders { get; set; }
    }
}
