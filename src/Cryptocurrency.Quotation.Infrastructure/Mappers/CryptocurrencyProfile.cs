using AutoMapper;
using Cryptocurrency.Quotation.Contracts.Cryptocurrencies;
using Cryptocurrency.Quotation.Contracts.CryptoStatus;
using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap.Models;
using Cryptocurrency.Quotation.Domain.Cryptocurrencies;
using Cryptocurrency.Quotation.Domain.CryptoStatus;

namespace Cryptocurrency.Quotation.Infrastructure.Mappers
{
    public class CryptocurrencyProfile : Profile
    {
        public CryptocurrencyProfile()
        {
            CreateMap<CryptoInfoModel, CryptoInfo>().ReverseMap();
            CreateMap<CryptoInfo, CryptoInfoResponse>();

            CreateMap<CoinDataModel, CoinData>().ReverseMap();
            CreateMap<CoinData, CoinDataResponse>();

            CreateMap<CryptoStatusModel, Status>().ReverseMap();
            CreateMap<Status, StatusResponse>();

            CreateMap<UrlsModel, Urls>().ReverseMap();
            CreateMap<Urls, UrlsResponse>();
        }
    }
}
