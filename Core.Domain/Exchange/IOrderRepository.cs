using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Exchange.Models;

namespace Lykke.Core.Domain.Exchange
{
    public interface IOrderRepository<T> where T : IOrder
    {
        Task AddAsync(string accountId, string assetPairId, double volume);

        Task<IEnumerable<T>> GetAllAsync(string accountId);

        Task<T> GetAsync(string accountId, string orderId);

        Task DeleteAsync(string accountId, string orderId);
    }
}