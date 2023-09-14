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

        private readonly IKorisnikService _korisnikService;

        public KorisnikController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }

        [Authorize(Roles = Roles.Korisnik)]
        [HttpGet]
        
        public IActionResult getAll()
        {
            IEnumerable<KorisnikDTO> korisnici = _korisnikService.getAll();
            return Ok(korisnici);
        }

        [HttpGet]
        [Route("getById/{id}")]

        public IActionResult getById(int id)
        {
            KorisnikDTO korisnik = _korisnikService.getById(id);
            if (korisnik == null)
            {
                return null;
            }
            return Ok(korisnik);
        }

        [HttpPut]
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] KorisnikDTO korisnik)
        {
            if (id != korisnik.id)
            {
                return BadRequest();
            }

            _korisnikService.Update(korisnik);
            return NoContent();
        }

        

    }

}

