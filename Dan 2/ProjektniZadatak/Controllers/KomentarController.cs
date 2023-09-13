using Microsoft.AspNetCore.Mvc;
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

        
    }
}
