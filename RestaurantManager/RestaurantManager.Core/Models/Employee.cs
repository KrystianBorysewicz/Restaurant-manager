using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public char sex { get; set; }
        public string contactNumber { get; set; }
        public string emailAddress { get; set; }
        DateTime employedSince { get; set; }
    }
}
