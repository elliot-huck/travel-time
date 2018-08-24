using System;

namespace TravelTime
{
    public class Transportation
    {
        public string Type { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }

        public string Register (Tourist registrar,
            int guests,
            DateTime day,
            PaymentTypes payment)
        {
            return "You are all set";
        }
    }
}