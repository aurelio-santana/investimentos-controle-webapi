namespace investAPI.Models
{
    public class Stock
    {

        //public Stock() { }
        public Stock(int id, string ticker, int quantity, float averagePrice,
            float total, float currentQuote, float profit, int orderType, DateTime date)
        {
            this.Id = id;
            this.Ticker = ticker;
            this.Quantity = quantity;
            this.AveragePrice = averagePrice;
            this.Total = total;
            this.CurrentQuote = currentQuote;
            this.Profit = profit;

            this.OrderType = orderType;
            this.Date = date;
        }

        public int Id { get; set; }
        public string Ticker { get; set; }
        public int Quantity { get; set; }
        public float AveragePrice { get; set; }
        public float Total { get; set; }
        public float CurrentQuote { get; set; }
        public float Profit { get; set; }
        public int OrderType { get; set; }
        public DateTime Date { get; set; }

    }
}
