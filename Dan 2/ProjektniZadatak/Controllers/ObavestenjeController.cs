using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{

    [ApiController]

    [Route("api/[controller]")]
    public class ObavestenjeController : ControllerBase
    {

        private readonly IObavestenjeService _obavestenjeService;

        public ObavestenjeController (ObavestenjeService obavestenjeService)
        {
            _obavestenjeService = obavestenjeService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObavestenjeGetDetailsResponse>>> Get()
        {
            var result = await _obavestenjeService.GetAsync();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _obavestenjeService.DeleteAsync(id);

            return result == false ? NotFound() : NoContent();
        }
    }
}
