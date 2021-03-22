using Microsoft.AspNetCore.Mvc;

namespace VersionamentoAPI.Controllers.V2
{
    
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/Postagens")]
    public class PostagemController : Controller
    {
        [HttpGet]
        public string PegaVersao() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
