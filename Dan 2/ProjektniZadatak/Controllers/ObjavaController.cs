using Microsoft.AspNetCore.Mvc;
using ProjektniZadatak.Services;

namespace ProjektniZadatak.Controllers
{
    [ApiController]
    [Route("api/objava")]
    public class ObjavaController : ControllerBase
    {
        private readonly IObjavaService _objavaService;

        public ObjavaController(IObjavaService objavaService)
        {
            _objavaService = objavaService;
        }
    }
}
