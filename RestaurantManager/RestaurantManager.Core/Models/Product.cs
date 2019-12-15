using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }

    }
}
