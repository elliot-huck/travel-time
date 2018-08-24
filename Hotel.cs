using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelTime
{


  public class Hotel : Location
  {
    public int Rating { get; set; }
    public double RoomPrice { get; set; }
    private List<Room> RoomList = new List<Room>();
    private Dictionary<Room, Tourist> Reservations = new Dictionary<Room, Tourist>();

    public Hotel(int rating, double roomPrice, int numRooms)
    {
      this.Rating = rating;
      this.RoomPrice = roomPrice;
      for (int i = 1; i <= numRooms; i++)
      {
        Room newRoom = new Room()
        {
          Number = i,
          MaxOccupants = 4,
          Available = true,
        };
        this.RoomList.Add(newRoom);
      }
    }

    // Gets a random available room and reserves it under the tourist's name
    public void MakeReservation(Tourist guest)
    {
      List<Room> availableRooms =
      (from room in this.RoomList
       where room.Available
       select room).ToList();
      Console.WriteLine($"There are {availableRooms.Count} rooms available");
			if (availableRooms.Count == 0)
			{
					Console.WriteLine("Sorry!");
					return;
			}

      Random rand = new Random();
      int randomRoomIndex = rand.Next(availableRooms.Count);
      Room reservedRoom = availableRooms[randomRoomIndex];
      reservedRoom.Available = false;
      this.Reservations.Add(reservedRoom, guest);
			Console.WriteLine($"{guest.Name} just reserved room #{reservedRoom.Number}");
    }

    public void CheckIn(Tourist guest)
    {
      var checkingIn =
      (from reservation in this.Reservations
       where reservation.Value == guest
       select reservation).ToList()[0];

      this.Reservations.Remove(checkingIn.Key);

    }

    public void CheckOut(Tourist guest, int roomNumber)
    {
      Room checkingOut =
      (from room in this.RoomList
       where room.Number == roomNumber
       select room
      ).ToList()[0];

      checkingOut.Available = true;
    }

    public Dictionary<string, string> RegisterComplaint(string complaint)
    {
      Dictionary<string, string> response = new Dictionary<string, string>();
      response["Feedback"] = "Thank you for your feedback. We value your business.";
      response["Offer"] = "";

      return response;
    }

    public Dictionary<string, string> RegisterComplaint(string complaint, string email)
    {
      Dictionary<string, string> response = new Dictionary<string, string>();
      response["Feedback"] = "Thank you for your feedback. We value your business.";
      response["Offer"] = "One free night if you visit on January 31st.";

      return response;
    }
  }
}
