using System;

namespace Lykke.Core.Domain.Exchange.Models
{
    public class TransactionHistory
    {
        public string AccountId { get; set; }
        public string TransactionId { get; set; }
        public string AssetPairId { get; set; }
        public DateTime CompletedAt { get; set; }
        public double ProfitLoss { get; set; }
        public double Price { get; set; }
    }
}