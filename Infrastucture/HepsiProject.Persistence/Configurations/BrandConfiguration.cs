using Bogus;
using HepsiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HepsiProject.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.BrandName).HasMaxLength(256);

            Faker faker = new ("tr");

            Brand brand1 = new Brand()
            {
                Id = 1,
                BrandName = faker.Commerce.Department()
            };

            Brand brand2 = new Brand()
            {
                Id = 1,
                BrandName = faker.Commerce.Department()
            };

            Brand brand3 = new Brand()
            {
                Id = 3,
                BrandName = faker.Commerce.Department()
            };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}
