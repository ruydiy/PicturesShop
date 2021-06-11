namespace PicturesShop.Models.OrderController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class ChangeStatus
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
