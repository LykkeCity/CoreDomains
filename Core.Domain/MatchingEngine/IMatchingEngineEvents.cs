using Lykke.Core.Domain.Assets.Models;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.MatchingEngine
{
    public interface IMatchingEngineEvents : IActorEvents
    {
        void AccountUpdated(string accountId);

        void AssetPairPriceUpdated(AssetPairQuote assetPair);
    }
}