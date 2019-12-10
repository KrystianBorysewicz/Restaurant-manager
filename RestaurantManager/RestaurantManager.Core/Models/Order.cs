using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public string orderStatus { get; set; }
        public DateTime timestamp { get; set; }
        public List<Product> products { get; set; }

    }
}
