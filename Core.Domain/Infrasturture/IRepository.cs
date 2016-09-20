using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Core.Domain.Infrasturture
{
    public interface IRepository<T> : IRepository
    {
        Task<IEnumerable<T>> GetAllAsync();
    }

    public interface IRepository
    {
    }
}