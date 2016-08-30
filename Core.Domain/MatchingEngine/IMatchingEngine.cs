using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Account.Models;
using Lykke.Core.Domain.Assets.Models;
using Lykke.Core.Domain.Exchange.Models;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.MatchingEngine
{
    public interface IMatchingEngine : IActor, IActorEventPublisher<IMatchingEngineEvents>
    {
        Task InitAsync();

        Task<AccountInfo> GetAccountInfoAsync(string accountId);

        Task OpenOrderAsync(string accountId, string assetPairId, double volume);

        Task CloseOrderAsync(string accountId, string orderId);

        Task<IEnumerable<OrderInfo>> GetActiveOrdersAsync(string accountId);

        Task<IEnumerable<AssetPairQuote>> GetMarketProfile();
    }
}