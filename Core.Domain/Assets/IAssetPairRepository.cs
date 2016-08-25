using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets.Models;

namespace Lykke.Core.Domain.Assets
{
    public interface IAssetPairRepository
    {
        Task<IEnumerable<AssetPair>> GetAllAssetPairsAsync();
    }
}