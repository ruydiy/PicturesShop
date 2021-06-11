namespace PicturesShop.Data.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Models;
    using PicturesShop.Models.PictureController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PictureRepository : IPictureRepository
    {
        private ApplicationDbContext context;
        public PictureRepository()
        {
            context = new ApplicationDbContext();
        }

        public bool CreatePicture(CreatePicture picture)
        {
            if (context.Pictures.Any(b => b.Title == picture.Title && b.Publisher.PublisherName == picture.PublisherName))
            {
                return false;
            }
            else
            {
                Publisher pub = context.Publishers.FirstOrDefault(p => p.PublisherName == picture.PublisherName);
                if (pub == null)
                {
                    pub = new Publisher() { PublisherName = picture.PublisherName };
                }
                Genre gen = context.Genres.FirstOrDefault(g => g.GenreName == picture.GenreName);
                if (gen == null)
                {
                    gen = new Genre() { GenreName = picture.GenreName };
                }
                Painter au = context.Painters.FirstOrDefault(a => a.FirstName == picture.FirstName && a.LastName == picture.LastName);
                if (au == null)
                {
                    au = new Painter() { FirstName = picture.FirstName, LastName = picture.LastName };
                }
                Picture b = new Picture();
                b.Title = picture.Title;
                b.Description = picture.Description;
                b.ImgUrl = picture.ImgUrl;
                b.Parts = picture.Parts;
                b.PublishedOn = picture.PublishedOn;
                b.Price = picture.Price;
                b.Painters = new List<Painter>();
                b.Painters.Add(au);
                b.Genres = new List<Genre>();
                b.Genres.Add(gen);
                b.Orders = new List<Order>();
                b.Publisher = pub;
                context.Pictures.Add(b);
                context.SaveChanges();
                return true;
            }
        }

        public bool EditPicture(EditPicture picture)
        {
            Picture b = context.Pictures.Find(picture.Id);
            if (b != null)
            {
                if (picture.Title != null)
                {
                    b.Title = picture.Title;
                }
                if (picture.Description != null)
                {
                    b.Description = picture.Description;
                }
                if (picture.Price != null)
                {
                    b.Price = Convert.ToDouble(picture.Price);
                }
                if (picture.ImgUrl != null)
                {
                    b.ImgUrl = picture.ImgUrl;
                }
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Picture> GetAllPictures()
        {
            return context.Pictures
                     .Select(picture => new Picture()
                     {
                         Id = picture.Id,
                         Title = picture.Title,
                         Description = picture.Description,
                         Genres = picture.Genres.Select(genre => genre).ToList(),
                         Price = picture.Price,
                         Parts = picture.Parts,
                         ImgUrl = picture.ImgUrl,
                         PublishedOn = picture.PublishedOn,
                         PublisherId = picture.PublisherId,
                         Painters = picture.Painters.Select(painter => painter).ToList()
                     }).ToList();
        }

        public List<Painter> GetPainters()
        {
            return context.Painters.ToList();
        }

        public Picture GetPictureById(int pictureId)
        {
            return context.Pictures.Select(picture => new Picture()
            {
                Id = picture.Id,
                Title = picture.Title,
                Description = picture.Description,
                Genres = picture.Genres.Select(genre => genre).ToList(),
                Publisher = context.Publishers.FirstOrDefault(p => p.Id == picture.PublisherId),
                Price = picture.Price,
                Parts = picture.Parts,
                ImgUrl = picture.ImgUrl,
                PublishedOn = picture.PublishedOn,
                PublisherId = picture.PublisherId,
                Painters = picture.Painters.Select(author => author).ToList()
            }).FirstOrDefault(b => b.Id == pictureId);
        }

        public List<Picture> GetPicturesByGenre(string genreName)
        {
            Genre genre = context.Genres.Where(g => g.GenreName == genreName).FirstOrDefault<Genre>(); ;
            if (genre != null)
            {
                return null;
                    //context.Painters.Include(b => b.Genres).Where(b => b.Genres.Contains(genre)).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
