using Softplan.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Softplan.Domain.Services.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> Get();
        Task<Country> GetByName(string name);
        Task<Country> GetByCapital(string capital);
        Task<bool> Add(Country country);
        Task<bool> Update(Country country);
        Task<bool> Delete(string id);
        Task<Country> FindById(string id);
    }
}
