namespace PicturesShop.Data.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.PictureController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface IPictureRepository
    {
        public bool CreatePicture(CreatePicture picture);

        public bool EditPicture(EditPicture picture);

        public List<Picture> GetPicturesByGenre(string genreName);

        public List<Painter> GetPainters();
        public List<Picture> GetAllPictures();
        public Picture GetPictureById(int pictureId);

    }
}
