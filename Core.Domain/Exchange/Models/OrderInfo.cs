using System;

namespace Lykke.Core.Domain.Exchange.Models
{
    public class OrderInfo
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public string AssetPairId { get; set; }

        public static OrderAction OrderAction(OrderInfo orderBase)
        {
            return orderBase.Volume > 0 ? Models.OrderAction.Buy : Models.OrderAction.Sell;
        }
    }
}