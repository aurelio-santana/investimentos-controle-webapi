using investAPI.Data;
using investAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace investAPI.Controllers
{
    public class YieldController : Controller
    {
        private readonly IRepository _repo;
        public YieldController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllYieldsAsync(true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpGet("{yieldId}")]
        public async Task<IActionResult> GetByYieldId(int yieldId)
        {
            try
            {
                var result = await _repo.GetYieldAsyncById(yieldId, true);
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
                var result = await _repo.GetYieldsAsyncBySomethingId(somethingId, true);
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
        public async Task<IActionResult> post(Yield model)
        {
            try
            {
                _repo.Add(model);

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

        [HttpPut("{yieldId}")]
        public async Task<IActionResult> put(int yieldId, Yield model)
        {
            try
            {
                var yield = await _repo.GetYieldAsyncById(yieldId, false);
                if (yield == null) return NotFound();

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

        [HttpDelete("{yieldId}")]
        public async Task<IActionResult> delete(int yieldId)
        {
            try
            {
                var yield = await _repo.GetYieldAsyncById(yieldId, false);
                if (yield == null) return NotFound();

                _repo.Delete(yield);

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
