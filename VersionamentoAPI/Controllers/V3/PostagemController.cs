﻿using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V3
{
    
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/Postagens")]
    public class PostagemController : Controller
    {
        [HttpGet]
        public string PegaVersao() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
