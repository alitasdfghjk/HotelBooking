using System;
using HotelBooking.Models;
using HotelBooking.Factories;
using HotelBooking.Builders;
using HotelBooking.Decorators;
using HotelBooking.Observers;
using HotelBooking.Services;
using HotelBooking.Strategies;

namespace HotelBooking
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите тип комнаты: Standard, Luxury, Apartment");
            string type = Console.ReadLine();

            Room room = RoomFactory.CreateRoom(type);
            if (room == null)
            {
                Console.WriteLine("Такой тип комнаты не существует!");
                return;
            }

            var builder = new BookingBuilder();
            Booking booking = builder.SetRoom(room)
                                     .SetMeal("Breakfast")
                                     .SetTransfer("Airport")
                                     .Build();

            booking = new BreakfastDecorator(booking).GetBooking();
            booking = new SpaDecorator(booking).GetBooking();
            booking = new ParkingDecorator(booking).GetBooking();

            var service = new BookingService();
            service.Subscribe(new CustomerNotification());
            service.Subscribe(new AdminNotification());

            IPriceStrategy strategy = new SeasonalDiscount();
            decimal price = strategy.Calculate(booking);

            Console.WriteLine($"Booking for {booking.Room.Name}, Services: {string.Join(", ", booking.Services)}");
            Console.WriteLine($"Price: {price}");

            service.ChangeStatus(booking, "Confirmed");

            Console.ReadKey();
        }
    }
}

