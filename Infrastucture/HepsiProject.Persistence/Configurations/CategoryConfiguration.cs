using HepsiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HepsiProject.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new Category()
            {
                Id = 1,
                CategoryName = "Elektrik",
                ParentId = 1,
                Priorty = 0,
            };

            Category category2 = new Category()
            {
                Id = 2,
                CategoryName = "Bilgisayar",
                ParentId = 1,
                Priorty = 1,
            };

            Category category3 = new Category()
            {
                Id = 3,
                CategoryName = "Moda",
                ParentId = 0,
                Priorty = 2,
            };

            builder.HasData(category1, category2, category3);
        }
    }
}
