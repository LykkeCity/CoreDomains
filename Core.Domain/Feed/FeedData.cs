using System;

namespace Core.Domain.Feed
{
    public class FeedData
    {
        public string Asset { get; set; }
        public DateTime DateTime { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
    }
}