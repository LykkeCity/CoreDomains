using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Account.Models;

namespace Lykke.Core.Domain.Account
{
    public interface IAccountInfoRepository
    {
        Task<AccountInfo> GetAsync(string accountId);

        Task UpdateAsync(AccountInfo accountInfo);

        Task AddAsync(AccountInfo accountInfo);

        Task<IEnumerable<AccountInfo>> GetAllAsync();
    }
}