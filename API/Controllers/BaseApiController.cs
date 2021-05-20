using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices
            .GetService<IMediator>();
    }
}