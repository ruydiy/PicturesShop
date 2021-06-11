namespace PicturesShop.Data.Interfaces
{
    using PicturesShop.Models;
    using PicturesShop.Models.PublisherController;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface IPublisherRepository
    {
        public bool AddPublisher(Publisher publisher);
        public bool DeletePublisher(DeletePublisher publisher);
        public bool UpdatePublisherPicture(UpdatePublisherPicture publisherPicture);

    }
}
