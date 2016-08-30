using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets.Models;
using Lykke.Core.Domain.Exchange.Models;

namespace Lykke.Core.Domain.Exchange
{
    public interface ITransactionHistoryRepository
    {
        Task AddAsync(OrderInfo orderInfo, AssetPairQuote currentQuote);

        Task<IEnumerable<TransactionHistory>> GetAllAsync(string accountId);
    }
}