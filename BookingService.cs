using System.Collections.Generic;
using HotelBooking.Models;
using HotelBooking.Observers;

namespace HotelBooking.Services
{
    public class BookingService
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void ChangeStatus(Booking booking, string status)
        {
            booking.Status = status;
            Notify(booking);
        }

        private void Notify(Booking booking)
        {
            foreach (var observer in _observers)
            {
                observer.Update(booking);
            }
        }
    }
}
