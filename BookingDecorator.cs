using HotelBooking.Models;

namespace HotelBooking.Decorators
{
    public abstract class BookingDecorator : Booking
    {
        protected Booking _booking;

        public BookingDecorator(Booking booking)
        {
            _booking = booking;
        }
    }
}
