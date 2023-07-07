using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain;
using TicketShop.Domain.Domain;
using TicketShop.Repository.Interface;
using TicketShop.Service.Interface;

namespace TicketShop.Service.Implenetation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;

        public OrderService(IOrderRepository orderRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }
        public List<Order> getAllOrders()
        {
            return this._orderRepository.getAllOrders();
        }

        public List<Order> getAllOrdersFromUser(string userId)
        {
            if(userId != null)
            {
                //var loggedInUser = this._userRepository.Get(userId);
                List<Order> orders = _orderRepository.getAllOrders();
                return orders.FindAll(o => o.UserId == userId);
            }
            return null;
        }

        public Order getOrderDetails(Guid id)
        {
            return this._orderRepository.getOrderDetails(id);
        }
    }
}
