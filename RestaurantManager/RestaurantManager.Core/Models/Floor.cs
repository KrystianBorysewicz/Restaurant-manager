using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Floor
    {
        public int FloorId { get; set; }
        public IEnumerable<Table> TableList { get; set; }
    }
}
