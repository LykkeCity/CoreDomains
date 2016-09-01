using System;

namespace Lykke.Core.Domain.Exchange.Models
{
    public interface IOrder
    {
        string Id { get; set; }
        string ClientId { get; set; }
        DateTime CreatedAt { get; set; }
        double Volume { get; set; }
        string AssetPairId { get; set; }
    }
}