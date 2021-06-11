namespace PicturesShop.Models.GenreController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class UpdateGenrePicture
    {
        [Required]
        public int GenreId { get; set; }

        [Required]
        public int PictureId { get; set; }
    }
}
