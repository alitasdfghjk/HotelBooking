using HotelBooking.Models;

namespace HotelBooking.Factories
{
    public static class RoomFactory
    {
        public static Room CreateRoom(string type)
        {
            return type switch
            {
                "Standard" => new StandardRoom(),
                "Luxury" => new LuxuryRoom(),
                "Apartment" => new ApartmentRoom(),
                _ => null
            };
        }
    }
}
