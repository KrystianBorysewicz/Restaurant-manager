using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Floor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int FloorId { get; set; }
        public IEnumerable<Table> TableList { get; set; }
    }
}
