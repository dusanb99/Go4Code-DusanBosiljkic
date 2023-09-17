using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{
    [ApiController]
    [Route("api/lajk")]
    
    public class LajkController : ControllerBase
    {
        private readonly ILajkService _service;

        public LajkController(ILajkService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LajkGetDetailsResponse>>> Get()
        {
            var result = await _service.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LajkGetDetailsResponse>> GetDetails(int id)
        {
            var result = await _service.GetDetailsAsync(id);

            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<LajkGetDetailsResponse>> Post(LajkCreateRequest lajk)
        {
            var result = await _service.CreateAsync(lajk);

            return CreatedAtAction(nameof(GetDetails), new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            return result == false ? NotFound() : NoContent();
        }
    }
}

