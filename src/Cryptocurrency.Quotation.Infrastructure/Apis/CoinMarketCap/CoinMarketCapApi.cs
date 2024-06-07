using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap;
using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap.Models;
using Cryptocurrency.Quotation.Infrastructure.Serialization;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Infrastructure.Apis.CoinMarketCap
{
    public class CoinMarketCapApi : ICoinMarketCapApi
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CoinMarketCapApi> _logger;

        public CoinMarketCapApi(IHttpClientFactory httpClientFactory, ILogger<CoinMarketCapApi> logger)
        {
            _httpClient = httpClientFactory.CreateClient("CoinMarketCapApi");
            _logger = logger;
        }
        public async Task<CryptoInfoModel> GetCryptoInfo(string symbol)
        {
            try
            {
                var response = await _httpClient.GetAsync($"v2/cryptocurrency/info?symbol={symbol}");
                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadAsStringAsync();

                CryptoInfoModel model = JsonSerializer.Deserialize<CryptoInfoModel>(data, new JsonSerializerOptions().SnakeCaseLower());
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Unable to get crypto info for symbol {symbol}");
            }

            return null;
        }

        public async Task<CryptoQuotationModel> GetCryptoQuotation(string symbol, string convertTo = null)
        {
            try
            {
                var url = convertTo is null ? $"v2/cryptocurrency/quotes/latest?symbol={symbol}" : $"v2/cryptocurrency/quotes/latest?symbol={symbol}&convert={convertTo}";

                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadAsStringAsync();

                CryptoQuotationModel model = JsonSerializer.Deserialize<CryptoQuotationModel>(data, new JsonSerializerOptions().SnakeCaseLower());
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Unable to get crypto quotation for symbol {symbol}");
            }

            return null;
        }
    }
}
