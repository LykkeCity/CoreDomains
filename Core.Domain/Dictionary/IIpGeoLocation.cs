using System.Threading.Tasks;
using Lykke.Core.Domain.Country.Models;
using Microsoft.ServiceFabric.Actors;

namespace Lykke.Core.Domain.Dictionary
{
    public interface IIpGeoLocation : IActor
    {
        Task<IpGeoLocationData> GetCountryByIp(string ip, string language);
    }
}