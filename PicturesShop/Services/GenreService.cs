namespace PicturesShop.Services
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Data.Repositories;
    using PicturesShop.Models;
    using PicturesShop.Models.GenreController;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class GenreService : IGenreService
    {
        private IGenreRepository repository { get; set; }
        public GenreService()
        {
            repository = new GenreRepository();
        }
        public bool AddGenre(Genre genre)
        {
            return repository.AddGenre(genre);
        }

        public bool AddGenrePicture(AddGenrePicture addGenrePicture)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGenre(DeleteGenre genre)
        {
            return repository.DeleteGenre(genre);
        }

        public bool UpdateGenrePicture(UpdateGenrePicture updateGenrePicture)
        {
            return repository.UpdateGenrePicture(updateGenrePicture);
        }
    }
}
