using AutoMapper;
using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap;
using Cryptocurrency.Quotation.Domain.Notifications;
using Cryptocurrency.Quotation.Domain.Quotations;
using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Application.Quotations
{
    public class CryptoQuotationService : ICryptoQuotationService
    {
        private readonly ICoinMarketCapApi _coinMarketCapApi;
        private readonly IMapper _mapper;
        private readonly INotificationContext _notificationContext;

        public CryptoQuotationService(ICoinMarketCapApi coinMarketCapApi, IMapper mapper, INotificationContext notificationContext)
        {
            _coinMarketCapApi = coinMarketCapApi;
            _mapper = mapper;
            _notificationContext = notificationContext;
        }

        public async Task<CryptoQuotation> GetCryptoQuotation(string symbol, string convertTo = null)
        {
            var model = await _coinMarketCapApi.GetCryptoQuotation(symbol, convertTo);
            if (model is null)
            {
                _notificationContext.AddValidationError("UNABLE_TO_GET_QUOTATION");
                return null;
            }

            CryptoQuotation cryptoQuotation = _mapper.Map<CryptoQuotation>(model);

            return cryptoQuotation;
        }
    }
}
