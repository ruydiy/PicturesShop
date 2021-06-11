namespace PicturesShop.Data.Repositories
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Models;
    using PicturesShop.Models.GenreController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class GenreRepository : IGenreRepository
    {
        private ApplicationDbContext context;
        public GenreRepository()
        {
            context = new ApplicationDbContext();
        }
        public bool AddGenre(Genre genre)
        {
            if (context.Genres.Any(g => g.GenreName == genre.GenreName))
            {
                return false;
            }
            else
            {
                context.Genres.Add(genre);
                context.SaveChanges();
                return true;
            }
        }

        public bool DeleteGenre(DeleteGenre genre)
        {
            Genre g = context.Genres.Find(genre.GenreId);
            if (g != null)
            {
                context.Genres.Remove(g);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateGenrePicture(UpdateGenrePicture genrePicture)
        {
            Genre g = context.Genres.Find(genrePicture.GenreId);
            Picture b = context.Pictures.Find(genrePicture.PictureId);
            if (g == null || b == null)
            {
                return false;
            }
            else
            {
                b.Genres = new List<Genre>();
                b.Genres.Add(g);
                context.SaveChanges();
                return true;
            }
        }
    }
}
