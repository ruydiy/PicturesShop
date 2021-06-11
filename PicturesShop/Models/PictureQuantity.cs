namespace PicturesShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PictureQuantity
    {
        public int Id { get; set; }
        public Picture Picture { get; set; }

        public int PictureId { get; set; }

        public int Quantity { get; set; }

        public int OrderId { get; set; }
    }
}
