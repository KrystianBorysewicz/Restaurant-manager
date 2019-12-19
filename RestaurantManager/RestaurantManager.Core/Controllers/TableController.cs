using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.Core.Models;
using RestaurantManager.Core.Services;

namespace RestaurantManager.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly TableService _tableService;
        public TableController(TableService tableService)
        {
            _tableService = tableService;
        }
        [HttpPost("create")]
        public ActionResult<Table> CreateTable(Table newTable)
        {
            _tableService.Create(newTable);
            return newTable;
        }
        [HttpGet]
        public ActionResult<List<Table>> Get() =>
            _tableService.GetAll();
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