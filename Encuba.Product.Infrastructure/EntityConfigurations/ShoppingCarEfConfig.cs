using Encuba.Product.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Encuba.Product.Infrastructure.EntityConfigurations;

public class ShoppingCarEfConfig : IEntityTypeConfiguration<ShoppingCart>
{
    public void Configure(EntityTypeBuilder<ShoppingCart> builder)
    {
        builder.ToTable(nameof(ShoppingCart));

        builder.HasKey(t => t.Id);

        builder.Property(t => t.UserId)
            .IsUnicode(false);
        
        builder.Property(t => t.ProductId)
            .IsUnicode(false);
    }
}