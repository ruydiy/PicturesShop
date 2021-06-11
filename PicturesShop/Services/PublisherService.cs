namespace PicturesShop.Services
{
    using PicturesShop.Data.Interfaces;
    using PicturesShop.Data.Repositories;
    using PicturesShop.Models;
    using PicturesShop.Models.PublisherController;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PublisherService : IPublisherService
    {
        private IPublisherRepository repository { get; set; }
        public PublisherService()
        {
            repository = new PublisherRepository();
        }

        public bool AddPublisher(Publisher publisher)
        {
            return repository.AddPublisher(publisher);
        }

        public bool DeletePublisher(DeletePublisher publisher)
        {
            return repository.DeletePublisher(publisher);
        }

        public bool UpdatePublisherPicture(UpdatePublisherPicture publisherPicture)
        {
            return repository.UpdatePublisherPicture(publisherPicture);
        }
    }
}
