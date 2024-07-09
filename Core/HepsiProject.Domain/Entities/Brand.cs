using HepsiProject.Domain.Common;

namespace HepsiProject.Domain.Entities
{
    public class Brand : EntityBase
    {
        public string BrandName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Brand> Brands { get; set; }

        public Brand()
        {
            
        }

        public Brand(string brandName,int categoryId)
        {
            BrandName = brandName;
            CategoryId = categoryId;
        }
    }
}
