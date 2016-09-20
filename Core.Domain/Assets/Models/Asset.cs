namespace Lykke.Core.Domain.Assets.Models
{
    public class Asset
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public string IdIssuer { get; set; }

        public int Accuracy { get; set; }

        public double Multiplier { get; set; }

        public double DustLimit { get; set; }
    }
}