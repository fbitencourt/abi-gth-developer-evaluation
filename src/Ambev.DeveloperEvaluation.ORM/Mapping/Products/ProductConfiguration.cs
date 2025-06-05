using Ambev.DeveloperEvaluation.Domain.Entities.Products;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.ORM.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");
            builder.ConfigureBaseEntity();

            builder.HasData(
                new
                {
                    Id = Guid.Parse("637bca77-4d2b-499e-bfe6-a0e5fa0e1257"),
                    CreatedAt = new DateTime(1986, 1, 28, 11, 39, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(1986, 1, 28, 11, 39, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("d3baf233-68da-4b9a-871a-8f0aa723101b"),
                    CreatedAt = new DateTime(1986, 4, 26, 1, 23, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(1986, 4, 26, 1, 23, 0, DateTimeKind.Utc)
                });
                        
            builder.OwnsOne(p => p.SKU, skuBuilder =>
            {
                skuBuilder.Property(p => p.Value).HasMaxLength(50);

                skuBuilder.HasData(
                    new
                    {
                        ProductId = Guid.Parse("637bca77-4d2b-499e-bfe6-a0e5fa0e1257"),
                        Value = "PROD-001"
                    },
                    new
                    {
                        ProductId = Guid.Parse("d3baf233-68da-4b9a-871a-8f0aa723101b"),
                        Value = "PROD-002"
                    });
            });
                        
            builder.OwnsOne(p => p.Info, infoBuilder =>
            {
                infoBuilder.Property(i => i.Name).IsRequired().HasMaxLength(100);
                infoBuilder.Property(i => i.Description).IsRequired().HasMaxLength(500);
                infoBuilder.WithOwner();

                infoBuilder.HasData(
                    new
                    {
                        ProductId = Guid.Parse("637bca77-4d2b-499e-bfe6-a0e5fa0e1257"),
                        Name = "Product 1",
                        Description = "Description for Product 1"
                    },
                    new
                    {
                        ProductId = Guid.Parse("d3baf233-68da-4b9a-871a-8f0aa723101b"),
                        Name = "Product 2",
                        Description = "Description for Product 2"
                    });
            });
                        
            builder.OwnsOne(p => p.Price, priceBuilder =>
            {
                priceBuilder.Property(p => p.Value).IsRequired().HasColumnType("decimal(18,2)");
                priceBuilder.Property(p => p.Currency).IsRequired().HasMaxLength(3);
                priceBuilder.WithOwner();

                priceBuilder.HasData(
                    new
                    {
                        ProductId = Guid.Parse("637bca77-4d2b-499e-bfe6-a0e5fa0e1257"),
                        Value = 19.9m,
                        Currency = Currency.BRL
                    },
                    new
                    {
                        ProductId = Guid.Parse("d3baf233-68da-4b9a-871a-8f0aa723101b"),
                        Value = 29.9m,
                        Currency = Currency.BRL
                    });
            });
                        
            builder.OwnsOne(p => p.Image, imageBuilder =>
            {
                imageBuilder.Property(p => p.Url).HasMaxLength(2000);

                imageBuilder.HasData(
                    new
                    {
                        ProductId = Guid.Parse("637bca77-4d2b-499e-bfe6-a0e5fa0e1257"),
                        Url = "https://ambev.developer.evaluation/product1.jpg"
                    },
                    new
                    {
                        ProductId = Guid.Parse("d3baf233-68da-4b9a-871a-8f0aa723101b"),
                        Url = "https://ambev.developer.evaluation/product2.jpg"
                    });
            });
        }
    }
}
