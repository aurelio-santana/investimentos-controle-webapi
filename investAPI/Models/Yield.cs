namespace investAPI.Models
{
    public class Yield
    {
        public Yield(int id, yieldType yieldType, string ticker,
            double value, double dividendYield, DateTime date)
        {
            this.Id = id;
            this.YieldType = yieldType;
            this.Ticker = ticker;
            //this.Quantity = quantity;
            this.Value = value;
            this.DividendYield = dividendYield;
            this.Date = date;
        }

        public enum yieldType { DIVIDENDO, JCP }

        public int Id { get; set; }
        public yieldType YieldType { get; set; }
        public string Ticker { get; set; }
        //public int Quantity { get; set; }
        public double Value { get; set; }
        public double DividendYield { get; set; }
        public DateTime Date { get; set; }
    }
}
