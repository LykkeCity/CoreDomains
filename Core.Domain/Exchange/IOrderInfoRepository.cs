using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Exchange.Models;

namespace Lykke.Core.Domain.Exchange
{
    public interface IOrderInfoRepository
    {
        Task AddAsync(string accountId, string assetPairId, double volume);

        Task<IEnumerable<OrderInfo>> GetAllAsync(string accountId);

        Task DeleteAsync(string orderId);
    }
}