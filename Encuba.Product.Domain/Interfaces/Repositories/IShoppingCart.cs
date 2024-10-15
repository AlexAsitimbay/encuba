﻿using Encuba.Product.Domain.Entities;
using Encuba.Product.Domain.Seed;

namespace Encuba.Product.Domain.Interfaces.Repositories;

public interface IShoppingCart : IRepository<ShoppingCart>
{
    void Add(ShoppingCart shoppingCart);
}