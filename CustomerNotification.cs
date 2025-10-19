using System;
using HotelBooking.Models;

namespace HotelBooking.Observers
{
    public class CustomerNotification : IObserver
    {
        public void Update(Booking booking)
        {
            Console.WriteLine($"[Customer] Your booking status: {booking.Status}");
        }
    }
}
