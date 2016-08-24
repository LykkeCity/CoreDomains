using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Assets.Models;

namespace Core.Domain.Assets
{
    public interface IAssetPairRepository
    {
        Task<IEnumerable<AssetPair>> GetAllAssetPairsAsync();
    }
}