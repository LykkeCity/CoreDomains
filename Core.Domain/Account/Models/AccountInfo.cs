using System;

namespace Lykke.Core.Domain.Account.Models
{
    public class AccountInfo
    {
        public string AccountId { get; set; }
        public double Balance { get; set; }
        public string BaseAssetId { get; set; }
        public double Shoulder { get; set; }
    }
}