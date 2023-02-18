using investAPI.Data;
using investAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace investAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {

        private readonly IRepository _repo;
        public StockController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllStocksAsync(true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            
        }

        [HttpGet("{stockId}")]
        public async Task<IActionResult> GetByStockId(int stockId)
        {
            try
            {
                var result = await _repo.GetStockAsyncById(stockId, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpGet("BySomething/{somethingId}")]
        public async Task<IActionResult> GetBySomethingId(int somethingId)
        {
            try
            {
                var result = await _repo.GetStocksAsyncBySomethingId(somethingId, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        //Cálculo de soma de assets passado para o front
        //[HttpGet("Operations/{stockTicker}")]
        //public async Task<IActionResult> GetByTicker(string stockTicker)
        //{
        //    try
        //    {
        //        var result = await _repo.GetStocksAsyncByTicker(stockTicker, true);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest($"Erro: {ex.Message}");
        //    }

        //}

        [HttpPost]
        public async Task<IActionResult> post(Stock model)
        {
            try
            {
                _repo.Add(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();

        }

        [HttpPut("{stockId}")]
        public async Task<IActionResult> put(int stockId, Stock model)
        {
            try
            {
                var stock = await _repo.GetStockAsyncById(stockId, false);
                if (stock == null) return NotFound();

                _repo.Update(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();

        }

        [HttpDelete("{stockId}")]
        public async Task<IActionResult> delete(int stockId)
        {
            try
            {
                var stock = await _repo.GetStockAsyncById(stockId, false);
                if (stock == null) return NotFound();

                _repo.Delete(stock);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok();
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();

        }
    }
}
