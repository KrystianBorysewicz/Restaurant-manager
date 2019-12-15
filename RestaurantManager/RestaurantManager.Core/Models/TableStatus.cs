using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class TableStatus
    {
        public string Status { get; set; }
        public DateTime ChangedTime { get; set; }
        public Employee ChangedBy { get; set; }
        public DateTime? ReservedFor { get; set; }
        public string ReservedBy { get; set; }
        
        /**
         * Free table
         * Waiting to order
         * Waiting for food
         * Waiting for bill
         * Paid
         * Reserved table
         **/
    }
}
