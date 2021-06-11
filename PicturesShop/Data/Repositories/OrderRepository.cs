namespace PicturesShop.Data.Repositories
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Models;
    using PicturesShop.Models.OrderController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        public OrderRepository()
        {
            context = new ApplicationDbContext();
        }
        public bool ChangeStatus(ChangeStatus changeStatus)
        {
            throw new NotImplementedException();
        }

        public bool CreateOrder(CreateOrder order, string userEmail)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(string email, int Id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByIdAdmin(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}
