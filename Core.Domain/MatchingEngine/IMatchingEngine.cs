using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.MatchingEngine
{
    public interface IMatchingEngine : IActor, IActorEventPublisher<IMatchingEngineEvents>
    {
        Task InitAsync();
    }
}