using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{

    [ApiController]

    [Route("api/[controller]")]
    public class KorisnikController : ControllerBase
    {

        private readonly IKorisnikService _service;
        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }

        //[Authorize(Roles = Roles.Korisnik)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KorisniciGetDetailsResponse>>> Get()
        {
            var result = await _service.GetAsync();
            return Ok(result);
        }

        //[Authorize(Roles = Roles.Korisnik)]
        [HttpGet("{id}")]
        public async Task<ActionResult<KorisniciGetDetailsResponse>> GetDetails(int id)
        {
            var result = await _service.GetDetailsAsync(id);

            return result is null ? NotFound() : Ok(result);
        }

        //[Authorize(Roles = Roles.Admin)]
        [HttpPost]
        public async Task<ActionResult<KorisniciGetDetailsResponse>> Post(KorisniciCreateRequest book)
        {
            var result = await _service.CreateAsync(book);

            return CreatedAtAction(nameof(GetDetails), new { id = result.Id }, result);
        }

        //[Authorize(Roles = Roles.Admin)]
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            return result == false ? NotFound() : NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Korisnik>> Put(int id, KorisniciCreateRequest updatedKorisnik)
        {
            var result = await _service.UpdateAsync(id, updatedKorisnik);

            if (result == null)
            {
                return NotFound(); // Korisnik sa datim ID-om nije pronađen
            }

            return Ok(result); // Vratite ažuriranog korisnika
        }
    }


}



