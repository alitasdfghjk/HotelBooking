using System;
using HotelBooking.Models;

namespace HotelBooking.Observers
{
    public class AdminNotification : IObserver
    {
        public void Update(Booking booking)
        {
            Console.WriteLine($"[Admin] Booking status changed to: {booking.Status}");
        }
    }
}
