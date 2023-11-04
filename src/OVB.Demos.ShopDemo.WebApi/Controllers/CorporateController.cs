using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using OVB.Demos.ShopDemo.WebApi.Controllers.Payloads;
using System.Net.Mime;
using System.Text.Json.Serialization;

namespace OVB.Demos.ShopDemo.WebApi.Controllers;

[Route("api/v1/backoffice/corporate")]
[ApiController]
public sealed class CorporateController : ControllerBase
{
    [HttpGet]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [EnableRateLimiting("RateLimiting")]
    [Route("authorization/code")]
    [AllowAnonymous]
    public async Task<IActionResult> AuthorizationCorporateCodeAsync(
        [FromHeader] Guid clientId,
        [FromHeader] Guid clientSecret,
        [FromHeader(Name = "X-Idempotency-Key")] string idempotencyKey,
        [FromHeader(Name = "X-Correlation-Id")] Guid correlationId,
        [FromHeader(Name = "X-Execution-User")] string executionUser,
        [FromHeader(Name = "X-Source-Platform")] string sourcePlatform,
        [FromBody] AuthorizationCorporateCodePayloadInput input,
        CancellationToken cancellationToken)
    {
        HttpContext.Response.Headers.Add("X-Idempotency-Key", idempotencyKey);
        HttpContext.Response.Headers.Add("X-Correlation-Id", correlationId.ToString());
        HttpContext.Response.Headers.Add("X-Execution-User", executionUser);
        HttpContext.Response.Headers.Add("X-Source-Platform", sourcePlatform);

        return StatusCode(StatusCodes.Status201Created);
    }
}
