using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ImpuestosInternos.WebApi.Core.Exception;

public class ApiExceptionFilter: IExceptionFilter
{
    private readonly ILogger<ApiExceptionFilter> _logger;

    public ApiExceptionFilter(ILogger<ApiExceptionFilter> logger)
    {
        _logger = logger;
    }
    public void OnException(ExceptionContext context)
    {
        this._logger.LogError(context.Exception, context.Exception.Message);
        context.Result = new StatusCodeResult(500);
        context.ExceptionHandled = true;
    }
}