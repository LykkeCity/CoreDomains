using Lykke.Core.Domain.Assets.Models;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.MatchingEngine
{
    public interface IMatchingEngineEvents : IActorEvents
    {
        void BalanceUpdated(double balance);

        void AssetPairPriceUpdated(AssetPairQuote assetPair);
    }
}