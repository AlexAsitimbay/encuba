using System.Net;
using Encuba.Product.Api.Dtos.ShoppingCartRequests;
using Encuba.Product.Application.Commands.RedisCacheCommand;
using Encuba.Product.Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Encuba.Product.Api.Controllers;

[ApiController]
[Route("shopping-cart")]
public class ShoppingCartController(ILogger<ProductController> logger, ISender sender) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Forbidden)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Produces(typeof(bool))]
    [ProducesErrorResponseType(typeof(EntityErrorResponse))]
    public async Task<IActionResult> Create(CreateShoppingCartRequest request)
    {
        var command = request.ToApplicationRequest();

        logger.LogInformation(
            "----- Sending command: {CommandName} {@Command})",
            nameof(command),
            command);

        var response = await sender.Send(command);
        if (!response.IsSuccess)
        {
            return BadRequest(response.EntityErrorResponse);
        }

        return CreatedAtAction(nameof(Create), response);
    }
    
    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.Forbidden)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [Produces(typeof(bool))]
    [ProducesErrorResponseType(typeof(EntityErrorResponse))]
    [Route("add-cart-cache")]
    public async Task<IActionResult> CreateCache(CreateShoppingCartCacheRequest request)
    {
        var command = request.ToApplicationRequest();

        logger.LogInformation(
            "----- Sending command: {CommandName} {@Command})",
            nameof(command),
            command);

        var response = await sender.Send(command);
        if (!response.IsSuccess)
        {
            return BadRequest(response.EntityErrorResponse);
        }

        return CreatedAtAction(nameof(Create), response);
    }
    
}