using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Exchange.Models;
using Lykke.Core.Domain.Infrasturture;

namespace Lykke.Core.Domain.Exchange
{
    public interface ITransactionHistoryRepository : IRepository
    {
        Task AddAsync(TransactionHistory transactionHistory);

        Task<IEnumerable<TransactionHistory>> GetAllAsync(string accountId);
    }
}