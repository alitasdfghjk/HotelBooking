using HotelBooking.Models;

namespace HotelBooking.Decorators
{
    public class BreakfastDecorator
    {
        private Booking _booking;

        public BreakfastDecorator(Booking booking)
        {
            _booking = booking;
            _booking.Services.Add("Breakfast");
        }

        public Booking GetBooking() => _booking;
    }
}
