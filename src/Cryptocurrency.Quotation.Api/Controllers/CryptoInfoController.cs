using AutoMapper;
using Cryptocurrency.Quotation.Contracts.Cryptocurrencies;
using Cryptocurrency.Quotation.Domain.Cryptocurrencies;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cryptocurrency.Quotation.Api.Controllers
{
    [Route("/v1/crypto-info")]
    public class CryptoInfoController : Controller
    {
        private readonly ICryptoInfoService _cryptoInforService;
        private readonly IMapper _mapper;

        public CryptoInfoController(ICryptoInfoService cryptoInforService, IMapper mapper)
        {
            _cryptoInforService = cryptoInforService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{symbol}")]
        public async Task<IActionResult> GetCryptoInfo([FromRoute] string symbol)
        {
            var cryptoInfo = await _cryptoInforService.GetCryptoInfo(symbol);
            var response = _mapper.Map<CryptoInfoResponse>(cryptoInfo);

            return Ok(response);
        }
    }
}
