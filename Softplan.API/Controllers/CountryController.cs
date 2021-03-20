using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        // GET: api/<CountryController>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _countryService.Get();
        }

        // GET: api/GetByName
        [HttpGet]
        [Route("GetByName")]
        public async Task<Country> GetByName([FromQuery] string name)
        {
            return await _countryService.GetByName(name);
        }


        // GET: api/GetByCapital
        [HttpGet]
        [Route("GetByCapital")]
        public async Task<Country> GetByCapital([FromQuery] string capital)
        {
            return await _countryService.GetByCapital(capital);
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public async Task<Country> Get(string id)
        {
            return await _countryService.FindById(id);
        }

        // POST api/<CountryController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Country country)
        {
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
