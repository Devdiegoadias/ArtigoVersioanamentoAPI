using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V1

{
    [ApiVersion("1", Deprecated = true)]    
    [Route("api/v{version:apiVersion}/usuarios")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public string PegaVersao() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
