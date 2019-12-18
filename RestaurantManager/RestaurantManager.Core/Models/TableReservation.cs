using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class TableReservation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int ReservationId { get; set; }
        public int? TableId { get; set; }
        public DateTime ReservationTime { get; set; }
        public string ReservationName { get; set; }
        public int GuestAmount { get; set; }
    }
}
