using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Repository;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{

    [ApiController]

    [Route("api/korisnik")]
    public class KorisnikController : ControllerBase
    {

        private readonly IKorisnikService _korisnikService;

        public KorisnikController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }


        [HttpGet("{id}")]
        public IActionResult getKorisnik(int id)
        {
            var korisnikDTO = _korisnikService.getKorisnikById();
    }
    }
}

