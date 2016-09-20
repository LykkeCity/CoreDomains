using System.Threading.Tasks;
using Lykke.Core.Domain.Account.Models;
using Lykke.Core.Domain.Infrasturture;

namespace Lykke.Core.Domain.Account
{
    public interface IAccountInfoRepository : IRepository<AccountInfo>
    {
        Task<AccountInfo> GetAsync(string accountId);

        Task UpdateAsync(AccountInfo accountInfo);

        Task AddAsync(AccountInfo accountInfo);
    }
}