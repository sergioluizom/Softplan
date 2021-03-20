using Softplan.Model.Entities;
using System.Threading.Tasks;

namespace Softplan.Domain.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<bool> Add(Country country);
        Task<bool> Update(Country country);
        Task<bool> Delete(string id);
        Task<Country> FindById(string id);
    }
}
