using System.Runtime.Serialization;

namespace Lykke.Core.Domain.Country.Models
{
    [DataContract]
    public class IpGeoLocationData : IIpGeoLocationData
    {
        [DataMember]
        public string CountryCode { get; set; }
        
        [DataMember]
        public string Isp { get; set; }

        [DataMember]
        public string Ip { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Region { get; set; }

        [DataMember]
        public string Longitude { get; set; }

        [DataMember]
        public string Latitude { get; set; }
    }
}