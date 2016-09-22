using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Exchange.Models;
using Lykke.Core.Domain.Infrasturture;

namespace Lykke.Core.Domain.Exchange
{
    public interface IOrderRepository<T> : IRepository where T : IOrder
    {
        Task<IEnumerable<T>> GetAllAsync(string accountId);

        Task<T> GetAsync(string accountId, string orderId);

        Task DeleteAsync(string accountId, string orderId);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);
    }
}