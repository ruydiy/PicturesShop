namespace PicturesShop.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PicturesShop.Models;
    using PicturesShop.Models.PublisherController;
    using PicturesShop.Services;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Policy = "adminOnly")]
    public class PublisherController : Controller
    {
        private IPublisherService publisherService { get; set; }
        public PublisherController()
        {
            publisherService = new PublisherService();
        }

        [HttpPost("AddPublisher")]
        public IActionResult AddPublisher(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                bool status = publisherService.AddPublisher(publisher);
                if (status)
                {
                    return RedirectToAction("Success", "Admin", new { message = "AddPublisher" });
                }
                else
                {
                    return RedirectToAction("Failed", "Admin", new { message = "AddPublisher" });
                }
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("DeletePublisher")]
        public IActionResult DeletePublisher(DeletePublisher publisher)
        {
            if (ModelState.IsValid)
            {
                bool status = publisherService.DeletePublisher(publisher);
                if (status)
                {
                    return RedirectToAction("Success", "Admin", new { message = "DeletePublisher" });
                }
                else
                {
                    return RedirectToAction("Failed", "Admin", new { message = "DeletePublisher" });
                }
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("UpdatePublisherPicture")]
        public IActionResult UpdatePublisherPicture(UpdatePublisherPicture publisherPicture)
        {
            if (ModelState.IsValid)
            {
                bool status = publisherService.UpdatePublisherPicture(publisherPicture);
                if (status)
                {
                    return RedirectToAction("Success", "Admin", new { message = "BookPublisherConnected" });
                }
                else
                {
                    return RedirectToAction("Failed", "Admin", new { message = "BookPublisherConnected" });
                }
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
