using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Product
    {
        public int productId { get; set; }
        public double price { get; set; }
        public bool available { get; set; }
        public string description { get; set; }

    }
}
