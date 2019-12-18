using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class OrderContent
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int OrderContentId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
