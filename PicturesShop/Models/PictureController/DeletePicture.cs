namespace PicturesShop.Models.PictureController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class DeletePicture
    {
        [Required]
        public int PictureId { get; set; }
    }
}
