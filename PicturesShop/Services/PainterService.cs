namespace PicturesShop.Services
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Data.Repositories;
    using PicturesShop.Models;
    using PicturesShop.Models.PainterController;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PainterService : IPainterService
    {
        private IPainterRepository repository { get; set; }
        public PainterService()
        {
            repository = new PainterRepository();
        }
        public bool AddPainter(AddPainter painter)
        {
            return repository.AddPainter(painter);
        }

        public bool DeletePainter(DeletePainter painter)
        {
            return repository.DeletePainter(painter);
        }

        public List<Painter> GetAllPainters()
        {
            return repository.GetAllPainters();
        }

        public bool UpdatePainterPicture(UpdatePainterPicture painterPicture)
        {
            return repository.UpdatePainterPicture(painterPicture);
        }
    }
}
