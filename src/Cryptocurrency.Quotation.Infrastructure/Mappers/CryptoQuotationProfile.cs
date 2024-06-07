using AutoMapper;
using Cryptocurrency.Quotation.Contracts.Quotations;
using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap.Models;
using Cryptocurrency.Quotation.Domain.Quotations;

namespace Cryptocurrency.Quotation.Infrastructure.Mappers
{
    public class CryptoQuotationProfile : Profile
    {
        public CryptoQuotationProfile()
        {
            CreateMap<CryptoQuotationModel, CryptoQuotation>().ReverseMap();
            CreateMap<CryptoQuotation, CryptoQuotationResponse>();

            CreateMap<CoinDetailModel, CoinDetail>().ReverseMap();
            CreateMap<CoinDetail, CoinDetailResponse>();

            CreateMap<QuoteDetailModel, QuoteDetail>().ReverseMap();
            CreateMap<QuoteDetail, QuoteDetailResponse>();
        }
    }
}
