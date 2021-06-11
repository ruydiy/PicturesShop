namespace PicturesShop.Services.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.PublisherController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //using System.Security.Policy;
    using System.Threading.Tasks;

    public interface IPublisherService
    {
        public bool AddPublisher(Publisher publisher);
        public bool DeletePublisher(DeletePublisher publisher);
        public bool UpdatePublisherPicture(UpdatePublisherPicture publisherPicture);
    }
}
