using HotelBooking.Models;
using System;

namespace HotelBooking.Strategies
{
    public class SeasonalDiscount : IPriceStrategy
    {
        public decimal Calculate(Booking booking)
        {
            if (booking == null || booking.Room == null)
                throw new ArgumentNullException("Booking или Room равен null");

            return booking.Room.Price * 0.9m; 
        }
    }
}
