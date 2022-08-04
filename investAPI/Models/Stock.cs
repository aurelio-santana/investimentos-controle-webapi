namespace investAPI.Models
{
    public class Stock
    {

        public Stock() { }
        public Stock(int id, string ticker, int quantity, float averagePrice,
            float total, float currentQuote, float profit)
        {
            this.id = id;
            this.ticker = ticker;
            this.quantity = quantity;
            this.averagePrice = averagePrice;
            this.total = total;
            this.currentQuote = currentQuote;
            this.profit = profit;
        }

        public int id { get; set; }
        public string ticker { get; set; }
        public int quantity { get; set; }
        public float averagePrice { get; set; }
        public float total { get; set; }
        public float currentQuote { get; set; }
        public float profit { get; set; }
    }
}
