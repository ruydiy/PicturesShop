namespace PicturesShop.Data.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.OrderController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface IOrderRepository
    {
        public bool CreateOrder(CreateOrder order, string userEmail);
        public bool ChangeStatus(ChangeStatus changeStatus);
        public List<Order> GetOrders();
        public List<Order> GetOrdersByUser(string email);
        public Order GetOrderById(string email, int Id);
        public List<Order> GetOrderByStatus(string status);

        public Order GetOrderByIdAdmin(int Id);
    }
}
