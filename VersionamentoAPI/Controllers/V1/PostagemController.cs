using Microsoft.AspNetCore.Mvc;

namespace VersionamentoAPI.Controllers.V1
{
    
    [ApiVersion("1", Deprecated = true)]
    [Route("api/v{version:apiVersion}/Postagens")]
    public class PostagemController : Controller
    {
        [HttpGet]
        public string PegaVersao() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
