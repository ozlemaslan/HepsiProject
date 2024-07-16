using Bogus;
using HepsiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HepsiProject.Persistence.Configurations
{
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            Faker faker = new Faker("tr");

            ProductDetail productDetail1 = new ProductDetail()
            {
                Id = 1,
                CategoryId = 1,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Sentence(5)
            };
            ProductDetail productDetail2 = new ProductDetail()
            {
                Id = 2,
                CategoryId = 2,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Sentence(5)
            };
            ProductDetail productDetail3 = new ProductDetail()
            {
                Id = 3,
                CategoryId = 3,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Sentence(5)
            };

            builder.HasData(productDetail1, productDetail2, productDetail3);
        }
    }
}
