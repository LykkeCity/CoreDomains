using System;

namespace Lykke.Core.Domain.Assets.Models
{
    public class AssetPairQuote
    {
        public string AssetPairId { get; set; }
        public DateTime DateTime { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
    }
}