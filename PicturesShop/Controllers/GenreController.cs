namespace PicturesShop.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PicturesShop.Models.GenreController;
    using PicturesShop.Services;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Policy = "adminOnly")]
    [Route("~/Genre")]
    public class GenreController : Controller
    {
        private IGenreService genreService { get; set; }
        public GenreController()
        {
           genreService = new GenreService();
        }


        [HttpPost("DeleteGenre")]
        public IActionResult DeleteGenre(DeleteGenre genre)
        {
            if (ModelState.IsValid)
            {
                bool status = genreService.DeleteGenre(genre);
                if (status)
                {
                    return RedirectToAction("Success", "Admin", new { message = "DeleteGenre" });
                }
                else
                {
                    return RedirectToAction("Failed", "Admin", new { message = "DeleteGenre" });
                }
            }
            else
            {
                return BadRequest();
            }
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
