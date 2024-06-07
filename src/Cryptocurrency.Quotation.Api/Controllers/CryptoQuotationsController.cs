using AutoMapper;
using Cryptocurrency.Quotation.Contracts.Quotations;
using Cryptocurrency.Quotation.Domain.Quotations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Api.Controllers
{
    [Route("/v1/crypto-quotations")]
    public class CryptoQuotationsController : Controller
    {
        private readonly ICryptoQuotationService _cryptoQuotationService;
        private readonly IMapper _mapper;

        public CryptoQuotationsController(ICryptoQuotationService cryptoQuotationService, IMapper mapper)
        {
            _cryptoQuotationService = cryptoQuotationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCryptoQuotation([FromQuery] CryptoQuotationQuery quotationQuery)
        {
            var cryptoInfo = await _cryptoQuotationService.GetCryptoQuotation(quotationQuery.Symbol, quotationQuery.ConvertTo);
            var response = _mapper.Map<CryptoQuotationResponse>(cryptoInfo);

            return Ok(response);
        }
    }
}
