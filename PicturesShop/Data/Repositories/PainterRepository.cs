namespace PicturesShop.Data.Repositories
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Models;
    using PicturesShop.Models.PainterController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PainterRepository : IPainterRepository
    {
        private ApplicationDbContext context;
        public PainterRepository()
        {
            context = new ApplicationDbContext();
        }

        public bool AddPainter(AddPainter painter)
        {
            if (!context.Painters.Any(a => a.FirstName == painter.FirstName && a.LastName == painter.LastName))
            {
                context.Painters.Add(new Painter() { FirstName = painter.FirstName, LastName = painter.LastName });
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeletePainter(DeletePainter painter)
        {
            Painter a = context.Painters.Find(painter.PainterId);
            if (a != null)
            {
                context.Painters.Remove(a);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Painter> GetAllPainters()
        {
            return context.Painters.ToList();
        }

        public bool UpdatePainterPicture(UpdatePainterPicture painterPicture)
        {
            Painter a = context.Painters.Find(painterPicture.PainterId);
            Picture b = context.Pictures.Find(painterPicture.PictureId);
            if (a != null && b != null)
            {
                context.Entry(b).Collection("Painters").Load();
                if (painterPicture.Operation == "addPainter")
                {
                    b.Painters.Add(a);
                    context.SaveChanges();
                    return true;
                }
                else if (painterPicture.Operation == "removePainter")
                {
                    if (b.Painters.Contains(a))
                    {
                        b.Painters.Remove(a);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
