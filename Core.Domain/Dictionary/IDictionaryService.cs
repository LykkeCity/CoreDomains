using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Core.Domain.Assets.Models;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.Dictionary
{
    public interface IDictionaryService : IActor
    {
        Task<IEnumerable<AssetPair>> GetAssetPairsAsync();
    }
}
