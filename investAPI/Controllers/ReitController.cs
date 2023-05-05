using investAPI.Data;
using investAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace investAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReitController : ControllerBase
    {
        private readonly IRepository _repo;
        public ReitController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllReitsAsync(true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }

        [HttpGet("{reitId}")]
        public async Task<IActionResult> GetByReitId(int reitId)
        {
            try
            {
                var result = await _repo.GetReitAsyncById(reitId, true);
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
                var result = await _repo.GetReitsAsyncBySomethingId(somethingId, true);
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
        public async Task<IActionResult> post(Reit model)
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

        [HttpPut("{reitId}")]
        public async Task<IActionResult> put(int reitId, Reit model)
        {
            try
            {
                var reit = await _repo.GetReitAsyncById(reitId, false);
                if (reit == null) return NotFound();

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

        [HttpDelete("{reitId}")]
        public async Task<IActionResult> delete(int reitId)
        {
            try
            {
                var reit = await _repo.GetReitAsyncById(reitId, false);
                if (reit == null) return NotFound();

                _repo.Delete(reit);

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
