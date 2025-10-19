using HotelBooking.Models;

namespace HotelBooking.Strategies
{
    public class PromoDiscount : IPriceStrategy
    {
        public decimal Calculate(Booking booking)
        {
            return booking.Room.Price * 0.8m; 
        }
    }
}
