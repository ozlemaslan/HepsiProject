using HepsiProject.Domain.Common;

namespace HepsiProject.Domain.Entities
{
    public class ProductDetail : EntityBase
    {
        
        public ProductDetail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
        }

        public ProductDetail()
        {
            
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
