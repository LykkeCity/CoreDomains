using System.Threading.Tasks;
using Lykke.Core.Domain.Assets.Models;

namespace Lykke.Core.Domain.MatchingEngine
{
    public interface IMatchingEngineEvents
    {
        Task AccountUpdatedAsync(string accountId);

        Task AssetPairPriceUpdatedAsync(AssetPairQuote assetPair);

        Task ActiveOrdersUpdatedAsync(string accountId);
    }
}