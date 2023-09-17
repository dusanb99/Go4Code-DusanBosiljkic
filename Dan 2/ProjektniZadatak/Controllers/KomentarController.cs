using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{

    [ApiController]
    [Route("api/komentar")]
    public class KomentarController : ControllerBase
    {

        private readonly IKomentarService _komentarService;

        public KomentarController (IKomentarService komentarService)
        {
            _komentarService = komentarService; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<KomentarGetDetailsResponse>>> Get()
        {
            var result = await _komentarService.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<KomentarGetDetailsResponse>> GetDetails(int id)
        {
            var result = await _komentarService.GetDetailsAsync(id);

            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<KomentarGetDetailsResponse>> Post(KomentarCreateRequest komentar)
        {
            var result = await _komentarService.CreateAsync(komentar);

            return CreatedAtAction(nameof(GetDetails), new { id = result.Id }, result);
        }

        
        

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _komentarService.DeleteAsync(id);

            return result ? NoContent() : NotFound();
        }


    }
}
