using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class TableReservation
    {
        public int ReservationId { get; set; }
        public int TableId { get; set; }
        public int MyProperty { get; set; }
    }
}
