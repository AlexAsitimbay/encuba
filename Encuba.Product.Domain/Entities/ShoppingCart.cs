using Encuba.Product.Domain.Seed;

namespace Encuba.Product.Domain.Entities;

public class ShoppingCart : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }

    protected ShoppingCart()
    {
        Id = Guid.NewGuid();
    }

    public ShoppingCart(Guid userId, Guid productId)
        : this()
    {
        UserId = userId;
        ProductId = productId;
    }
}