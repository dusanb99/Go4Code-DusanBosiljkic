using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{
    [ApiController]
    [Route("api/objava")]
    public class ObjavaController : ControllerBase
    {
        private readonly IObjavaService _service;

        public ObjavaController(IObjavaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObjaveGetDetailsResponse>>> Get()
        {
            var result = await _service.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ObjaveGetDetailsResponse>> GetDetails(int id)
        {
            var result = await _service.GetDetailsAsync(id);

            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ObjaveGetDetailsResponse>> Post(ObjaveCreateRequest objava)
        {
            var result = await _service.CreateAsync(objava);

            return CreatedAtAction(nameof(GetDetails), new { id = result.Id }, result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            return result ? NoContent() : NotFound();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ObjaveGetDetailsResponse>> Put(int id, ObjaveCreateRequest objava)
        {
            var result = await _service.UpdateAsync(id, objava);

            return result is null ? NotFound() : Ok(result);
        }
    }
}


