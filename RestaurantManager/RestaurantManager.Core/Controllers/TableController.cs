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
    public class TableController : ControllerBase
    {
        public ActionResult<Table> CreateTable()
        {
            return new Table();
        }
        public ActionResult<Table> DeleteTable(int tableId)
        {
            return new Table();
        }
        public ActionResult<Table> ChangeTableStatus(int tableId, tableStatus newStatus)
        {
            return new Table();
        }
        public ActionResult<Table> AddOrdersToTable(int tableId, Order newOrder)
        {
            return new Table();
        }
    }
}