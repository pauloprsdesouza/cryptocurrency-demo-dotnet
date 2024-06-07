using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Domain.Quotations
{
    public interface ICryptoQuotationService
    {
        Task<CryptoQuotation> GetCryptoQuotation(string symbol, string convertTo = null);
    }
}
