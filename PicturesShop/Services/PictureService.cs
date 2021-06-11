namespace PicturesShop.Services
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Data.Repositories;
    using PicturesShop.Models;
    using PicturesShop.Models.PictureController;
    using PicturesShop.Services.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PictureService : IPictureService
    {
        private IPictureRepository repository { get; set; }
        public PictureService()
        {
            repository = new PictureRepository();
        }
        public bool CreatePicture(CreatePicture picture)
        {
            return repository.CreatePicture(picture);
        }

        public bool EditPicture(EditPicture picture)
        {
            return repository.EditPicture(picture);
        }

        public List<Picture> GetAllPictures()
        {
            return repository.GetAllPictures();
        }

        public List<Painter> GetPainters()
        {
            return repository.GetPainters();
        }

        public Picture GetPictureById(int pictureId)
        {
            return repository.GetPictureById(pictureId);
        }

        public List<Picture> GetPicturesByGenre(Genre genre)
        {
            return repository.GetPicturesByGenre(genre.GenreName);
        }
    }
}
