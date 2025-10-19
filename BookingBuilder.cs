using HotelBooking.Models;

namespace HotelBooking.Builders
{
    public class BookingBuilder
    {
        private Booking _booking = new Booking();

        public BookingBuilder SetRoom(Room room)
        {
            _booking.Room = room;
            return this;
        }

        public BookingBuilder SetMeal(string meal)
        {
            _booking.Services.Add(meal);
            return this;
        }

        public BookingBuilder SetTransfer(string transfer)
        {
            _booking.Services.Add(transfer);
            return this;
        }

        public Booking Build()
        {
            return _booking;
        }
    }
}
