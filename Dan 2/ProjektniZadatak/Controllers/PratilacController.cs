using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{

    [ApiController]

    [Route("api/[controller]")]
    public class PratilacController : ControllerBase
    {
        private readonly PratilacService _pratilacService;

        public PratilacController (PratilacService pratilacService)
        {
            _pratilacService = pratilacService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PratilacGetDetailsResponse>>> Get()
        {
            var result = await _pratilacService.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PratilacGetDetailsResponse>> GetDetails(int id)
        {
            var result = await _pratilacService.GetDetailsAsync(id);

            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<PratilacGetDetailsResponse>> Post(PratilacCreateRequest pratilac)
        {
            var result = await _pratilacService.CreateAsync(pratilac);

            return CreatedAtAction(nameof(GetDetails), new { id = result.Id }, result);
        }

    }
}
