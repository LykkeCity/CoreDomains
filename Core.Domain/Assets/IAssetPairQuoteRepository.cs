using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets.Models;
using Lykke.Core.Domain.Infrasturture;

namespace Lykke.Core.Domain.Assets
{
    public interface IAssetPairQuoteRepository : IRepository<AssetPairQuote>
    {
        Task AddAllAsync(IEnumerable<AssetPair> assetPairs);

        Task<AssetPairQuote> UpdateAsync(AssetPair assetPair);
    }
}