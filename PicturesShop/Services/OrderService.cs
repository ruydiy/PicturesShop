namespace PicturesShop.Services
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Data.Repositories;
    using PicturesShop.Models;
    using PicturesShop.Models.OrderController;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderService : IOrderService
    {
        private IOrderRepository repository { get; set; }
        public OrderService()
        {
            repository = new OrderRepository();
        }

        public bool ChangeStatus(ChangeStatus changeStatus)
        {
            return repository.ChangeStatus(changeStatus);
        }

        public bool CreateOrder(CreateOrder order, string userEmail)
        {
            return repository.CreateOrder(order, userEmail);
        }

        public Order GetOrderById(string email, int id)
        {
            return repository.GetOrderById(email, id);
        }

        public Order GetOrderByIdAdmin(int Id)
        {
            return repository.GetOrderByIdAdmin(Id);
        }

        public List<Order> GetOrdersByStatus(string status)
        {
            return repository.GetOrderByStatus(status);
        }

        public List<Order> GetOrdersByUser(string email)
        {
            return repository.GetOrdersByUser(email);
        }
    }
}
