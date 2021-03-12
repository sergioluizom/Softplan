using Softplan.Model.Entities;
using System.Threading.Tasks;

namespace Softplan.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<bool> Add(Country country);
        Task<bool> AddV2(CountryV2 country);
        Task<bool> Update(Country country);
        Task<bool> UpdateV2(CountryV2 country);
        Task<bool> Delete(string id);
        Task<Country> FindById(string id);
        Task<CountryV2> FindByIdV2(string id);

    }
}
