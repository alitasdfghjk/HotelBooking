using HotelBooking.Models;

namespace HotelBooking.Observers
{
    public interface IObserver
    {
        void Update(Booking booking);
    }
}
