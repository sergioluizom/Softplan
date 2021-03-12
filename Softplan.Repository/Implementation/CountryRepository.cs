using Softplan.Model.Entities;
using Softplan.Repository.Interfaces;
using System.Threading.Tasks;

namespace Softplan.Repository.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        public Task<bool> Add(Country country)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AddV2(CountryV2 country)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Country> FindById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CountryV2> FindByIdV2(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Country country)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateV2(CountryV2 country)
        {
            throw new System.NotImplementedException();
        }
    }
}
