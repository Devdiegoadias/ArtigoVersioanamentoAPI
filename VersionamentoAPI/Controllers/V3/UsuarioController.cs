using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V3
{
    [ApiVersion("3")]    
    [Route("api/v{version:apiVersion}/usuarios")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public string PegaVersao() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
