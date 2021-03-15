using Softplan.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Softplan.Domain.Services.Interfaces
{
    public interface ICountryService
    {
        List<Country> Get();
        Country GetByName(string name);
        Country GetByCapital(string capital);
        Task<bool> Add(Country country);
    }
}
