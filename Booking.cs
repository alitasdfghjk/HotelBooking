using System;
using System.Collections.Generic;

namespace HotelBooking.Models
{
    public class Booking
    {
        public Room Room { get; set; }
        public List<string> Services { get; set; } = new List<string>();
        public string Status { get; set; } = "Pending";
    }
}
