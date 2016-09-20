using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets.Models;
using Lykke.Core.Domain.Country.Models;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.Dictionary
{
    public interface IDictionaryService : IActor
    {
        Task<IEnumerable<AssetPair>> GetAssetPairsAsync();

        Task<IEnumerable<CountryItem>> GetCountriesAsync(string language);

        Task<IEnumerable<AssetPair>> GetMarginalAssetPairsAsync();

        Task<IEnumerable<Issuer>> GetMarginalIssuersAsync();

        Task<IEnumerable<Asset>> GetMarginalAssetsAsync();
    }
}
