using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Repository;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{
    [ApiController]
    [Route("api/lajk")]
    public class LajkController : ControllerBase
    {

        private readonly LajkService _lajkService;

        public LajkController(LajkService lajkService) 
        {
            _lajkService = lajkService;
        }
    }
}
