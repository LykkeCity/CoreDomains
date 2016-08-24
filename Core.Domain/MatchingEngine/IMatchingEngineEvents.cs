using Core.Domain.Assets.Models;
using Core.Domain.Feed;
using Microsoft.ServiceFabric.Actors;

namespace Core.Domain.MatchingEngine
{
    public interface IMatchingEngineEvents : IActorEvents
    {
        void BalanceUpdated(double balance);

        void AssetPairPriceUpdated(FeedData assetPair);
    }
}