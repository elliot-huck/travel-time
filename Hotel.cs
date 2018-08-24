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

    public class Hotel {
        public string Name { get; set; }
        public string Location { get; set; }
        public double RoomPrice { get; set; }
        public int Rating { get; set; }
        public int MaximumOccupancy { get; set; }

        public string MakeReservation (
            Tourist guest,
            PaymentTypes payment,
            DateTime checkIn,
            DateTime checkOut,
            int guestCount
        )
        {
            return "f294thg29urhv89uhv8ut24h";
        }

        public int CheckIn (Tourist guest, PaymentTypes payment)
        {
            return 1;
        }

        public Dictionary<string, string> RegisterComplaint (string complaint)
        {
            Dictionary<string, string> response = new Dictionary<string, string>();
            response["Feedback"] = "Thank you for your feedback. We value your business.";
            response["Offer"] = "";

            return response;
        }

        public Dictionary<string, string> RegisterComplaint (string complaint, string email)
        {
            Dictionary<string, string> response = new Dictionary<string, string>();
            response["Feedback"] = "Thank you for your feedback. We value your business.";
            response["Offer"] = "One free night if you visit on January 31st.";

            return response;
        }
    }
}
