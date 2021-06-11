namespace PicturesShop.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PicturesShop.Models.PainterController;
    using PicturesShop.Services;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Policy = "adminOnly")]
    [Route("~/Author")]
    public class PainterController : Controller
    {
        private IPainterService painterService { get; set; }
        public PainterController()
        {
            painterService = new PainterService();
        }
    }
}