namespace PicturesShop.Data.Repositories
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Models;
    using PicturesShop.Models.PublisherController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PublisherRepository : IPublisherRepository
    {
        private ApplicationDbContext context;
        public PublisherRepository()
        {
            context = new ApplicationDbContext();
        }

        public bool AddPublisher(Publisher publisher)
        {
            if (context.Publishers.Any(p => p.PublisherName == publisher.PublisherName))
            {
                return false;
            }
            else
            {
                context.Publishers.Add(publisher);
                context.SaveChanges();
                return true;
            }
        }

        public bool DeletePublisher(DeletePublisher publisher)
        {
            Publisher p = context.Publishers.Find(publisher.PublisherId);
            if (p != null)
            {
                context.Publishers.Remove(p);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePublisherPicture(UpdatePublisherPicture publisherPicture)
        {
            Publisher p = context.Publishers.Find(publisherPicture.PublisherId);
            Picture b = context.Pictures.Find(publisherPicture.PictureId);
            if (p != null && b != null)
            {
                context.Entry(b).Collection("Painters").Load();
                if (publisherPicture.Operation == "addPublisher")
                {
                    b.Publisher = p;
                    context.SaveChanges();
                    return true;
                }
                else if (publisherPicture.Operation == "removePublisher")
                {
                    context.Entry(p).Collection("Pictures").Load();
                    if (p.Pictures.Contains(b))
                    {
                        p.Pictures.Remove(b);
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
