using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap.Models;
using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap
{
    public interface ICoinMarketCapApi
    {
        Task<CryptoInfoModel> GetCryptoInfo(string symbol);
        Task<CryptoQuotationModel> GetCryptoQuotation(string symbol, string convertTo = null);
    }
}
