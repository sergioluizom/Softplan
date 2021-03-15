using Softplan.Model.Entities;
using Softplan.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Softplan.Domain.Repository.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        private readonly Context context;
        public CountryRepository(Context context)
        {
            this.context = context;
        }
        public async Task<bool> Add(Country country)
        {
            context.Countrys.Add(country);
            return await context.SaveChangesAsync() > 0;
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
