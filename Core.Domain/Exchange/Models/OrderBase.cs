using System;

namespace Lykke.Core.Domain.Exchange.Models
{
    public class OrderBase
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public string AssetPairId { get; set; }

        public OrderAction OrderAction => this.Volume > 0 ? OrderAction.Buy : OrderAction.Sell;
    }
}