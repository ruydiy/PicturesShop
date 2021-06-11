namespace PicturesShop.Models.AdminController
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderAndUserInfo
    {

        public Order Order { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
