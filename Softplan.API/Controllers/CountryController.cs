using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softplan.Domain.Services.Interfaces;
using Softplan.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Softplan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly ILogger<CountryController> logger;
        public CountryController(ICountryService countryService, ILogger<CountryController> logger)
        {
            _countryService = countryService;
            this.logger = logger;
        }
        // GET: api/<CountryController>
        [HttpGet]
        public ActionResult Get()
        {
            logger.LogInformation("Call CountryController.Get");
            var result = _countryService.Get();
            if (result.Count == 0 || result == null)
                return new NotFoundResult();
            return new OkObjectResult(result);
        }

        // GET: api/GetByName
        [HttpGet]
        [Route("GetByName")]
        public async Task<Country> GetByName([FromQuery] string name)
        {
            logger.LogInformation("Call CountryController.GetByName");
            return await _countryService.GetByName(name);
        }


        // GET: api/GetByCapital
        [HttpGet]
        [Route("GetByCapital")]
        public async Task<Country> GetByCapital([FromQuery] string capital)
        {
            logger.LogInformation("Call CountryController.GetByCapital");
            return await _countryService.GetByCapital(capital);
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public async Task<Country> Get(string id)
        {
            logger.LogInformation($"Call CountryController.Get/{id}");
            return await _countryService.FindById(id);
        }

        // POST api/<CountryController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Country country)
        {
            logger.LogInformation($"Call CountryController.Post");
            try
            {
                if (!country.Validate(country))
                    return new BadRequestObjectResult(ModelState);
                else
                {
                    await _countryService.Add(country);
                    return new OkResult();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<CountryController>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Country country)
        {
            logger.LogInformation($"Call CountryController.Put");
            try
            {
                if (!country.Validate(country))
                    return new BadRequestObjectResult(ModelState);
                else
                {
                    await _countryService.Add(country);
                    return new OkResult();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            logger.LogInformation($"Call CountryController.Delete/{id}");
            try
            {
                return new OkObjectResult(await _countryService.Delete(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
