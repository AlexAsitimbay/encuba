using Encuba.Product.Application.Commands.RedisCacheCommand;

namespace Encuba.Product.Api.Dtos.ShoppingCartRequests;

public record CreateShoppingCartCacheRequest(
    Guid UserId,
    List<Guid> ProductIds,
    int Quantity)
{
    public CreateShoppingCartCacheCommand ToApplicationRequest()
    {
        return new CreateShoppingCartCacheCommand(ProductIds, UserId, Quantity);
    }
}