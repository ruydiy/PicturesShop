namespace PicturesShop.Models.PainterController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class AddPainter
    {
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
    }
}
