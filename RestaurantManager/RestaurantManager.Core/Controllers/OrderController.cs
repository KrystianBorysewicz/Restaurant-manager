using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.Core.Models;

namespace RestaurantManager.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public ActionResult<Order> CreateOrder(Order newOrder)
        {
            return new Order();
        }
        public ActionResult<Order> ReplaceOrder(int oldOrderId, Order newOrder)
        {
            return new Order();
        }
        public IEnumerable<Order> GetOrders(int tableId)
        {
            return new List<Order>();
        }
    }
}