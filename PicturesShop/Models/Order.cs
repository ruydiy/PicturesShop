namespace PicturesShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string UserEmail { get; set; }

        public ICollection<PictureQuantity> PictureQuantities { get; set; }

        [Required]
        public string City { get; set; }

        public double Total { get; set; }
        public DateTime Date { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public string Notes { get; set; }
    }
}
