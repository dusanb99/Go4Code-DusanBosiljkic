using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Repository;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{
    [ApiController]
    [Route("api/lajk")]
    public class LajkController : ControllerBase
    {

        private readonly ILajkService _lajkService;

        public LajkController(ILajkService lajkService) 
        {
            _lajkService = lajkService;
        }
    }
}
