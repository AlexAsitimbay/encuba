using Encuba.Product.Domain.Entities;
using Encuba.Product.Domain.Interfaces.Repositories;
using Encuba.Product.Domain.Seed;

namespace Encuba.Product.Infrastructure.Repositories;

public class ShoppingCartRepository(SecurityDbContext dbContext) : IShoppingCartRepository
{
    public IUnitOfWork UnitOfWork => dbContext;

    public ShoppingCart Add(ShoppingCart shoppingCart)
    {
        return dbContext.Add(shoppingCart).Entity;
    }
}