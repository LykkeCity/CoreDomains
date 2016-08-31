using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Exchange.Models;

namespace Lykke.Core.Domain.Exchange
{
    public interface ITransactionHistoryRepository
    {
        Task AddAsync(TransactionHistory transactionHistory);

        Task<IEnumerable<TransactionHistory>> GetAllAsync(string accountId);
    }
}