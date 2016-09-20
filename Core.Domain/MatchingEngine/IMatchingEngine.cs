using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Account.Models;
using Lykke.Core.Domain.Assets.Models;
using Lykke.Core.Domain.Exchange.Models;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.MatchingEngine
{
    public interface IMatchingEngine : IActor
    {
        Task InitAsync();

        Task SubscribeAsync(string subscriberName);

        Task<AccountInfo> GetAccountInfoAsync(string accountId);

        Task OpenOrderAsync(string accountId, string assetPairId, double volume, double definedPrice);

        Task CloseOrderAsync(string accountId, string orderId);

        Task<IEnumerable<OrderInfo>> GetActiveOrdersAsync(string accountId);

        Task<IEnumerable<AssetPairQuote>> GetMarketProfileAsync();
    }
}