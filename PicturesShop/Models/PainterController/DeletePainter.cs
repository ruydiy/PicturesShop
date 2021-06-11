namespace PicturesShop.Models.PainterController
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;


    public class DeletePainter
    {
        [Required]
        public int PainterId { get; set; }
    }
}
