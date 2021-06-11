namespace PicturesShop.Models.PublisherController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;


    public class UpdatePublisherPicture
    {
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Publisher Id must be bigger than 0!")]
        public int PublisherId { get; set; }

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Picture Id must be bigger than 0!")]
        public int PictureId { get; set; }

        [Required]
        public string Operation { get; set; }
    }
}
