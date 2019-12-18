using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Table
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int tableId { get; set; }
        public int Floor { get; set; }
        public int tableNumber { get; set; }
        //public int Seats { get; set; }
        public Vector2 FloorLocation { get; set; }
        public tableStatus TableStatus { get; set; }
        public Employee AssignedStaff { get; set; }
    }
    public enum tableStatus
    {
        Free,
        Taken,
        WaitingForFood,
        WaitingToPay,
        CleaningRequired
    }
}