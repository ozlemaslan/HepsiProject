using Bogus;
using HepsiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HepsiProject.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new Faker("tr");

            Product product1 = new Product()
            {
                Id = 1,
                BrandId = 1,
                Discount = faker.Random.Decimal(),
                Price = faker.Finance.Amount(),
                ProductDescription = faker.Commerce.ProductDescription(),
                ProductName = faker.Commerce.ProductName()
            };

            Product product2 = new Product()
            {
                Id = 2,
                BrandId = 2,
                Discount = faker.Random.Decimal(),
                Price = faker.Finance.Amount(),
                ProductDescription = faker.Commerce.ProductDescription(),
                ProductName = faker.Commerce.ProductName()
            };

            Product product3 = new Product()
            {
                Id = 3,
                BrandId = 3,
                Discount = faker.Random.Decimal(),
                Price = faker.Finance.Amount(),
                ProductDescription = faker.Commerce.ProductDescription(),
                ProductName = faker.Commerce.ProductName()
            };

            builder.HasData(product1, product2, product3);
        }
    }
}
