using Microsoft.AspNetCore.Identity;
using TicketShop.Domain.Domain;

namespace TicketShop.Domain.Identity
{
    public class TicketShopApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Cart UserCart { get; set; }
    }
}
