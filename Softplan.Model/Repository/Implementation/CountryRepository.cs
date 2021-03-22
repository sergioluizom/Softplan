using Softplan.Domain.Repository.Interfaces;
using Softplan.Model.Entities;
using System.Collections.Generic;
using System.Linq;
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

            return await Task.FromResult(context.SaveChanges() > 0);
        }
        public async Task<bool> Delete(string id)
        {
            var country = await FindById(id);
            context.Countrys.Remove(country);
            return await Task.FromResult(context.SaveChanges() > 0);
        }
        public async Task<Country> FindById(string id)
        {
            return await Task.FromResult(context.Countrys.Find(id));
        }

        public async Task<List<Country>> Get()
        {
            return await Task.FromResult(context.Countrys.ToList());
        }

        public async Task<bool> Update(Country country)
        {
            context.Countrys.Update(country);
            return await Task.FromResult(context.SaveChanges() > 0);
        }
    }
}
