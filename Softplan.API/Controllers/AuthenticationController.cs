using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softplan.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate()
        {
            try
            {
                logger.LogInformation("Chamada de Authentication.Authenticate");

                // Gera o Token
                var token = tokenService.GenerateToken();

                // Retorna os dados
                return new { token = token };
            }
            catch (Exception ex)
            {
                logger.LogError("Erro ao autenticar", ex);
                return BadRequest();
            }
        }
    }
}
