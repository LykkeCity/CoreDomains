namespace Lykke.Core.Domain.Exchange.Models
{
    public class PendingOrder : OrderBase, IOrder
    {
        public double DefinedPrice { get; set; }
    }
}