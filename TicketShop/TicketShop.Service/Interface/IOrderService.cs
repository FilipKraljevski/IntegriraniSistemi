using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain;
using TicketShop.Domain.Domain;

namespace TicketShop.Service.Interface
{
    public interface IOrderService
    {
        public List<Order> getAllOrders();
        public Order getOrderDetails(Guid id);

        public List<Order> getAllOrdersFromUser(String userId);
    }
}
