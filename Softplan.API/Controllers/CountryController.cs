using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Softplan.Domain.Services.Interfaces;
using Softplan.Model.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
        public Country GetByName([FromQuery] string name)
        {
            return _countryService.GetByName(name);
        }


        // GET: api/GetByCapital
        [HttpGet]
        [Route("GetByCapital")]
        public Country GetByCapital([FromQuery] string capital)
        {
            return _countryService.GetByCapital(capital);
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CountryController>
        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody] Country country)
        {
            try
            {
                await _countryService.Add(country);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
