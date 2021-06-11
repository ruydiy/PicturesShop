using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturesShop.Models.PainterController
{
    public class UpdatePainterPicture
    {
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Painter Id must be bigger than 0!")]
        [Display(Name = "Painter Id")]
        public int PainterId { get; set; }
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Picture Id must be bigger than 0!")]
        [Display(Name = "Picture Id")]
        public int PictureId { get; set; }

        [Required]
        [Display(Name = "Operation")]
        public string Operation { get; set; }
    }
}
