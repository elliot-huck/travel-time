using System;
using System.Collections.Generic;

namespace TravelTime
{
  public enum PaymentTypes
  {
    Cash,
    Visa,
    Mastercard,
    Discover,
    Bitcoin
  }
  class Program
  {
    static void Main(string[] args)
    {
      Tourist johnnyDepp = new Tourist()
      {
        Name = "Johnny Depp",
        Budget = 1000.00,
      };

			Tourist angieJolie = new Tourist()
			{
				Name = "Angelina Jolie",
				Budget = 7000.00,
			};

			Tourist bradPitt = new Tourist()
			{
				Name = "Brad Pitt",
				Budget = 9000.00,
			};

      Activity zipLine = new Activity()
      {
        Name = "Island Zip Lines",
        Price = 50.00,
        MaximumGuests = 100,
        HoursOperation = "8am - 5pm"
      };

      Transportation zipShuttle = new Transportation()
      {
        Type = "Shuttle",
        Price = 0.00,
        Capacity = 15
      };

      Transportation emilysCabs = new Transportation()
      {
        Type = "Cab",
        Price = 100.00,
        Capacity = 3
      };

      Hotel hotelCalifornia = new Hotel(3, 100.00, 2)
      {
        Name = "Hotel California",
      };

      hotelCalifornia.MakeReservation(johnnyDepp);
			hotelCalifornia.MakeReservation(angieJolie);

      hotelCalifornia.CheckIn(johnnyDepp);
      johnnyDepp.Spend(hotelCalifornia.RoomPrice);

			hotelCalifornia.CheckIn(angieJolie);
			angieJolie.Spend(hotelCalifornia.RoomPrice);

			hotelCalifornia.MakeReservation(bradPitt);

      Dictionary<string, string> response = hotelCalifornia.RegisterComplaint("NO rum at the bar!!!");

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
      Console.WriteLine($"{angieJolie.Name} has {angieJolie.Budget.ToString("C")} left to spend.");
      Console.WriteLine($"{angieJolie.Name} has {angieJolie.Budget.ToString("C")} left to spend.");
    }
  }
}
