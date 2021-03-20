using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softplan.Domain.Services.Interfaces;
using System;

namespace Softplan.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> logger;
        private readonly ITokenService tokenService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="antiCSRFService"></param>
        /// <param name="logger"></param>
        public AuthenticationController(ILogger<AuthenticationController> logger, ITokenService tokenService)
        {
            this.logger = logger;
            this.tokenService = tokenService;
        }

        [HttpGet]
        [Route("GetToken")]
        public ActionResult<dynamic> GetToken()
        {
            try
            {
                logger.LogInformation("Chamada de Authentication.GetToken");
                // Gera o Token
                return tokenService.GenerateToken();
            }
            catch (Exception ex)
            {
                logger.LogError("Erro ao autenticar", ex);
                return BadRequest();
            }
        }
    }
}
