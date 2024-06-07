using AutoMapper;
using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap;
using Cryptocurrency.Quotation.Domain.Cryptocurrencies;
using Cryptocurrency.Quotation.Domain.Notifications;
using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Application.Cryptocurrencies
{
    public class CryptoInfoService : ICryptoInfoService
    {
        private readonly ICoinMarketCapApi _coinMarketCapApi;
        private readonly IMapper _mapper;
        private readonly INotificationContext _notificationContext;

        public CryptoInfoService(ICoinMarketCapApi coinMarketCapApi, IMapper mapper, INotificationContext notificationContext)
        {
            _coinMarketCapApi = coinMarketCapApi;
            _mapper = mapper;   
            _notificationContext = notificationContext;
        }

        public async Task<CryptoInfo> GetCryptoInfo(string symbol)
        {
            var model = await _coinMarketCapApi.GetCryptoInfo(symbol);
            if(model is null)
            {
                _notificationContext.AddValidationError("UNABLE_TO_GET_SYMBOL_INFO");
                return null;
            }

            CryptoInfo cryptoInfo = _mapper.Map<CryptoInfo>(model);

            return cryptoInfo;
        }
    }
}
