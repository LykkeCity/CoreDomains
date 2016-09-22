using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Exchange.Models;

namespace Lykke.Core.Domain.Exchange
{
    public interface IPendingOrderRepository : IOrderRepository<PendingOrder>
    {
        Task<IEnumerable<PendingOrder>> FindByAssetPairIdAsync(string assetPairId);
    }
}