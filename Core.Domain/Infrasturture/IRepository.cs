using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Core.Domain.Infrasturture
{
    public interface IRepository<T> : IRepository
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeteleAsync(string id);

        Task<T> GetByIdAsync(string id);
    }

    public interface IRepository
    {
    }
}