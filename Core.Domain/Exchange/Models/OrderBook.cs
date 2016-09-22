using Lykke.Core.Domain.Assets.Models;

namespace Lykke.Core.Domain.Exchange.Models
{
    public class OrderBook
    {
        public AssetPair AssetPair { get; set; }

        public double Volume { get; set; }

        public double Price { get; set; }

        public OrderAction OrderAction { get; set; }
    }
}