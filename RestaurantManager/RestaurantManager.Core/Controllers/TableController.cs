using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Newtonsoft.Json;
using RestaurantManager.Core.Models;
using RestaurantManager.Core.Services;

namespace RestaurantManager.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly MongoCRUD db;
        public TableController(IDatabaseSettings databaseSettings)
        {
            this.db = new MongoCRUD(databaseSettings);
        }
        [HttpPost("create")]
        public ActionResult<Table> CreateTable(Table newTable)
        {
            db.CreateOne(newTable);
            return newTable;
        }
        [HttpGet]
        public ActionResult<List<Table>> Get(Dictionary<string, object> filter) =>
            db.GetAll<Table>(filter);
        [HttpDelete]
        public ActionResult<Table> DeleteTable(int tableId)
        {
            return new Table();
        }
        [HttpPut]
        public ActionResult<Table> ChangeTableStatus(int tableId, tableStatus newStatus)
        {
            return new Table();
        }
        [HttpPost("addorders")]
        public ActionResult<Table> AddOrdersToTable(int tableId, List<Order> newOrders)
        {
            return new Table();
        }
    }
}