namespace PicturesShop.Data.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.GenreController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface IGenreRepository
    {
        public bool AddGenre(Genre genre);

        public bool DeleteGenre(DeleteGenre genre);

        public bool UpdateGenrePicture(UpdateGenrePicture genrePicture);
    }
}
