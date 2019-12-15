using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Table
    {
        int tableId { get; set; }
        int tableNumber { get; set; }
        public int Floor { get; set; }
        public Vector2 FloorLocation { get; set; }
        TableStatus TableStatus { get; set; }
        Employee AssignedStaff { get; set; }
    }
}