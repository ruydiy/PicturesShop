using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PicturesShop.Models;
using PicturesShop.Models.AdminController;
using PicturesShop.Models.Enums;
using PicturesShop.Services;
using PicturesShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PicturesShop.Controllers
{
    [Authorize(Policy = "adminOnly")]
    [Route("~/Admin")]
    public class AdminController : Controller
    {
        private IPictureService pictureService { get; set; }
        private IOrderService orderService { get; set; }

        private IGenreService genreService { get; set; }

        private IPainterService painterService { get; set; }

        private readonly UserManager<User> _userManager;
        public AdminController(UserManager<User> userManager)
        {
            _userManager = userManager;
            pictureService = new PictureService();
            orderService = new OrderService();
            genreService = new GenreService();
            painterService = new PainterService();
        }

        [HttpGet("CreatePicture")]
        public IActionResult CreatePicture()
        {
            return View();
        }

        [HttpGet("EditPicture")]
        public IActionResult EditPicture()
        {
            return View();
        }

        [HttpGet("ViewOrdersByStatus/{status}")]
        public IActionResult ViewOrdersByStatus(string status)
        {
            if (Enum.IsDefined(typeof(OrderStatus), status))
            {
                return View(orderService.GetOrdersByStatus(status));
            }
            else if (status == "none")
            {
                return View(orderService.GetOrdersByStatus(status));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("ViewAndEditOrder/{id}")]
        public async Task<IActionResult> ViewAndEditOrder([FromRoute] int id)
        {
            if (id != 0)
            {
                Order order = orderService.GetOrderByIdAdmin(id);
                if (order != null)
                {
                    User u = await _userManager.FindByEmailAsync(order.UserEmail);
                    OrderAndUserInfo oui = new OrderAndUserInfo() { Order = order, FirstName = u.FirstName, LastName = u.LastName };
                    return View(oui);
                }
                else
                {
                    return RedirectToAction("404", "Error");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("FindOrderById")]
        public IActionResult FindOrderById()
        {
            return View();
        }

        [HttpGet("UpdatePainterPicture")]
        public IActionResult UpdatePainterPicture()
        {
            return View();
        }

        [HttpGet("ViewAllPainters")]
        public IActionResult ViewAllPainters()
        {
            return View(painterService.GetAllPainters());
        }

        [HttpGet("AddPainter")]
        public IActionResult AddPainter()
        {
            return View();
        }

        [HttpGet("DeletePainter")]
        public IActionResult DeletePainter()
        {
            return View();
        }

        [HttpGet("UpdatePublisherPicture")]
        public IActionResult UpdatePublisherPicture()
        {
            return View();
        }

        [HttpGet("AddPublisher")]
        public IActionResult AddPublisher()
        {
            return View();
        }

        [HttpGet("DeletePublisher")]
        public IActionResult DeletePublisher()
        {
            return View();
        }

        [HttpGet("Success")]
        public IActionResult Success([FromQuery] string message)
        {
            Type t = typeof(MessagesSuccess);
            PropertyInfo pi = t.GetProperty(message);
            if (pi != null)
            {
                return View(new Message() { MessageString = pi.GetValue(new MessagesSuccess()).ToString() });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("Failed")]
        public IActionResult Failed([FromQuery] string message)
        {
            Type t = typeof(MessageFailed);
            PropertyInfo pi = t.GetProperty(message);
            if (pi != null)
            {
                return View(new Message() { MessageString = pi.GetValue(new MessageFailed()).ToString() });
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
