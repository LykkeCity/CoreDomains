using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets.Models;

namespace Lykke.Core.Domain.Assets
{
    public interface IAssetPairQuoteRepository
    {
        Task<IEnumerable<AssetPairQuote>> GetAllAsync();

        Task<AssetPairQuote> GetAsync(string assertPairId);

        Task AddAllAsync(IEnumerable<AssetPair> assetPairs);

        Task<AssetPairQuote> UpdateAsync(AssetPair assetPair);
    }
}