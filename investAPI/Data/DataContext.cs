using investAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace investAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Reit> Reits { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Stock>()
                .HasData(new List<Stock>(){
                    //id, ticker, quantity, averagePrice, total, quote, profit
                    new Stock(1, "CEMIG3 api", 2, 10, 20, 15, 105),
                    new Stock(2, "WEG3", 2, 10, 20, 15, 10),
                });
            builder.Entity<Reit>()
                .HasData(new List<Reit>(){
                    //id, ticker, quantity, averagePrice, total, quote, profit
                    new Reit(1, "MXRF11", 2, 10, 20, 15, 10),
                    new Reit(2, "HGLG11", 2, 10, 20, 15, 10),
                });

        }
    }
}
