using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Softplan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public ConfigController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Obter url do repositório da API
        /// </summary>
        /// <returns>Url repositório</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("GetGitRepositoryApi")]        
        public Task<string> GetGitRepositoryApi()
        {
            return Task.FromResult<string>(configuration["gitProjectApi"]);
        }

        /// <summary>
        /// Obter url do repositório do Front
        /// </summary>
        /// <returns>Url repositório</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("GetGitRepositoryFront")]
        public Task<string> GetGitRepositoryFront()
        {
            return Task.FromResult<string>(configuration["gitProjectFront"]);
        }
    }
}
