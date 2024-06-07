using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Domain.Cryptocurrencies
{
    public interface ICryptoInfoService
    {
        Task<CryptoInfo> GetCryptoInfo(string symbol);
    }
}
