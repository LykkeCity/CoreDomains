using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Assets.Models;
using Microsoft.ServiceFabric.Actors;

namespace Core.Domain.Dictionary
{
    public interface IDictionaryService : IActor
    {
        Task<IEnumerable<AssetPair>> GetAssetPairsAsync();
    }
}
