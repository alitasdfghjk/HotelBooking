using HotelBooking.Models;

namespace HotelBooking.Decorators
{
    public class SpaDecorator
    {
        private Booking _booking;

        public SpaDecorator(Booking booking)
        {
            _booking = booking;
            _booking.Services.Add("Spa");
        }

        public Booking GetBooking() => _booking;
    }
}
