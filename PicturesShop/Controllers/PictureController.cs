using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PicturesShop.Models;
using PicturesShop.Models.PictureController;
using PicturesShop.Services;
using PicturesShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicturesShop.Controllers
{
    [Route("~/Picture")]
    public class PictureController : Controller
    {
        private IPictureService pictureService { get; set; }
        public PictureController()
        {
            pictureService = new PictureService();
        }

        [HttpGet("{id}")]
        public IActionResult Index([FromRoute] int id)
        {
            if (id != 0)
            {
                Picture picture = pictureService.GetPictureById(id);
                if (picture == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(picture);
                }
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetBookByIdJson/{id}")]
        public IActionResult GetPictureByIdJson([FromRoute] int id)
        {
            if (id != 0)
            {
                Picture picture = pictureService.GetPictureById(id);
                if (picture == null)
                {
                    return NotFound();
                }
                else
                {
                    return Json(picture);
                }
            }
            else
            {
                return NotFound();
            }
        }
        

        [Authorize(Policy = "adminOnly")]
        [HttpPost("EditPicture")]
        public IActionResult EditPicture(EditPicture picture)
        {
            if (ModelState.IsValid)
            {
                bool status = pictureService.EditPicture(picture);
                if (status)
                {
                    return RedirectToAction("Success", "Admin", new { message = "EditPicture" });
                }
                else
                {
                    return RedirectToAction("Failed", "Admin", new { message = "EditPicture" });
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [Authorize(Policy = "adminOnly")]
        [HttpPost("CreatePicture")]
        public IActionResult CreatePicture(CreatePicture picture)
        {
            if (ModelState.IsValid)
            {
                bool status = pictureService.CreatePicture(picture);
                if (status)
                {
                    return RedirectToAction("Success", "Admin", new { message = "CreatePicture" });
                }
                else
                {
                    return RedirectToAction("Failed", "Admin", new { message = "CreatePicture" });
                }
            }
            else
            {
                return BadRequest();
            }
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
