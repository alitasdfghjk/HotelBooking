using HotelBooking.Models;

namespace HotelBooking.Strategies
{
    public class LoyaltyDiscount : IPriceStrategy
    {
        public decimal Calculate(Booking booking)
        {
            return booking.Room.Price * 0.85m; 
        }
    }
}
