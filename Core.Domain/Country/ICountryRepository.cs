using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Country.Models;
using Lykke.Core.Domain.Infrasturture;

namespace Lykke.Core.Domain.Country
{
    public interface ICountryRepository : IRepository
    {
        Task<IEnumerable<CountryItem>> GetAllAsync(string language);

        Task<CountryItem> GetAsync(string language, string iso3);
    }
}