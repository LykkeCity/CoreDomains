using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Exchange.Models;

namespace Lykke.Core.Domain.Exchange
{
    public interface IPendingOrderRepository : IOrderRepository<PendingOrder>
    {
        Task AddAsync(string accountId, string assetPairId, double volume, double definedPrice);

        Task<IEnumerable<PendingOrder>> FindByAssetPairIdAsync(string assetPairId);
    }
}