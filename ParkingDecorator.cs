using HotelBooking.Models;

namespace HotelBooking.Decorators
{
    public class ParkingDecorator
    {
        private Booking _booking;

        public ParkingDecorator(Booking booking)
        {
            _booking = booking;
            _booking.Services.Add("Parking");
        }

        public Booking GetBooking() => _booking;
    }
}
