using Lykke.Core.Domain.Feed;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.MatchingEngine
{
    public interface IMatchingEngineEvents : IActorEvents
    {
        void BalanceUpdated(double balance);

        void AssetPairPriceUpdated(FeedData assetPair);
    }
}