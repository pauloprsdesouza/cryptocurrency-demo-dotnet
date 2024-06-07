﻿using Cryptocurrency.Quotation.Contracts.CryptoStatus;
using System;
using System.Collections.Generic;

namespace Cryptocurrency.Quotation.Contracts.Quotations
{
    public class CryptoQuotationResponse
    {
        public Dictionary<string, List<CoinDetailResponse>> Data { get; set; }

        public StatusResponse Status { get; set; }
    }

    public class CoinDetailResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public string Slug { get; set; }

        public int IsActive { get; set; }

        public int IsFiat { get; set; }

        public double CirculatingSupply { get; set; }

        public double TotalSupply { get; set; }

        public double? MaxSupply { get; set; } = null;

        public DateTime DateAdded { get; set; }

        public int NumMarketPairs { get; set; }

        public int CmcRank { get; set; }

        public DateTime LastUpdated { get; set; }

        public object Platform { get; set; }

        public object SelfReportedCirculatingSupply { get; set; }

        public object SelfReportedMarketCap { get; set; }

        public Dictionary<string, QuoteDetailResponse> Quote { get; set; }
    }

    public class QuoteDetailResponse
    {
        public double Price { get; set; }

        public double Volume24h { get; set; }

        public double VolumeChange24h { get; set; }

        public double PercentChange1h { get; set; }

        public double PercentChange24h { get; set; }

        public double PercentChange7d { get; set; }

        public double PercentChange30d { get; set; }

        public double MarketCap { get; set; }

        public double MarketCapDominance { get; set; }

        public double FullyDilutedMarketCap { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
