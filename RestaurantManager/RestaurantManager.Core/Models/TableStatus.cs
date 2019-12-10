using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class TableStatus
    {
        public string status { get; set; }
        public DateTime changedTime { get; set; }
        public Employee changedBy { get; set; }
        public DateTime? reservedFor { get; set; }
        public string? reservedBy { get; set; }
    }
}
