namespace PicturesShop.Services.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.PictureController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface IPictureService
    {
        //public bool CreatePicture(Picture picture, Publisher publisher, Painter painter);
        public bool CreatePicture(CreatePicture picture);

        public List<Painter> GetPainters();

        //public bool DeletePicture(DeletePicture picture);

        public bool EditPicture(EditPicture picture);
        public List<Picture> GetPicturesByGenre(Genre genre);

        public List<Picture> GetAllPictures();
        public Picture GetPictureById(int pictureId);
    }
}
