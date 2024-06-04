using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;

namespace Cryptocurrency.Quotation.Api.Filter
{
    public class RequestValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                Dictionary<string, List<string>> errors = context.ModelState
                    .ToDictionary(entry => entry.Key, entry => entry.Value.Errors
                        .Select(modelError => modelError.ErrorMessage)
                        .ToList());

                context.Result = new JsonResult(new { errors })
                {
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
        }
    }
}
