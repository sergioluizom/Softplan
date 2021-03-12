using Microsoft.Extensions.Configuration;
using Softplan.Model.Entities;
using System.Collections.Generic;

namespace Softplan.Infra
{
    public class Context
    {
        private readonly IConfiguration configuration;

        public Context(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Country> Countrys { get; set; }
        public IEnumerable<CountryV2> CountrysV2 { get; set; }
    }
}
