using System.Net;
using Encuba.Product.Application.Dtos.Responses;
using Encuba.Product.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Encuba.Product.Api.Controllers;

[ApiController]
[Route("product")]
public class ProductController(ILogger<ProductController> logger) : ControllerBase
{
    [HttpGet]
    [Authorize]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Forbidden)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Produces(typeof(PublicAccessTokenResponse))]
    [ProducesErrorResponseType(typeof(EntityErrorResponse))]
    [Route("{productId:int}")]
    public IActionResult GetProduct(int productId)
    {
        return Ok(2);
    }
}