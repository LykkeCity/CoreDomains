using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Country.Models;

namespace Lykke.Core.Domain.Country
{
    public interface ICountryRepository
    {
        Task<IEnumerable<CountryItem>> GetAllAsync(string language);

        Task<CountryItem> GetAsync(string language, string iso3);
    }
}