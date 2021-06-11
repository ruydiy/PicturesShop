namespace PicturesShop.Services.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.OrderController;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface IOrderService
    {
        public bool CreateOrder(CreateOrder order, string userEmail);
        public bool ChangeStatus(ChangeStatus changeStatus);
        public List<Order> GetOrdersByUser(string email);
        public Order GetOrderById(string email, int id);
        public List<Order> GetOrdersByStatus(string status);
        public Order GetOrderByIdAdmin(int Id);
    }
}
