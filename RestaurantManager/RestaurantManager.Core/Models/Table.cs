using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Table
    {
        int tableId { get; set; }
        TableStatus tableStatus { get; set; }
        Employee assignedStaff { get; set; }
    }
}