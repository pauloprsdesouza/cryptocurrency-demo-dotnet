using Cryptocurrency.Quotation.Domain.CryptoStatus;
using System;
using System.Collections.Generic;

namespace Cryptocurrency.Quotation.Domain.Cryptocurrencies
{
    public class CryptoInfo
    {
        public Dictionary<string, List<CoinData>> Data { get; set; }

        public Status Status { get; set; }
    }

    public class CoinData
    {
        public Urls Urls { get; set; }

        public string Logo { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateLaunched { get; set; }

        public List<string> Tags { get; set; }

        public object Platform { get; set; }

        public string Category { get; set; }

        public string Notice { get; set; }

        public object SelfReportedCirculatingSupply { get; set; }

        public object SelfReportedMarketCap { get; set; }

        public object SelfReportedTags { get; set; }

        public bool InfiniteSupply { get; set; }
    }

    public class Urls
    {
        public List<string> Website { get; set; }

        public List<string> TechnicalDoc { get; set; }

        public List<string> Twitter { get; set; }

        public List<string> Reddit { get; set; }

        public List<string> MessageBoard { get; set; }

        public List<string> Announcement { get; set; }

        public List<string> Chat { get; set; }

        public List<string> Explorer { get; set; }

        public List<string> SourceCode { get; set; }
    }
}
