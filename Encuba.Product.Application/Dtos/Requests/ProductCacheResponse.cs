namespace Encuba.Product.Application.Dtos.Requests;

public record ProductCacheResponse(
    Guid UserId,
    List<Guid> ProductIds,
    int Quantity);
