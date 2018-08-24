using System;
using System.Collections.Generic;

namespace TravelTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Tourist johnnyDepp = new Tourist() {
                Name = "Johnny Depp",
                CountryOrigin = "USA",
                Budget = 20000.00
            };

            Activity zipLine = new Activity() {
                Name = "Island Zip Lines",
                Price = 50.00,
                MaximumGuests = 100,
                HoursOperation = "8am - 5pm"
            };

            Transportation zipShuttle = new Transportation() {
                Type = "Shuttle",
                Price = 0.00,
                Capacity = 15
            };

            Transportation emilysCabs = new Transportation() {
                Type = "Cab",
                Price = 100.00,
                Capacity = 3
            };

            Hotel hotelCalifornia = new Hotel() {
                Name = "Hotel California",
                RoomPrice = 200.00,
                Rating = 3,
                MaximumOccupancy = 1000
            };

            hotelCalifornia.MakeReservation(
                johnnyDepp,
                PaymentTypes.Cash,
                DateTime.Now,
                new DateTime(2018, 8, 30),
                1);

            hotelCalifornia.CheckIn(johnnyDepp, PaymentTypes.Cash);
            johnnyDepp.Spend(hotelCalifornia.RoomPrice);

            Dictionary<string, string> response = hotelCalifornia.RegisterComplaint("NO rum at the bar!!!");
            Console.WriteLine(response["Feedback"]);

            zipLine.Register(
                johnnyDepp,
                0,
                new DateTime(2018, 8, 25),
                PaymentTypes.Cash);

            johnnyDepp.Travel(hotelCalifornia, zipShuttle, zipLine);
            johnnyDepp.Spend(zipShuttle.Price);
            johnnyDepp.Spend(zipLine.Price);

            johnnyDepp.Travel(zipLine, emilysCabs, hotelCalifornia);
            johnnyDepp.Spend(emilysCabs.Price);

            Console.WriteLine($"{johnnyDepp.Name} has {johnnyDepp.Budget.ToString("C")} left to spend.");
        }
    }
}
