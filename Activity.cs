using System;
using System.Collections.Generic;

namespace TravelTime
{
    public class Activity : Location
    {
        public double Price { get; set; }
        public int Duration { get; set; }
        public int MaximumGuests { get; set; }
        public string HoursOperation { get; set; }

        private List<Tourist> attendees = new List<Tourist>();


        public string Register(
            Tourist registrar,
            int guests,
            DateTime day,
            PaymentTypes payment)
        {
            // Is the tourist already registered?
            if (attendees.Contains(registrar))
            {
                return "You already registered, you idiot.";
            }

            int seatsRemaining = this.MaximumGuests - attendees.Count;



            if (guests + 1 > seatsRemaining) {
                return "There is not enough capacity at this moment. Please try again later.";
            }

            // Store the tourist
            attendees.Add(registrar);

            for (int i = 0; i < guests; i++)
            {
                attendees.Add(new Tourist() { Name = "Guest"});
            }

            // Reduce the maximum amount
            return "h8t9guh24tu9ghtu249hg9tuhgj9ue";
        }

    }
}