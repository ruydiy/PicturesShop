namespace PicturesShop.Models.OrderController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class CreateOrder
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        public string Notes { get; set; }

        [Required]
        public string PicturesAndQuantity { get; set; }

        public Dictionary<int, int> PicturesAndQuantityParsed { get; set; }
    }
}
