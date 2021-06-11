namespace PicturesShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        public string PublisherName { get; set; }

        public ICollection<Picture> Pictures { get; set; }
    }
}
