namespace PicturesShop.Models.PictureController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class EditPicture
    {
        [Required]
        [Range(1, Int64.MaxValue, ErrorMessage = "Id must be bigger than 0!")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [MinLength(2, ErrorMessage = "Title must be minimum 2 symbols!")]
        [MaxLength(30, ErrorMessage = "Title must be maximum 30 symbols!")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [MinLength(10, ErrorMessage = "Description must be minimum 10 symbols!")]
        [MaxLength(3000, ErrorMessage = "Description must be maximum 3000 symbols!")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Range(1, 300, ErrorMessage = "Price must be in range of 1 to 300!")]
        [Display(Name = "Price")]
        public double Price { get; set; }

        [DataType(DataType.ImageUrl, ErrorMessage = "Invalid image url!")]
        [Display(Name = "Image url")]
        public string ImgUrl { get; set; }
    }
}
