using HotelBooking.Models;

namespace HotelBooking.Strategies
{
    public interface IPriceStrategy
    {
        decimal Calculate(Booking booking);
    }
}
