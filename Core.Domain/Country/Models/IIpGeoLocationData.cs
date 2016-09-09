namespace Lykke.Core.Domain.Country.Models
{
    public interface IIpGeoLocationData
    {
        string CountryCode { get; }

        string Isp { get; }

        string Ip { get; }

        string City { get; }

        string Region { get; }

        string Longitude { get; }

        string Latitude { get; }
    }
}