using System.ComponentModel.DataAnnotations;

namespace Cryptocurrency.Quotation.Contracts.Quotations
{
    public class CryptoQuotationQuery
    {
        [Required]
        public string Symbol { get; set; }
        public string ConvertTo { get; set; } = null;
    }
}
