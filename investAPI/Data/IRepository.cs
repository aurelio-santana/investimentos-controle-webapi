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
        Task<Stock[]> GetStocksAsyncByTicker(string ticker, bool includeSomething);

        //REIT
        Task<Reit[]> GetAllReitsAsync(bool includeSomething);
        Task<Reit[]> GetReitsAsyncBySomethingId(int somethingId, bool includeSomething);
        Task<Reit> GetReitAsyncById(int reitId, bool includeSomething);
        Task<Reit[]> GetReitsAsyncByTicker(string ticker, bool includeSomething);
        //Task<Reit[]> GetReitsAsyncByStockId(int somethingId, bool includeSomething);

        //Cálculo de soma de assets passado para o front
        //Task<Reit[]> GetReitsAsyncByTicker(string ticker, bool includeSomething);

        //YIELD
        Task<Yield[]> GetAllYieldsAsync(bool includeSomething);
        Task<Yield[]> GetYieldsAsyncBySomethingId(int somethingId, bool includeSomething);
        Task<Yield> GetYieldAsyncById(int yieldId, bool includeSomething);
        Task<Yield[]> GetYieldsAsyncByTicker(string ticker, bool includeSomething);
    }
}
