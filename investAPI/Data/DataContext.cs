using investAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace investAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Reit> Reits { get; set; }
        public DbSet<Yield> Yields { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Stock>()
                .HasData(new List<Stock>(){
                    //id, ticker, quantity, averagePrice, total, quote, profit, orderType, date
                    new Stock(1, "CEMIG3 api", 2, 10, 20, 15, 105, 1, new DateTime (2001,11,10)),
                    new Stock(2, "WEG3", 2, 10, 20, 15, 10, 1, new DateTime(2001,11,10))
                });
            builder.Entity<Reit>()
                .HasData(new List<Reit>(){
                    //id, ticker, quantity, averagePrice, total, quote, profit, orderType, date
                    new Reit(1, "MXRF11", 2, 10, 20, 15, 10, 1, new DateTime (2001,11,10)),
                    new Reit(2, "HGLG11", 2, 10, 20, 15, 10, 1, new DateTime (2001,11,10)),
                });
            builder.Entity<Yield>()
                .HasData(new List<Yield>(){
                    //id, tipo, ticker, value, dy, date
                    new Yield(1, Models.Yield.yieldType.DIVIDENDO, "MXRF11", 2.5, 0.6, new DateTime (2001,11,10)),
                    new Yield(2, Models.Yield.yieldType.DIVIDENDO, "HGLG11", 1.8, 0.4, new DateTime (2001,11,10)),
                });

        }
    }
}
