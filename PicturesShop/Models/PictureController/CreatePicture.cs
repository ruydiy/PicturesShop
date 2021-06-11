﻿namespace PicturesShop.Models.PictureController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class CreatePicture
    {
        [Required]
        [MinLength(2, ErrorMessage = "Title must be minimum 2 symbols!")]
        [MaxLength(30, ErrorMessage = "Title must be maximum 30 symbols!")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Description must be minimum 10 symbols!")]
        [MaxLength(3000, ErrorMessage = "Description must be maximum 3000 symbols!")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Range(1, 300, ErrorMessage = "Price must be in range of 1 to 300!")]
        [Display(Name = "Price")]
        public double Price { get; set; }

        [Required]
        [DataType(DataType.ImageUrl, ErrorMessage = "Invalid image url!")]
        [Display(Name = "Image url")]
        public string ImgUrl { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Parts must be in range of 1 to 10!")]
        [Display(Name = "Parts")]
        public int Parts { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Painter first name must be minimum 2 symbols!")]
        [MaxLength(25, ErrorMessage = "Painter first name must be maximum 25 symbols!")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Painter last name must be minimum 2 symbols!")]
        [MaxLength(25, ErrorMessage = "Painter last name must be maximum 25 symbols!")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date is invalid!")]
        [Display(Name = "Published on")]
        public DateTime PublishedOn { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Publisher name must be minimum 2 symbols!")]
        [MaxLength(30, ErrorMessage = "Publisher name must be maximum 30 symbols!")]
        [Display(Name = "Publisher name")]
        public string PublisherName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Genre name must be minimum 2 symbols!")]
        [MaxLength(30, ErrorMessage = "Genre name must be maximum 30 symbols!")]
        [Display(Name = "Genre name")]
        public string GenreName { get; set; }
    }
}
