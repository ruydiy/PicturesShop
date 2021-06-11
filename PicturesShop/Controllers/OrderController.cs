namespace PicturesShop.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using PicturesShop.Models;
    using PicturesShop.Models.OrderController;
    using PicturesShop.Services;
    using PicturesShop.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("~/Order")]
    public class OrderController : Controller
    {
        private IOrderService orderService { get; set; }
        public OrderController()
        {
            orderService = new OrderService();
        }

        [HttpGet("Cart")]
        [Authorize(Policy = "loginRequired")]
        public IActionResult Cart()
        {
            return View();
        }

        [HttpGet("FinishOrder")]
        [Authorize(Policy = "loginRequired")]
        public IActionResult FinishOrder()
        {
            return View();
        }
        [HttpGet("OrderSuccess")]
        [Authorize(Policy = "loginRequired")]
        public IActionResult OrderSuccess()
        {
            return View();
        }

        [Authorize(Policy = "loginRequired")]
        [HttpPost("CreateOrder")]
        public IActionResult CreateOrder(CreateOrder order)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    order.PicturesAndQuantityParsed = JsonConvert.DeserializeObject<Dictionary<int, int>>(order.PicturesAndQuantity);
                    return Ok(orderService.CreateOrder(order, User.Identity.Name));
                }
                catch
                {
                    return BadRequest();
                }

            }
            else
            {
                return BadRequest();
            }
        }

        [Authorize(Policy = "loginRequired")]
        [HttpGet("ViewOrders")]
        public IActionResult ViewOrders()
        {
            return View(orderService.GetOrdersByUser(User.Identity.Name));
        }

        [Authorize(Policy = "adminOnly")]
        [HttpPost("ChangeStatus")]
        public IActionResult ChangeStatus(ChangeStatus changeStatus)
        {
            if (ModelState.IsValid)
            {
                return Ok(orderService.ChangeStatus(changeStatus));

            }
            else
            {
                return BadRequest();
            }
        }

        [Authorize(Policy = "loginRequired")]
        [HttpGet("ViewOrder/{id}")]
        public IActionResult ViewOrder(int id)
        {
            if (id != 0)
            {
                Order o = orderService.GetOrderById(User.Identity.Name, id);
                if (o != null)
                {
                    return View(o);
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
