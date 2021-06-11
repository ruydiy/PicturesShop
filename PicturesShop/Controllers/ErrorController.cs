namespace PicturesShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("~/Error")]
    public class ErrorController : Controller
    {
        [HttpGet("404")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
