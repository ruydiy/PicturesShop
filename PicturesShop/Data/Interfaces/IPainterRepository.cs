namespace PicturesShop.Data.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.PainterController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface IPainterRepository
    {
        public bool AddPainter(AddPainter painter);
        public bool DeletePainter(DeletePainter painter);
        public bool UpdatePainterPicture(UpdatePainterPicture painterPicture);
        public List<Painter> GetAllPainters();
    }
}
