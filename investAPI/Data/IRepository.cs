using investAPI.Models;

namespace investAPI.Data
{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //STOCK
        Task<Stock[]> GetAllStocksAsync(bool includeSomething);
        Task<Stock[]> GetStocksAsyncBySomethingId(int somethingId, bool includeSomething);
        Task<Stock> GetStockAsyncById(int stockId, bool includeSomething);

        //REIT
        Task<Reit[]> GetAllReitsAsync(bool includeSomething);
        Task<Reit> GetReitAsyncById(int reitId, bool includeSomething);
        //Task<Reit[]> GetReitsAsyncByStockId(int somethingId, bool includeSomething);
    }
}
