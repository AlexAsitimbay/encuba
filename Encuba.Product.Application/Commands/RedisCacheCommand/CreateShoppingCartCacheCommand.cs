using Encuba.Product.Domain.Dtos;
using MediatR;

namespace Encuba.Product.Application.Commands.RedisCacheCommand;

public record CreateShoppingCartCacheCommand(
    List<Guid> ProductIds,
    Guid UserId,
    int Quantity
    ) : IRequest<EntityResponse<bool>>
{
    
}