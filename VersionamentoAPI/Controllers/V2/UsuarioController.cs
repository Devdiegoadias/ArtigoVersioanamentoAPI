using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V2
{
    [ApiVersion("2")]    
    [Route("api/v{version:apiVersion}/usuarios")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public string PegaVersao() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
