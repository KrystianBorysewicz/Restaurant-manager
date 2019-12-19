using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RestaurantManager.Core.Models;

namespace RestaurantManager.Core.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class FloorController : ControllerBase
    {
        public FloorController(IOptions<DatabaseSettings> databaseSettings)
        {
            this.databaseSettings = databaseSettings;
        }
        // Create new floor
        [HttpPost("newfloor/{id}")]
        public ActionResult<Floor> CreateFloor(string id)
        {
            return new Floor();
        }
        public ActionResult<Floor> DeleteFloor(string id)
        {
            return new Floor();
        }
        public ActionResult<Floor> AddTableToFloor(string id)
        {
            return new Floor();
        }
        private readonly ILogger<FloorController> _logger;
        private readonly IOptions<DatabaseSettings> databaseSettings;

        public FloorController(ILogger<FloorController> logger)
        {
            _logger = logger;
        }
    }
}