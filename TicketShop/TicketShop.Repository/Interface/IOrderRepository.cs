using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain;
using TicketShop.Domain.Domain;

namespace TicketShop.Repository.Interface
{
    public interface IOrderRepository
    {
        public List<Order> getAllOrders();
        public Order getOrderDetails(Guid id);
    }
}
