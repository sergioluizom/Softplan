using GraphQL;
using GraphQL.Client.Abstractions;
using Softplan.Domain.Response;
using Softplan.Domain.Services.Interfaces;
using Softplan.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Softplan.Domain.Services.Implementation
{
    public class CountryService : ICountryService
    {
        private readonly IGraphQLClient _client;
        public CountryService(IGraphQLClient client)
        {
            _client = client;
        }

        public List<Country> Get()
        {
            var query = new GraphQLRequest
            {
                Query = @" query{
Country {
    name
    nativeName
    alpha2Code
    alpha3Code
    area
    population
    populationDensity
    capital
    demonym
    gini
    location {
      latitude
      longitude
    }
    numericCode
    subregion {
      name
      region {
        name
      }
    }
    officialLanguages {
      iso639_1
      iso639_2
      name
      nativeName
    }
    currencies {
      name
      symbol
    }
    regionalBlocs {
      name
      acronym
      otherAcronyms {
        name
      }
      otherNames {
        name
      }
    }
    flag {
      emoji
      emojiUnicode
      svgFile
    }
    topLevelDomains {
      name
    }
    callingCodes {
      name
    }
    alternativeSpellings {
      name
    }
  }}"
            };

            var respone = _client.SendQueryAsync<ResponseCountryCollection>(query).GetAwaiter().GetResult();
            return respone.Data.Country;
        }

        public Country GetByCapital(string capitalName)
        {
            var query = new GraphQLRequest
            {
                Query = @" query CountryQuery($capitalName: String!){
                        Country (capital: $capitalName) {
                            name
 nativeName
    alpha2Code
    alpha3Code
    area
    population
    populationDensity
    capital
                          }}",
                Variables = new { capitalName }
            };

            var respone = _client.SendQueryAsync<ResponseCountryCollection>(query).GetAwaiter().GetResult();
            return respone.Data.Country.FirstOrDefault();
        }

        public Country GetByName(string countryName)
        {
            var query = new GraphQLRequest
            {
                Query = @" query CountryQuery($countryName: String!){
                        Country (name: $countryName) {
                            name
 nativeName
    alpha2Code
    alpha3Code
    area
    population
    populationDensity
    capital
                          }}",
                Variables = new { countryName }
            };

            var respone = _client.SendQueryAsync<ResponseCountryCollection>(query).GetAwaiter().GetResult();
            return respone.Data.Country.FirstOrDefault();
        }
    }
}
