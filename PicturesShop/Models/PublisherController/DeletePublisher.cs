namespace PicturesShop.Models.PublisherController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class DeletePublisher
    {
        [Required]
        public int PublisherId { get; set; }
    }
}
