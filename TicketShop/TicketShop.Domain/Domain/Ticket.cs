using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TicketShop.Domain.Relations;

namespace TicketShop.Domain.Domain
{
    public class Ticket : BaseEntity
    {
        [Required]
        public string MovieName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ValidDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public double Price { get; set; }

        public virtual ICollection<TicketInCart> TicketInCarts { get; set; }
        public virtual ICollection<TicketInOrder> TicketInOrders { get; set; }
    }
}
