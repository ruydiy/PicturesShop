namespace PicturesShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;


    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string GenreName { get; set; }

        public ICollection<Picture> Pictures { get; set; }
        public override string ToString()
        {
            return $"{this.GenreName}";
        }
    }
}
