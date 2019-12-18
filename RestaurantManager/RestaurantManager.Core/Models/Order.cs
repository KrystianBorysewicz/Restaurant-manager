using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int OrderId { get; set; }
        public int tableId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime Timestamp { get; set; }
        public List<Product> Products { get; set; }

    }
}
