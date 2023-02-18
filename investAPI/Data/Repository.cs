using investAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace investAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
            // entity se refere as tabelas Stock, Reit etc
        {
            _context.Add(entity);
            // _context é o DataContext passado em Program.cs durante a conexão do banco
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
            // Detecta se houve mudanças no _context (banco)
        }


        /* STOCKS */

        public async Task<Stock[]> GetAllStocksAsync(bool includeSomething = false)
        {
            IQueryable<Stock> query = _context.Stocks;

            //if (includeSomething)
            //{
            //    query = query.Include(pe => pe.StocksSomething)
            //                 .ThenInclude(ad => ad.Something);
            //}

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Stock> GetStockAsyncById(int stockId, bool includeSomething)
        {
            IQueryable<Stock> query = _context.Stocks;

            //if (includeSomething)
            //{
            //    query = query.Include(a => a.StocksSomething)
            //                 .ThenInclude(ad => ad.Something);
            //}

            query = query.AsNoTracking()
                         .OrderBy(s => s.Id)
                         .Where(stock => stock.Id == stockId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Stock[]> GetStocksAsyncBySomethingId(int somethingId, bool includeSomething)
        {
            IQueryable<Stock> query = _context.Stocks;

            //if (includeSomething)
            //{
            //    query = query.Include(p => p.StocksSomething)
            //                 .ThenInclude(ad => ad.Something)
            //}

            //query = query.AsNoTracking()
            //             .OrderBy(stock => stock.Id)
            //             .Where(stock => stock.StocksSomething.Any(ad => ad.SomethingId == somethingId));

            return await query.ToArrayAsync();
        }

        public async Task<Stock[]> GetStocksAsyncByTicker(string stockTicker, bool includeSomething)
        {
            IQueryable<Stock> query = _context.Stocks;

            query = query.AsNoTracking()
                         .OrderBy(stock => stock.Id)
                         .Where(stock => stock.Ticker == stockTicker);

            return await query.ToArrayAsync();
        }


        /* REIT */

        public async Task<Reit[]> GetAllReitsAsync(bool includeSomething = false)
        {
            IQueryable<Reit> query = _context.Reits;

            //if (includeSomething)
            //{
            //    query = query.Include(pe => pe.ReitsSomething)
            //                 .ThenInclude(ad => ad.Something);
            //}

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Reit> GetReitAsyncById(int reitId, bool includeSomething)
        {
            IQueryable<Reit> query = _context.Reits;

            //if (includeSomething)
            //{
            //    query = query.Include(a => a.ReitsSomething)
            //                 .ThenInclude(ad => ad.Something);
            //}

            query = query.AsNoTracking()
                         .OrderBy(reit => reit.Id)
                         .Where(reit => reit.Id == reitId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Reit[]> GetReitsAsyncBySomethingId(int somethingId, bool includeSomething)
        {
            IQueryable<Reit> query = _context.Reits;

            //if (includeSomething)
            //{
            //    query = query.Include(p => p.ReitsSomething)
            //                 .ThenInclude(ad => ad.Something)
            //}

            //query = query.AsNoTracking()
            //             .OrderBy(reit => reit.Id)
            //             .Where(reit => reit.ReitsSomething.Any(ad => ad.SomethingId == somethingId));

            return await query.ToArrayAsync();
        }

        //Cálculo de soma de assets passado para o front
        //public async Task<Reit[]> GetReitsAsyncByTicker(string reitTicker, bool includeSomething)
        //{
        //    IQueryable<Reit> query = _context.Reits;

        //    query = query.AsNoTracking()
        //                 .OrderBy(reit => reit.Id)
        //                 .Where(reit => reit.Ticker == reitTicker);

        //    return await query.ToArrayAsync();

        //}

    }
}
