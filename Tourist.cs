namespace TravelTime
{
    public class Tourist {
        public string Name { get; set; }
        public string CountryOrigin { get; set; }
        public double Budget { get; set; }

        public double Spend(double amount)
        {
            if (amount > this.Budget)
            {
                return this.Budget;
            }
            this.Budget -= amount;

            return this.Budget;
        }

        public void Travel(
            Activity destination,
            Transportation transport,
            Hotel origin)
        {

        }
    }
}