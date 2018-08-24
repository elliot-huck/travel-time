using System;
using System.Collections.Generic;

namespace TravelTime
{


  public class Hotel : Location
  {
    public int Rating { get; set; }
		public double RoomPrice {get; set;}
		private List<Room> RoomList = new List<Room>();
		private Dictionary<Room, Tourist> Reservations = new Dictionary<Room, Tourist>();

		public Hotel(int rating, double roomPrice, int numRooms)
		{
			this.Rating = rating;
			this.RoomPrice = roomPrice;
			for (int i = 0; i < numRooms; i++)
			{
					Room newRoom = new Room(){
						Number = i,
						MaxOccupants = 4,
						Available = true,
					};
					this.RoomList.Add(newRoom);
			}
		}

    public void MakeReservation(Tourist guest)
    {
			List<Room> availableRooms = new List<Room>();
			
    }

    public void CheckIn(Tourist guest, PaymentTypes payment)
    {
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
